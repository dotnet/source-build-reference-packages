// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyTitle("System.Console")]
[assembly: System.Reflection.AssemblyDescription("System.Console")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Console")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("1.0.24212.01")]
[assembly: System.Reflection.AssemblyInformationalVersion("1.0.24212.01. Commit Hash: 9688ddbb62c04189cac4c4a06e31e93377dccd41")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace System
{
    public static partial class Console
    {
        public static ConsoleColor BackgroundColor { get { throw null; } set { } }

        public static int BufferHeight { get { throw null; } set { } }

        public static int BufferWidth { get { throw null; } set { } }

        public static bool CapsLock { get { throw null; } }

        public static int CursorLeft { get { throw null; } set { } }

        public static int CursorSize { get { throw null; } set { } }

        public static int CursorTop { get { throw null; } set { } }

        public static bool CursorVisible { get { throw null; } set { } }

        public static IO.TextWriter Error { get { throw null; } }

        public static ConsoleColor ForegroundColor { get { throw null; } set { } }

        public static IO.TextReader In { get { throw null; } }

        public static Text.Encoding InputEncoding { get { throw null; } set { } }

        public static bool IsErrorRedirected { get { throw null; } }

        public static bool IsInputRedirected { get { throw null; } }

        public static bool IsOutputRedirected { get { throw null; } }

        public static bool KeyAvailable { get { throw null; } }

        public static int LargestWindowHeight { get { throw null; } }

        public static int LargestWindowWidth { get { throw null; } }

        public static bool NumberLock { get { throw null; } }

        public static IO.TextWriter Out { get { throw null; } }

        public static Text.Encoding OutputEncoding { get { throw null; } set { } }

        public static string Title { get { throw null; } set { } }

        public static bool TreatControlCAsInput { get { throw null; } set { } }

        public static int WindowHeight { get { throw null; } set { } }

        public static int WindowLeft { get { throw null; } set { } }

        public static int WindowTop { get { throw null; } set { } }

        public static int WindowWidth { get { throw null; } set { } }

        public static event ConsoleCancelEventHandler CancelKeyPress { add { } remove { } }

        public static void Beep() { }

        public static void Beep(int frequency, int duration) { }

        public static void Clear() { }

        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor) { }

        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) { }

        public static IO.Stream OpenStandardError() { throw null; }

        public static IO.Stream OpenStandardInput() { throw null; }

        public static IO.Stream OpenStandardOutput() { throw null; }

        public static int Read() { throw null; }

        public static ConsoleKeyInfo ReadKey() { throw null; }

        public static ConsoleKeyInfo ReadKey(bool intercept) { throw null; }

        public static string ReadLine() { throw null; }

        public static void ResetColor() { }

        public static void SetBufferSize(int width, int height) { }

        public static void SetCursorPosition(int left, int top) { }

        public static void SetError(IO.TextWriter newError) { }

        public static void SetIn(IO.TextReader newIn) { }

        public static void SetOut(IO.TextWriter newOut) { }

        public static void SetWindowPosition(int left, int top) { }

        public static void SetWindowSize(int width, int height) { }

        public static void Write(bool value) { }

        public static void Write(char value) { }

        public static void Write(char[] buffer, int index, int count) { }

        public static void Write(char[] buffer) { }

        public static void Write(decimal value) { }

        public static void Write(double value) { }

        public static void Write(int value) { }

        public static void Write(long value) { }

        public static void Write(object value) { }

        public static void Write(float value) { }

        public static void Write(string format, object arg0, object arg1, object arg2) { }

        public static void Write(string format, object arg0, object arg1) { }

        public static void Write(string format, object arg0) { }

        public static void Write(string format, params object[] arg) { }

        public static void Write(string value) { }

        [CLSCompliant(false)]
        public static void Write(uint value) { }

        [CLSCompliant(false)]
        public static void Write(ulong value) { }

        public static void WriteLine() { }

        public static void WriteLine(bool value) { }

        public static void WriteLine(char value) { }

        public static void WriteLine(char[] buffer, int index, int count) { }

        public static void WriteLine(char[] buffer) { }

        public static void WriteLine(decimal value) { }

        public static void WriteLine(double value) { }

        public static void WriteLine(int value) { }

        public static void WriteLine(long value) { }

        public static void WriteLine(object value) { }

        public static void WriteLine(float value) { }

        public static void WriteLine(string format, object arg0, object arg1, object arg2) { }

        public static void WriteLine(string format, object arg0, object arg1) { }

        public static void WriteLine(string format, object arg0) { }

        public static void WriteLine(string format, params object[] arg) { }

        public static void WriteLine(string value) { }

        [CLSCompliant(false)]
        public static void WriteLine(uint value) { }

        [CLSCompliant(false)]
        public static void WriteLine(ulong value) { }
    }

    public sealed partial class ConsoleCancelEventArgs : EventArgs
    {
        internal ConsoleCancelEventArgs() { }

        public bool Cancel { get { throw null; } set { } }

        public ConsoleSpecialKey SpecialKey { get { throw null; } }
    }

    public delegate void ConsoleCancelEventHandler(object sender, ConsoleCancelEventArgs e);
    public enum ConsoleColor
    {
        Black = 0,
        DarkBlue = 1,
        DarkGreen = 2,
        DarkCyan = 3,
        DarkRed = 4,
        DarkMagenta = 5,
        DarkYellow = 6,
        Gray = 7,
        DarkGray = 8,
        Blue = 9,
        Green = 10,
        Cyan = 11,
        Red = 12,
        Magenta = 13,
        Yellow = 14,
        White = 15
    }

    public enum ConsoleKey
    {
        Backspace = 8,
        Tab = 9,
        Clear = 12,
        Enter = 13,
        Pause = 19,
        Escape = 27,
        Spacebar = 32,
        PageUp = 33,
        PageDown = 34,
        End = 35,
        Home = 36,
        LeftArrow = 37,
        UpArrow = 38,
        RightArrow = 39,
        DownArrow = 40,
        Select = 41,
        Print = 42,
        Execute = 43,
        PrintScreen = 44,
        Insert = 45,
        Delete = 46,
        Help = 47,
        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        D5 = 53,
        D6 = 54,
        D7 = 55,
        D8 = 56,
        D9 = 57,
        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        Sleep = 95,
        NumPad0 = 96,
        NumPad1 = 97,
        NumPad2 = 98,
        NumPad3 = 99,
        NumPad4 = 100,
        NumPad5 = 101,
        NumPad6 = 102,
        NumPad7 = 103,
        NumPad8 = 104,
        NumPad9 = 105,
        Multiply = 106,
        Add = 107,
        Separator = 108,
        Subtract = 109,
        Decimal = 110,
        Divide = 111,
        F1 = 112,
        F2 = 113,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        F13 = 124,
        F14 = 125,
        F15 = 126,
        F16 = 127,
        F17 = 128,
        F18 = 129,
        F19 = 130,
        F20 = 131,
        F21 = 132,
        F22 = 133,
        F23 = 134,
        F24 = 135,
        Oem1 = 186,
        OemPlus = 187,
        OemComma = 188,
        OemMinus = 189,
        OemPeriod = 190,
        Oem2 = 191,
        Oem3 = 192,
        Oem4 = 219,
        Oem5 = 220,
        Oem6 = 221,
        Oem7 = 222,
        Oem8 = 223,
        OemClear = 254
    }

    public partial struct ConsoleKeyInfo
    {
        public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

        public ConsoleKey Key { get { throw null; } }

        public char KeyChar { get { throw null; } }

        public ConsoleModifiers Modifiers { get { throw null; } }

        public bool Equals(ConsoleKeyInfo obj) { throw null; }

        public override bool Equals(object value) { throw null; }

        public override int GetHashCode() { throw null; }

        public static bool operator ==(ConsoleKeyInfo a, ConsoleKeyInfo b) { throw null; }

        public static bool operator !=(ConsoleKeyInfo a, ConsoleKeyInfo b) { throw null; }
    }

    [Flags]
    public enum ConsoleModifiers
    {
        Alt = 1,
        Shift = 2,
        Control = 4
    }

    public enum ConsoleSpecialKey
    {
        ControlC = 0,
        ControlBreak = 1
    }
}