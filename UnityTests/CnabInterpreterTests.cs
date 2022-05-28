using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desafio_devcsharp;

namespace UnityTests
{
    [TestClass]
    public class CnabInterpreterTests
    {
        private string line;
        private CnabInterpreter cnabInterpreter = new CnabInterpreter();

      [TestMethod]
      public void CanGetAllDataFromValidCNAB_lineIsOk_ReturnTrue()
        {
            //Arrange
            line = "3201903010000014200096206760174753****3153153453JOÃO MACEDO   BAR DO JOÃO       ";
            //Act
            try
            {
                cnabInterpreter.GetCnabData(line);

            //Assert
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
      }
        [TestMethod]
        public void CannotGetDataFromInvalidCNAB_lineIsNotBig_ReturnTrue()
        {
            //Arrange
            line = "3201903010000014200096206760174753****3153153453JOÃO MACEDO   BAR DO JOÃO       3201903010000014200096206760174753****3153153453JOÃO MACEDO   BAR DO JOÃO       ";
            //Act
            try
            {
                cnabInterpreter.GetCnabData(line);

                //Assert
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void CannotGetDataFromInvalidCNAB_lineIsSmall_ReturnTrue()
        {
            //Arrange
            line = "32019030100000142000962067601";
            //Act
            try
            {
                cnabInterpreter.GetCnabData(line);

                //Assert
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void CannotGetDataFromInvalidCNAB_lineIsEmpty_ReturnTrue()
        {
            //Arrange
            line = "";
            //Act
            try
            {
                cnabInterpreter.GetCnabData(line);

                //Assert
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
