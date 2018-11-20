using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Evaluationexpress
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
      
        public void BasicArithmetic()
        {
            var parser = new Mani.Parser.MathParser();
                 Assert.AreEqual(0, parser.Parse("1+ 2 - 3"));
            
        }
        [TestMethod]
        public void AdvancedArithmetic()
        {
            var parser = new  Mani.Parser.MathParser();

            Assert.AreEqual(30, parser.Parse("3(7+3)"));
           
        }


    }
}
