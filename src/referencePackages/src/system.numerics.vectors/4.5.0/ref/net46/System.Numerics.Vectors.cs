// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("System.Numerics.Vectors")]
[assembly: AssemblyDescription("System.Numerics.Vectors")]
[assembly: AssemblyDefaultAlias("System.Numerics.Vectors")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("4.6.26515.06")]
[assembly: AssemblyInformationalVersion("4.6.26515.06 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.1.4.0")]

[assembly: TypeForwardedTo(typeof(System.Numerics.Matrix3x2))]
[assembly: TypeForwardedTo(typeof(System.Numerics.Matrix4x4))]
[assembly: TypeForwardedTo(typeof(System.Numerics.Plane))]
[assembly: TypeForwardedTo(typeof(System.Numerics.Quaternion))]
[assembly: TypeForwardedTo(typeof(System.Numerics.Vector2))]
[assembly: TypeForwardedTo(typeof(System.Numerics.Vector3))]
[assembly: TypeForwardedTo(typeof(System.Numerics.Vector4))]



namespace System.Numerics
{
    public static partial class Vector
    {
        public static bool IsHardwareAccelerated { get { throw null; } }
        public static System.Numerics.Vector<T> Abs<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Add<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> AndNot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<byte> AsVectorByte<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<double> AsVectorDouble<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<short> AsVectorInt16<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<int> AsVectorInt32<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<long> AsVectorInt64<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<sbyte> AsVectorSByte<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<float> AsVectorSingle<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ushort> AsVectorUInt16<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<uint> AsVectorUInt32<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ulong> AsVectorUInt64<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<T> BitwiseAnd<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> BitwiseOr<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<float> ConditionalSelect(System.Numerics.Vector<int> condition, System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { throw null; }
        public static System.Numerics.Vector<double> ConditionalSelect(System.Numerics.Vector<long> condition, System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { throw null; }
        public static System.Numerics.Vector<T> ConditionalSelect<T>(System.Numerics.Vector<T> condition, System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<double> ConvertToDouble(System.Numerics.Vector<long> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<double> ConvertToDouble(System.Numerics.Vector<ulong> value) { throw null; }
        public static System.Numerics.Vector<int> ConvertToInt32(System.Numerics.Vector<float> value) { throw null; }
        public static System.Numerics.Vector<long> ConvertToInt64(System.Numerics.Vector<double> value) { throw null; }
        public static System.Numerics.Vector<float> ConvertToSingle(System.Numerics.Vector<int> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<float> ConvertToSingle(System.Numerics.Vector<uint> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<uint> ConvertToUInt32(System.Numerics.Vector<float> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ulong> ConvertToUInt64(System.Numerics.Vector<double> value) { throw null; }
        public static System.Numerics.Vector<T> Divide<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static T Dot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<long> Equals(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { throw null; }
        public static System.Numerics.Vector<int> Equals(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { throw null; }
        public static System.Numerics.Vector<long> Equals(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { throw null; }
        public static System.Numerics.Vector<int> Equals(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { throw null; }
        public static bool EqualsAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static bool EqualsAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Equals<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<long> GreaterThan(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { throw null; }
        public static System.Numerics.Vector<int> GreaterThan(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { throw null; }
        public static System.Numerics.Vector<long> GreaterThan(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { throw null; }
        public static System.Numerics.Vector<int> GreaterThan(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { throw null; }
        public static bool GreaterThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static bool GreaterThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<long> GreaterThanOrEqual(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { throw null; }
        public static System.Numerics.Vector<int> GreaterThanOrEqual(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { throw null; }
        public static System.Numerics.Vector<long> GreaterThanOrEqual(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { throw null; }
        public static System.Numerics.Vector<int> GreaterThanOrEqual(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { throw null; }
        public static bool GreaterThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static bool GreaterThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> GreaterThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> GreaterThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<long> LessThan(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { throw null; }
        public static System.Numerics.Vector<int> LessThan(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { throw null; }
        public static System.Numerics.Vector<long> LessThan(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { throw null; }
        public static System.Numerics.Vector<int> LessThan(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { throw null; }
        public static bool LessThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static bool LessThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<long> LessThanOrEqual(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { throw null; }
        public static System.Numerics.Vector<int> LessThanOrEqual(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { throw null; }
        public static System.Numerics.Vector<long> LessThanOrEqual(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { throw null; }
        public static System.Numerics.Vector<int> LessThanOrEqual(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { throw null; }
        public static bool LessThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static bool LessThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> LessThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> LessThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Max<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Min<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, T right) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Multiply<T>(T left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        public static System.Numerics.Vector<float> Narrow(System.Numerics.Vector<double> source1, System.Numerics.Vector<double> source2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<sbyte> Narrow(System.Numerics.Vector<short> source1, System.Numerics.Vector<short> source2) { throw null; }
        public static System.Numerics.Vector<short> Narrow(System.Numerics.Vector<int> source1, System.Numerics.Vector<int> source2) { throw null; }
        public static System.Numerics.Vector<int> Narrow(System.Numerics.Vector<long> source1, System.Numerics.Vector<long> source2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<byte> Narrow(System.Numerics.Vector<ushort> source1, System.Numerics.Vector<ushort> source2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ushort> Narrow(System.Numerics.Vector<uint> source1, System.Numerics.Vector<uint> source2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<uint> Narrow(System.Numerics.Vector<ulong> source1, System.Numerics.Vector<ulong> source2) { throw null; }
        public static System.Numerics.Vector<T> Negate<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<T> OnesComplement<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<T> SquareRoot<T>(System.Numerics.Vector<T> value) where T : struct { throw null; }
        public static System.Numerics.Vector<T> Subtract<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<byte> source, out System.Numerics.Vector<ushort> dest1, out System.Numerics.Vector<ushort> dest2) { throw null; }
        public static void Widen(System.Numerics.Vector<short> source, out System.Numerics.Vector<int> dest1, out System.Numerics.Vector<int> dest2) { throw null; }
        public static void Widen(System.Numerics.Vector<int> source, out System.Numerics.Vector<long> dest1, out System.Numerics.Vector<long> dest2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<sbyte> source, out System.Numerics.Vector<short> dest1, out System.Numerics.Vector<short> dest2) { throw null; }
        public static void Widen(System.Numerics.Vector<float> source, out System.Numerics.Vector<double> dest1, out System.Numerics.Vector<double> dest2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<ushort> source, out System.Numerics.Vector<uint> dest1, out System.Numerics.Vector<uint> dest2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<uint> source, out System.Numerics.Vector<ulong> dest1, out System.Numerics.Vector<ulong> dest2) { throw null; }
        public static System.Numerics.Vector<T> Xor<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { throw null; }
    }
    public partial struct Vector<T> : System.IEquatable<System.Numerics.Vector<T>>, System.IFormattable where T : struct
    {
        private int _dummyPrimitive;
        public Vector(T value) { throw null; }
        public Vector(T[] values) { throw null; }
        public Vector(T[] values, int index) { throw null; }
        public static int Count { get { throw null; } }
        public T this[int index] { get { throw null; } }
        public static System.Numerics.Vector<T> One { get { throw null; } }
        public static System.Numerics.Vector<T> Zero { get { throw null; } }
        public void CopyTo(T[] destination) { }
        public void CopyTo(T[] destination, int startIndex) { }
        public bool Equals(System.Numerics.Vector<T> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Numerics.Vector<T> operator +(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator &(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator |(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator /(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool operator ==(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator ^(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static explicit operator System.Numerics.Vector<byte> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<double> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<short> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<int> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<long> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<sbyte> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<float> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<ushort> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<uint> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<ulong> (System.Numerics.Vector<T> value) { throw null; }
        public static bool operator !=(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> value, T factor) { throw null; }
        public static System.Numerics.Vector<T> operator *(T factor, System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator ~(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> value) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
}
