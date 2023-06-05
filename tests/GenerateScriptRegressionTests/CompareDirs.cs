using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit.Abstractions;

namespace GenerateScriptRegressionTests;

internal class CompareDirs
{
    public static bool Compare(string pathA, string pathB, ITestOutputHelper outputHelper)
    {

        DirectoryInfo dir1 = new DirectoryInfo(pathA);
        DirectoryInfo dir2 = new DirectoryInfo(pathB);

        List<FileInfo> list1 = dir1.GetFiles("*.*", SearchOption.AllDirectories).ToList();
        List<FileInfo> list2 = dir2.GetFiles("*.*", SearchOption.AllDirectories).ToList();

        FileCompare myFileCompare = new FileCompare();

        bool areIdentical = list1.SequenceEqual(list2, myFileCompare);

        if (areIdentical == true)
        {
            for(int i = 0; i<list1.Count();i++)
            {
                areIdentical &= FileCompare(list1[i].FullName, list2[i].FullName);
                outputHelper.WriteLine(string.Format("File {0} is modified!",list1[i].FullName));
            }
        }
        return areIdentical;
    }

    private static bool FileCompare(string file1, string file2)
    {
        int file1byte;
        int file2byte;
        FileStream fs1;
        FileStream fs2;

        fs1 = new FileStream(file1, FileMode.Open);
        fs2 = new FileStream(file2, FileMode.Open);

        if (fs1.Length != fs2.Length)
        {
            fs1.Close();
            fs2.Close();
            return false;
        }

        do
        {
            file1byte = fs1.ReadByte();
            file2byte = fs2.ReadByte();
        }
        while ((file1byte == file2byte) && (file1byte != -1));

        fs1.Close();
        fs2.Close();

        return ((file1byte - file2byte) == 0);
    }
}

class FileCompare : IEqualityComparer<FileInfo>
{
    public FileCompare() { }

    public bool Equals(FileInfo? f1, FileInfo? f2)
    {
        if(f1 is not null && f2 is not null)
        {
            return (f1.Name == f2.Name && f1.Length == f2.Length);
        }
        else
        {
            return false;
        }
    }

    public int GetHashCode(FileInfo fi)
    {        
        string s = $"{fi.Name}{fi.Length}";
        return s.GetHashCode();
    }
}
