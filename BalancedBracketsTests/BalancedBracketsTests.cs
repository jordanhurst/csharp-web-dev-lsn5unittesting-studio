using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void BracketsWrappingStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[some text goes here]"));
        }

        [TestMethod]
        public void MultipleBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void BracketsMixedWithCharsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("some[text goes ] here"));
        }

        [TestMethod]
        public void SingleOpenBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void ExtraOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]["));
        }

        [TestMethod]
        public void ExtraClosedBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }

        [TestMethod]
        public void BracketsDoNotMisNest()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void SingleCloseBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void MultiplePairWithExtraClosedBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[]]][][[]]]"));
        }

        [TestMethod]
        public void MultipleUnbalancedPairsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[][[[]][]"));
        }
    }
}
