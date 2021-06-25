using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Calc.Test
{
    [TestClass]
    public class UnitTest1
    {
        //--------------------------ТЕСТЫ НА СУММУ--------------------------------
        [TestMethod]
        public void Summa10and10itog20()
        {
            string stroka = "10+10";
            string result = "20";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }
        [TestMethod]
        public void Summa15and15itog30()
        {
            string stroka = "15+15";
            string result = "30";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }
        [TestMethod]
        public void Summa100and100itog250() //Специально не рабочий для проверки
        {
            string stroka = "100+100";
            string result = "250";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        //--------------------------ТЕСТЫ НА УМНОЖЕНИЕ--------------------------------

        [TestMethod]
        public void Umnoj5and5itog25()
        {
            string stroka = "5*5";
            string result = "25";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void Umnoj2and2itog4()
        {
            string stroka = "2*2";
            string result = "4";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void Umnoj10and10itog10000() //Специально не рабочий для проверки
        {
            string stroka = "10*10";
            string result = "10000";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        //--------------------------ТЕСТЫ НА ВЫЧИТАНИЕ--------------------------------

        [TestMethod]
        public void Minus25and5itog20()
        {
            string stroka = "25-5";
            string result = "20";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void Minus100and50itog50()
        {
            string stroka = "100-50";
            string result = "50";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void Minus50and20itog20() //Специально не рабочий для проверки
        {
            string stroka = "50-20";
            string result = "20";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        //--------------------------ТЕСТЫ НА ДЕЛЕНИЕ--------------------------------

        [TestMethod]
        public void Del25and5itog5()
        {
            string stroka = "25/5";
            string result = "5";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void Del100and10itog10()
        {
            string stroka = "100/10";
            string result = "10";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void Del20and5itog5() //Специально не рабочий для проверки
        {
            string stroka = "20/5";
            string result = "5";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        //--------------------------ТЕСТЫ НА ДЕЛЕНИЕ С ОСТАТКОМ--------------------------------

        [TestMethod]
        public void DelOstatok50and2itog0()
        {
            string stroka = "50%2";
            string result = "0";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void DelOstatok7and3itog1()
        {
            string stroka = "7%3";
            string result = "1";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }

        [TestMethod]
        public void DelOstatok12and5itog0() //Специально не рабочий для проверки
        {
            string stroka = "12%5";
            string result = "0";
            string itog = new DataTable().Compute(stroka, null).ToString();
            Assert.AreEqual(result, itog);
        }
    }
}
