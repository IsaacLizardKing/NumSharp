﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumSharp.Core
{
    public static partial class NumPy
    {
        public static NDArray reshape(NDArray nd, params int[] shape)
        {
            nd.reshape(shape);
            return nd;
        }
    }
}
