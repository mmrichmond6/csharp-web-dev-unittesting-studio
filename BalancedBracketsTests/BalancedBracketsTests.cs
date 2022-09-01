using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        /*
        [TestMethod]
        public void EmptyTest1()
        {
            Assert.AreEqual(true, true);
        }
        */

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyFrontBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void BracketsWithStringInMiddleReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[String]"));
        }

        [TestMethod]
        public void OnlyBackBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void StringOutsideAndInsideBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void GivenStringOutsideAndInsideBackwardsBrackets_ReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void GivenNoInput_ReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod] 
        public void GivenDoubleBrackets_ReturnsTrue() 
        { 
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void GivenBackwardsBrackets_ReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void GivenBalancedBracketsWithNumbers_ReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[333]"));
        }

        [TestMethod]
        public void GivenOneBracketWithStringInMiddle_ReturnsFalse()
        {
            Assert.IsFalse (BalancedBrackets.HasBalancedBrackets("[String"));
        }

        [TestMethod]
        public void GivenTwinDoubleBrackets_ReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

    }
}
