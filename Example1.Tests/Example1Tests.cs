using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Example1.Tests
{
    //перед классом всегда надо ставить [TestClass]
    [TestClass]
    public class Example1Tests
    {
        //перед методом всегда надо ставить [TestMethod]
        [TestMethod]
        // тест на передачу числа -5, ответ должен быть не принадлежит
        public void CheckNumberX_EnterMinus6_AnswerDoNotBelong()
        {
            // данные для передачи
            double x = -6;
            // ожидаемый ответ
            string excpected = "не принадлежит";
            // фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка
            // если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        // тест на передачу числа -5, ответ должен быть принадлежит
        public void CheckNumberX_EnterMinus5_AnswerBelong()
        {
            // данные для передачи
            double x = -5;
            // ожидаемый ответ
            string excpected = "принадлежит";
            // фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        // тест на передачу числа 2, ответ должен быть принадлежит
        public void CheckNumberX_Enter2_AnswerDoNotBelong()
        {
            // данные для передачи
            double x = 2;
            // ожидаемый ответ
            string excpected = "не принадлежит";
            // фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }
    }
}