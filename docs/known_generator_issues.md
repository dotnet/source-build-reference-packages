# Known issues

## The explicit declaration of `TupleElementNamesAttribute` attribute

```text
error CS8138: Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.
```

Workaround: update the declaration using tuple syntax to define tuple names. Or comment/remove this attribute.

## Circular dependency between reference package and targeting pack

```text
error NU1108: Cycle detected.
error NU1108:   <Reference project> -> NETStandard.Library x.y.z -> <Reference project>
```

Workaround: add the following property to the project.

```xml
<DisableImplicitFrameworkReferences>true</DisableImplicitFrameworkReferences>
```
