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
[assembly: System.Reflection.AssemblyTitle("System.Numerics.Vectors")]
[assembly: System.Reflection.AssemblyDescription("System.Numerics.Vectors")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Numerics.Vectors")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("4.6.25519.03")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.6.25519.03 built by: dlab-DDVSOWINAGE013. Commit Hash: 8321c729934c0f8be754953439b88e6e1c120c24")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Matrix3x2))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Matrix4x4))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Plane))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Quaternion))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Vector2))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Vector3))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Numerics.Vector4))]
namespace System.Numerics
{
    public static partial class Vector
    {
        public static bool IsHardwareAccelerated { get { throw null; } }

        public static Vector<T> Abs<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<T> Add<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<T> AndNot<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<byte> AsVectorByte<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<double> AsVectorDouble<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<short> AsVectorInt16<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<int> AsVectorInt32<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<long> AsVectorInt64<T>(Vector<T> value)
            where T : struct { throw null; }

        [CLSCompliant(false)]
        public static Vector<sbyte> AsVectorSByte<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<float> AsVectorSingle<T>(Vector<T> value)
            where T : struct { throw null; }

        [CLSCompliant(false)]
        public static Vector<ushort> AsVectorUInt16<T>(Vector<T> value)
            where T : struct { throw null; }

        [CLSCompliant(false)]
        public static Vector<uint> AsVectorUInt32<T>(Vector<T> value)
            where T : struct { throw null; }

        [CLSCompliant(false)]
        public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<T> BitwiseAnd<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<T> BitwiseOr<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<float> ConditionalSelect(Vector<int> condition, Vector<float> left, Vector<float> right) { throw null; }

        public static Vector<double> ConditionalSelect(Vector<long> condition, Vector<double> left, Vector<double> right) { throw null; }

        public static Vector<T> ConditionalSelect<T>(Vector<T> condition, Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<double> ConvertToDouble(Vector<long> value) { throw null; }

        [CLSCompliant(false)]
        public static Vector<double> ConvertToDouble(Vector<ulong> value) { throw null; }

        public static Vector<int> ConvertToInt32(Vector<float> value) { throw null; }

        public static Vector<long> ConvertToInt64(Vector<double> value) { throw null; }

        public static Vector<float> ConvertToSingle(Vector<int> value) { throw null; }

        [CLSCompliant(false)]
        public static Vector<float> ConvertToSingle(Vector<uint> value) { throw null; }

        [CLSCompliant(false)]
        public static Vector<uint> ConvertToUInt32(Vector<float> value) { throw null; }

        [CLSCompliant(false)]
        public static Vector<ulong> ConvertToUInt64(Vector<double> value) { throw null; }

        public static Vector<T> Divide<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static T Dot<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<long> Equals(Vector<double> left, Vector<double> right) { throw null; }

        public static Vector<int> Equals(Vector<int> left, Vector<int> right) { throw null; }

        public static Vector<long> Equals(Vector<long> left, Vector<long> right) { throw null; }

        public static Vector<int> Equals(Vector<float> left, Vector<float> right) { throw null; }

        public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool EqualsAll<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool EqualsAny<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<long> GreaterThan(Vector<double> left, Vector<double> right) { throw null; }

        public static Vector<int> GreaterThan(Vector<int> left, Vector<int> right) { throw null; }

        public static Vector<long> GreaterThan(Vector<long> left, Vector<long> right) { throw null; }

        public static Vector<int> GreaterThan(Vector<float> left, Vector<float> right) { throw null; }

        public static Vector<T> GreaterThan<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool GreaterThanAll<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool GreaterThanAny<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<long> GreaterThanOrEqual(Vector<double> left, Vector<double> right) { throw null; }

        public static Vector<int> GreaterThanOrEqual(Vector<int> left, Vector<int> right) { throw null; }

        public static Vector<long> GreaterThanOrEqual(Vector<long> left, Vector<long> right) { throw null; }

        public static Vector<int> GreaterThanOrEqual(Vector<float> left, Vector<float> right) { throw null; }

        public static Vector<T> GreaterThanOrEqual<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool GreaterThanOrEqualAll<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool GreaterThanOrEqualAny<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<long> LessThan(Vector<double> left, Vector<double> right) { throw null; }

        public static Vector<int> LessThan(Vector<int> left, Vector<int> right) { throw null; }

        public static Vector<long> LessThan(Vector<long> left, Vector<long> right) { throw null; }

        public static Vector<int> LessThan(Vector<float> left, Vector<float> right) { throw null; }

        public static Vector<T> LessThan<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool LessThanAll<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool LessThanAny<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<long> LessThanOrEqual(Vector<double> left, Vector<double> right) { throw null; }

        public static Vector<int> LessThanOrEqual(Vector<int> left, Vector<int> right) { throw null; }

        public static Vector<long> LessThanOrEqual(Vector<long> left, Vector<long> right) { throw null; }

        public static Vector<int> LessThanOrEqual(Vector<float> left, Vector<float> right) { throw null; }

        public static Vector<T> LessThanOrEqual<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool LessThanOrEqualAll<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static bool LessThanOrEqualAny<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<T> Max<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<T> Min<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<T> Multiply<T>(T left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<T> Multiply<T>(Vector<T> left, T right)
            where T : struct { throw null; }

        public static Vector<T> Multiply<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        public static Vector<float> Narrow(Vector<double> source1, Vector<double> source2) { throw null; }

        [CLSCompliant(false)]
        public static Vector<sbyte> Narrow(Vector<short> source1, Vector<short> source2) { throw null; }

        public static Vector<short> Narrow(Vector<int> source1, Vector<int> source2) { throw null; }

        public static Vector<int> Narrow(Vector<long> source1, Vector<long> source2) { throw null; }

        [CLSCompliant(false)]
        public static Vector<byte> Narrow(Vector<ushort> source1, Vector<ushort> source2) { throw null; }

        [CLSCompliant(false)]
        public static Vector<ushort> Narrow(Vector<uint> source1, Vector<uint> source2) { throw null; }

        [CLSCompliant(false)]
        public static Vector<uint> Narrow(Vector<ulong> source1, Vector<ulong> source2) { throw null; }

        public static Vector<T> Negate<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<T> OnesComplement<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<T> SquareRoot<T>(Vector<T> value)
            where T : struct { throw null; }

        public static Vector<T> Subtract<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }

        [CLSCompliant(false)]
        public static void Widen(Vector<byte> source, out Vector<ushort> dest1, out Vector<ushort> dest2) { throw null; }

        public static void Widen(Vector<short> source, out Vector<int> dest1, out Vector<int> dest2) { throw null; }

        public static void Widen(Vector<int> source, out Vector<long> dest1, out Vector<long> dest2) { throw null; }

        [CLSCompliant(false)]
        public static void Widen(Vector<sbyte> source, out Vector<short> dest1, out Vector<short> dest2) { throw null; }

        public static void Widen(Vector<float> source, out Vector<double> dest1, out Vector<double> dest2) { throw null; }

        [CLSCompliant(false)]
        public static void Widen(Vector<ushort> source, out Vector<uint> dest1, out Vector<uint> dest2) { throw null; }

        [CLSCompliant(false)]
        public static void Widen(Vector<uint> source, out Vector<ulong> dest1, out Vector<ulong> dest2) { throw null; }

        public static Vector<T> Xor<T>(Vector<T> left, Vector<T> right)
            where T : struct { throw null; }
    }

