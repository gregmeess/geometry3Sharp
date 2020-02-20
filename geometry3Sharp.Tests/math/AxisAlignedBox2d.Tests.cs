﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace g3.Tests.math
{
    [TestClass()]
    public class AxisAlignedBox2DTests
    {
        [TestMethod()]
        public void Contain()
        {
            var box = AxisAlignedBox2d.Empty;
            box.Contain(new Vector2d(1, 2));
            Assert.AreEqual(1, box.Min.x);
            Assert.AreEqual(2, box.Min.y);
            Assert.AreEqual(1, box.Max.x);
            Assert.AreEqual(2, box.Max.y);
        }
    }
}
