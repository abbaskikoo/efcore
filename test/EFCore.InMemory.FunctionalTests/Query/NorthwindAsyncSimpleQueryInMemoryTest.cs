// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class NorthwindAsyncSimpleQueryInMemoryTest : NorthwindAsyncSimpleQueryTestBase<
        NorthwindQueryInMemoryFixture<NoopModelCustomizer>>
    {
        public NorthwindAsyncSimpleQueryInMemoryTest(NorthwindQueryInMemoryFixture<NoopModelCustomizer> fixture)
            : base(fixture)
        {
        }

        // mapping to view not supported on InMemory
        public override Task Query_backed_by_database_view()
            => Task.CompletedTask;
    }
}
