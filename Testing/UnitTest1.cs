using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BulletGame;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GameLogic logic = new GameLogic();
            logic.LoadBullet();
            bool result = logic.FireTheBullet(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            GameLogic logic = new GameLogic();
            logic.LoadBullet();
            logic.SpinChambers();
            int pos = 1;
            bool result = logic.FireTheBullet(pos);
            while (!result)
            {
                pos++;
                result = logic.FireTheBullet(pos);
            }
            Assert.IsTrue(result);
        }
    }
}
