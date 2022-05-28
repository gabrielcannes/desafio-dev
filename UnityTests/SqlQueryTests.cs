using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desafio_devcsharp;
using System;
using System.Data;

namespace UnityTests
{
    [TestClass]
    public class SqlQueryTests
    {
        sqlQueryes queryesClass = new sqlQueryes();
        TransactionInfo transactionClass = new TransactionInfo();

        [TestMethod]
        public void CanSelectTransactions_DataIsOk_ReturnTrue()
        {
            //Arrenge;
            DataTable testDt = new DataTable();

            //Act
            testDt = queryesClass.selectAllFromTransactionsOrderByCPF();

            //Assert
            Assert.IsNotNull(testDt);
        }

        [TestMethod]
        public void CanSelectBalance_DataIsOk_ReturnTrue()
        {
            //Arrenge;
            DataTable testDt = new DataTable();

            //Act
            testDt = queryesClass.selectCurrentBalanceBasedOnTransactions();

            //Assert
            Assert.IsNotNull(testDt);
        }

        [TestMethod]
        public void CanInsertIntoTransactions_DataIsOk_ReturnTrue()
        {
            //Arrange
            transactionClass.type = "Financiamento";
            transactionClass.date = "20190301";
            transactionClass.value = "132.0000";
            transactionClass.cpf = "09620676017";
            transactionClass.card = "4753****3153";
            transactionClass.time = "153453";
            transactionClass.storeOwner = "JOÃO MACEDO   ";
            transactionClass.storeName = "BAR DO JOÃO       ";

            //Act
            try
            {
                queryesClass.InsertCnabIntoDataBase(transactionClass);
            //Assert
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CannotInsertIntoTransactions_DataIsNotOk_ReturnFalse()
        {
            //Arrange
            transactionClass.type = "Financiamento";
            transactionClass.date = "20190301";
            transactionClass.value = "132.0000";
            transactionClass.cpf = "0962067601731231233123123";
            transactionClass.card = "4753****3153";
            transactionClass.time = "153453";
            transactionClass.storeOwner = "JOÃO MACEDO   ";
            transactionClass.storeName = "BAR DO JOÃO       ";

            //Act
            try
            {
                queryesClass.InsertCnabIntoDataBase(transactionClass);
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
