﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Scaffolding.Internal
{
    public interface IModelScaffolder
    {
        ReverseEngineerFiles Generate(
               [NotNull] string connectionString,
               [NotNull] TableSelectionSet tableSelectionSet,
               [NotNull] string projectPath,
               [CanBeNull] string outputPath,
               [NotNull] string rootNamespace,
               [CanBeNull] string contextName,
               bool useDataAnnotations,
               bool overwriteFiles);
    }
}
