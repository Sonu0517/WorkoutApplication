using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestFixture]
    public class CategoryTest
    {
        [Test]
        public static void ListCategory()
        {
            var obj = new CasestudyEntities();
            var expected = 0;
            var actual = obj.workout_category.Count();
            Assert.AreEqual(expected, actual);
        }
    }
}