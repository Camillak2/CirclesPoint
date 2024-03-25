using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CirclesPoint;


namespace CheckInEntryPointInCirleTests
{
    [TestClass]
    public class CheckInEntryPointInCirleTests
    {

        //Тест 1
        //четверть 1 не входит
        [TestMethod]
        public void Check_R1_X1_Y1_returned0()
        {
            // исходные данные
            double r = 1;
            double x = 1;
            double y = 1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 2
        // 2 четверть входит
        [TestMethod]
        public void Check_R2_Xminus1_Y1_returned1()
        {
            // исходные данные
            double r = 2;
            double x = -1;
            double y = 1;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 3
        // 3 четверть не входит
        [TestMethod]
        public void Check_R3_Xminus1_Yminus1_returned0()
        {
            // исходные данные
            double r = 1;
            double x = -1;
            double y = -1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 4
        // 4 четверть входит
        [TestMethod]
        public void Check_R2_X3_Yminus1_returned1()
        {
            // исходные данные
            double r = 2;
            double x = 3;
            double y = -1;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 5
        // 2 четверть не входит из-за х
        [TestMethod]
        public void Check_R1_Xminus3_Y1_returned0()
        {
            // исходные данные
            double r = 1;
            double x = -3;
            double y = 1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 6
        // 2 четверть не входит из-за у
        [TestMethod]
        public void Check_R2_Xminus1_Y7_returned0()
        {
            // исходные данные
            double r = 2;
            double x = -1;
            double y = 7;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 7
        // 2 четверть не входит из-за х и у
        [TestMethod]
        public void Check_R1_X7_Y7_returned0()
        {
            // исходные данные
            double r = 1;
            double x = 7;
            double y = 7;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 8
        // 4 четверть не входит из-за х
        [TestMethod]
        public void Check_R3_X7_Y1_returned0()
        {
            // исходные данные
            double r = 3;
            double x = 7;
            double y = 1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 9
        // 4 четверть не входит из-за у
        [TestMethod]
        public void Check_R1_X1_Yminus4_returned0()
        {
            // исходные данные
            double r = 1;
            double x = 1;
            double y = -4;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 10
        // 4 четверть не входит из-за х и у
        [TestMethod]
        public void Check_R2_X6_Yminus3_returned0()
        {
            // исходные данные
            double r = 2;
            double x = 6;
            double y = -3;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 11
        // 2 четверть входит (граница)
        [TestMethod]
        public void Check_R1_X0_Y1_returned1()
        {
            // исходные данные
            double r = 1;
            double x = 0;
            double y = 1;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 12
        // 2 четверть входит (граница)
        [TestMethod]
        public void Check_R1_Xminus1_Y0_returned1()
        {
            // исходные данные
            double r = 1;
            double x = -1;
            double y = 0;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 13
        // 4 четверть входит (граница)
        [TestMethod]
        public void Check_R2_X4_Y0_returned1()
        {
            // исходные данные
            double r = 2;
            double x = 4;
            double y = 0;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 14
        // 4 четверть входит (граница)
        [TestMethod]
        public void Check_R3_X6_Yminus3_returned1()
        {
            // исходные данные
            double r = 3;
            double x = 6;
            double y = -3;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 15
        // 4 четверть входит (граница)
        [TestMethod]
        public void Check_R2_X0_Yminus2_returned1()
        {
            // исходные данные
            double r = 2;
            double x = 0;
            double y = -2;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 16
        // 2 четверть не входит
        [TestMethod]
        public void Check_R4_Xminus2_Y0point2_returned0()
        {
            // исходные данные
            double r = 4;
            double x = -1;
            double y = 0.1;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 17
        // 4 четверть входит
        [TestMethod]
        public void Check_R4_X0_Y0_returned1()
        {
            // исходные данные
            double r = 4;
            double x = 0;
            double y = 0;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        //Тест 18
        // провал теста 1 четверть входит
        [TestMethod]
        public void Check_R5_X4_Y5point3_1returned()
        {
            // исходные данные
            double r = 5;
            double x = 4;
            double y = 5.3;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new Circle(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }
    }
}
