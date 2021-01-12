﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.Toolkit.Uwp.UI.Lottie.IR.Treeless.RenderingContexts
{
    sealed class MasksRenderingContext : RenderingContext
    {
        public MasksRenderingContext(IReadOnlyList<Mask> masks)
            => Masks = masks;

        public IReadOnlyList<Mask> Masks { get; }

        public override string ToString() => $"Mask {Masks}";
    }
}