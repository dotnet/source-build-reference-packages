// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This is necessary to workaround an issue with GenAPI simplifying the compilation unit
// and removing usings incorrectly, but only for System.Runtime.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
