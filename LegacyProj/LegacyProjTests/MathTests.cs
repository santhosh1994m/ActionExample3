using NUnit.Framework;
using LegacyProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyProj.Tests
{
    public class MathTests
    {
        [Test()]
        public void AddTest()
        {
            var sut = new Math();
            var res = sut.Add(2, 3);
            Assert.That(res, Is.EqualTo(5));
        }
    }
}