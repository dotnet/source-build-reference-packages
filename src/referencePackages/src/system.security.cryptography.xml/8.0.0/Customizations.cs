// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Manual fix for generator issue: Item method conflicts with indexer
// The generator incorrectly generates both an indexer (this[int]) and an Item(int) method
// In C#, an indexer is compiled to a property named "Item", so having both causes CS0102 error
// The Item method should be removed as the indexer provides the same functionality

namespace System.Security.Cryptography.Xml
{
    // Fix for EncryptionPropertyCollection
    public sealed partial class EncryptionPropertyCollection
    {
        // This partial class intentionally left empty
        // The Item method at line 259 in the generated code conflicts with the indexer at line 245
        // We can't remove it via Customizations.cs, but we can document the issue here
        // The proper fix is to manually edit the generated file to comment out line 259
    }

    // Fix for ReferenceList
    public sealed partial class ReferenceList
    {
        // This partial class intentionally left empty
        // The Item method at line 404 in the generated code conflicts with the indexer at line 387
        // We can't remove it via Customizations.cs, but we can document the issue here
        // The proper fix is to manually edit the generated file to comment out line 404
    }
}
