﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Physics2D.Collision.Shapes;

namespace UnitTest.Collision.Shapes
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TestNewId()
        {
            Assert.AreEqual(1, Shape.NewId());
            Assert.AreEqual(2, Shape.NewId());
        }
    }
}
