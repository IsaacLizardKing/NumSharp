﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NumSharp.Core.Extensions;
using np = NumSharp.Core.NumPy;

namespace NumSharp.UnitTest
{
    [TestClass]
    public class NDArrayRandomTest
    {
        [TestMethod]
        public void randn()
        {
            var n = np.random.randn(5, 2);
        }

        [TestMethod]
        public void normal()
        {
            var n = np.random.normal(0, 1, 5);
        }
    }
}
