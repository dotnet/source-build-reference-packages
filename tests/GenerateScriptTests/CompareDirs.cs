// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit.Abstractions;

namespace GenerateScriptTests;

internal class CompareDirs
{
    public static bool Compare(string pathA, string pathB, ITestOutputHelper outputHelper)
    {
        DirectoryInfo dir1 = new DirectoryInfo(pathA);
        DirectoryInfo dir2 = new DirectoryInfo(pathB);

        List<FileInfo> list1 = dir1.GetFiles("*.*", SearchOption.AllDirectories).ToList();
        List<FileInfo> list2 = dir2.GetFiles("*.*", SearchOption.AllDirectories).ToList();

        FileInfoComparer myFileInfoComparer = new FileInfoComparer();

        bool areIdentical = list1.SequenceEqual(list2, myFileInfoComparer);

        if (!areIdentical)
        {
            var queryList1Only = (from file in list1  
                                  select file).Except(list2, myFileInfoComparer);
            if(queryList1Only.Any())
            {
                outputHelper.WriteLine("The following are missing files:");  
                foreach (var v in queryList1Only)  
                {  
                    outputHelper.WriteLine(v.FullName);  
                }
            }

            var queryList2Only = (from file in list2  
                                  select file).Except(list1, myFileInfoComparer);
            if(queryList2Only.Any())
            {
                outputHelper.WriteLine("The following are new files:");  
                foreach (var v in queryList2Only)  
                {  
                    outputHelper.WriteLine(v.FullName);  
                }
            }
        }
        outputHelper.WriteLine("Start comparing with each files:");

        var queryList1CommonFiles = list1.Intersect(list2, myFileInfoComparer).ToList();
        var queryList2CommonFiles = list2.Intersect(list1, myFileInfoComparer).ToList();

        for (int i = 0; i < queryList1CommonFiles.Count(); i++ )
        {
            if(!FileCompare(queryList1CommonFiles[i].FullName, queryList2CommonFiles[i].FullName))
            {
                areIdentical = false;
                outputHelper.WriteLine($"{queryList1CommonFiles[i].FullName} was modified!");
            }
            else
            {
                 outputHelper.WriteLine($"{queryList1CommonFiles[i].FullName} is identical.");
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

internal class FileInfoComparer : IEqualityComparer<FileInfo>
{
    public FileInfoComparer() { }

    public bool Equals(FileInfo? f1, FileInfo? f2)
    {
        if(f1 is not null && f2 is not null)
        {
            return (f1.Name == f2.Name);
        }
        else
        {
            return false;
        }
    }

    public int GetHashCode(FileInfo fi)
    {        
        string s = $"{fi.Name}";
        return s.GetHashCode();
    }
}
