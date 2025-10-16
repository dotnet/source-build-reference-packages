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
        // The Item method in the generated code conflicts with the indexer
        // Manual edits were made to comment out the Item method in the generated files
    }

    // Fix for ReferenceList
    public sealed partial class ReferenceList
    {
        // This partial class intentionally left empty
        // The Item method in the generated code conflicts with the indexer
        // Manual edits were made to comment out the Item method in the generated files
    }
}
