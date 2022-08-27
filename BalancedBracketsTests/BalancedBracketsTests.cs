using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest1()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyFrontBracketReturnsFalse3()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void BracketsWithStringInMiddleReturnsTrue4()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[String]"));
        }

        [TestMethod]
        public void OnlyBackBracketReturnsFalse5()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
    }
}
