using System;
using Tennis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisTest {
    [TestClass]
    public class TennisTest {
        [TestMethod]
        public void TestAFirstLessEqual3() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Fifteen Love" );
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Thirty Love" );
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Forty Love" );
        }

        [TestMethod]
        public void TestAFirstLessEqual3BNonZero() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Thirty Fifteen" );
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Forty Fifteen" );
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Forty Thirty" );
        }

        [TestMethod]
        public void TestBFirstLessEqual3() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Love Fifteen" );
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Love Thirty" );
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Love Forty" );
        }

        [TestMethod]
        public void TestBFirstLessEqual3ANonZero() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.BGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Fifteen Thirty" );
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Fifteen Forty" );
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Thirty Forty" );
        }

        [TestMethod]
        public void TestABEqualLessThan3() {
            CTennisScore kTennisScore = new CTennisScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Love all" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Fifteen all" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Thirty all" );
        }

        [TestMethod]
        public void TestABEqualLargerEqualThan3() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Deuce" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Deuce" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Deuce" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "Deuce" );
        }

        [TestMethod]
        public void TestAAdvantage() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "A Advantage" );
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "A Advantage" );
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "A Advantage" );
        }

        [TestMethod]
        public void TestBAdvantage() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "B Advantage" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "B Advantage" );
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "B Advantage" );
        }

        [TestMethod]
        public void TestAWin() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.AGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "A Win" );
        }

        [TestMethod]
        public void TestBWin() {
            CTennisScore kTennisScore = new CTennisScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.AGetScore();
            kTennisScore.BGetScore();
            kTennisScore.BGetScore();
            kTennisScore.BGetScore();
            Assert.AreEqual( kTennisScore.CurrentState(), "B Win" );
        }
    }
}
