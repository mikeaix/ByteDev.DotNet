﻿using System.Xml.Linq;
using NUnit.Framework;

namespace ByteDev.DotNet.IntTests
{
    [TestFixture]
    public class DotNetProjectTests
    {
        [Test]
        public void WhenProjectXmlIsStandard_ThenReturnTargetFramework()
        {
            var xDocument = XDocument.Load(@"TestProjs\std20.xml");

            var sut = new DotNetProject(xDocument);

            Assert.That(sut.TargetFramework, Is.EqualTo("netstandard2.0"));
        }
    }
}