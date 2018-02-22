using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveDataTest()
        {
            //arrange
            var repository = new VendorRepository();
            var expected = 42;

            //act
            var actual = repository.RetrieveData<int>( "Select.....", 42 );

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveDataTestString()
        {
            //arrange
            var repository = new VendorRepository();
            var expected = "test";

            //act
            var actual = repository.RetrieveData<string>("Select.....", "test");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}