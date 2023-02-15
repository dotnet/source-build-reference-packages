# Known issues

## SBRP generator error. Unable to resolve assembly reference
Tracking issue: https://github.com/dotnet/source-build/issues/3237
```
Microsoft.DotNet.GenAPI.Task.targets(44,5): error CP1002: AssemblyLoadWarning: 'Could not resolve reference 'System.Security.Permissions.dll' in any of the provided search directories.'
```
Workaround: Try to compile reference packages and solve compilation errors.

## Unsupported `netcoreapp3.1` TFM
Reference packages for TFM `netcoreapp3.1` is not supported. You may get numerous compilation issues like:
```
*/lib/netcoreapp3.1/*: error CS0246: The type or namespace name 'DebuggableAttribute' could not be found
*/lib/netcoreapp3.1/*: error CS0518: Predefined type 'System.String' is not defined or imported
```
Workaround: update the `*.csproj` file:
* remove `netcoreapp3.1` from the `<TargetFrameworks>` list
* remove `<PropertyGroup>` and `<ItemGroup>` with the `netcoreapp3.1` condition
* remove the `lib\netcoreapp3.1` folder

## CLSCompliant assembly attributes
By default, it is set to true and it may produce compilation errors like:
```
error CS3015: ... has no accessible constructors which use only CLS-compliant types
error CS3016: Arrays as attribute arguments is not CLS-compliant
```
Workaround: update the assembly attribute `[assembly: CLSCompliant(true)]` and set value to `false`

## The explicit declaration of `TupleElementNamesAttribute` attribute
```
error CS8138: Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.
```
Workaround: update the declaration  using tuple syntax to define tuple names. Or comment/remove this attribute.

## Synthesized dummy generic field of filtered type
Reported issue: https://github.com/dotnet/sdk/issues/30627

Example:
```
public readonly partial struct IncrementalValueProvider<TValue>
{
    // error CS0234: The type or namespace name 'IIncrementalGeneratorNode<>' does not exist in the namespace 'Microsoft.CodeAnalysis'
    private readonly CodeAnalysis.IIncrementalGeneratorNode<TValue> Node;
}
```
Workaround: remove the synthesized field.

## Class without implicit constructor defined
Tracking PR: https://github.com/dotnet/sdk/pull/30594

Example
```
public class Bar
{
    public Bar(int a) { }
}

error CS7036: There is no argument given that corresponds to the required parameter 'a' of 'Bar.Bar(int)'
public class Foo : Bar
{
}
```
Workaround: introduce an internal default constructor for the `Foo` class with `internal Foo() : base(default) { }`

## Incorrectly generated synthesized dummy generic field
Tracking PR: https://github.com/dotnet/sdk/pull/30572
```
// error CS1519: Invalid token '<' in class, record, struct, or interface member declaration
private readonly Collections.Immutable.ImmutableArray<CustomAttributeTypedArgument<TType>> <FixedArguments>k__BackingField;
```
Workaround: remove `<FixedArguments>` part of generated field.

## Explicit interface declaration is not found among members of the interface that can be implemented
Tracking issue: https://github.com/dotnet/source-build/issues/3237
```
error CS0539: 'ImmutableArray<T>.Item' in explicit interface declaration is not found among members of the interface that can be implemented
error CS0683: 'ImmutableDictionary<TKey, TValue>.get_Item(TKey)' explicit method implementation cannot implement 'IDictionary<TKey, TValue>.this[TKey].get' because it is an accessor
```
Workaround: manually add indexer, explicit interface declaration methods and remove wrong one as suggest by the compiler.