    public partial struct Vector<T> : IEquatable<Vector<T>>, IFormattable where T : struct
    {
        public Vector(T value) { }

        public Vector(T[] values, int index) { }

        public Vector(T[] values) { }

        public static int Count { get { throw null; } }

        public T this[int index] { get { throw null; } }

        public static Vector<T> One { get { throw null; } }

        public static Vector<T> Zero { get { throw null; } }

        public void CopyTo(T[] destination, int startIndex) { }

        public void CopyTo(T[] destination) { }

        public bool Equals(Vector<T> other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }

        public static Vector<T> operator +(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator &(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator |(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator /(Vector<T> left, Vector<T> right) { throw null; }

        public static bool operator ==(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator ^(Vector<T> left, Vector<T> right) { throw null; }

        public static explicit operator Vector<byte>(Vector<T> value) { throw null; }

        public static explicit operator Vector<double>(Vector<T> value) { throw null; }

        public static explicit operator Vector<short>(Vector<T> value) { throw null; }

        public static explicit operator Vector<int>(Vector<T> value) { throw null; }

        public static explicit operator Vector<long>(Vector<T> value) { throw null; }

        [CLSCompliant(false)]
        public static explicit operator Vector<sbyte>(Vector<T> value) { throw null; }

        public static explicit operator Vector<float>(Vector<T> value) { throw null; }

        [CLSCompliant(false)]
        public static explicit operator Vector<ushort>(Vector<T> value) { throw null; }

        [CLSCompliant(false)]
        public static explicit operator Vector<uint>(Vector<T> value) { throw null; }

        [CLSCompliant(false)]
        public static explicit operator Vector<ulong>(Vector<T> value) { throw null; }

        public static bool operator !=(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator *(T factor, Vector<T> value) { throw null; }

        public static Vector<T> operator *(Vector<T> value, T factor) { throw null; }

        public static Vector<T> operator *(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator ~(Vector<T> value) { throw null; }

        public static Vector<T> operator -(Vector<T> left, Vector<T> right) { throw null; }

        public static Vector<T> operator -(Vector<T> value) { throw null; }

        public override string ToString() { throw null; }

        public string ToString(string format, IFormatProvider formatProvider) { throw null; }

        public string ToString(string format) { throw null; }
    }
}