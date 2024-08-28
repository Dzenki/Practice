using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            Class1 expected_result = new Class1(5, 6);

            // действие
            Class1 result = test_1a + test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            Class1 expected_result = new Class1(-1, 6);

            // действие
            Class1 result = test_1a - test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            Class1 expected_result = new Class1(1, 6);

            // действие
            Class1 result = test_1a * test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            Class1 expected_result = new Class1(2, 3);

            // действие
            Class1 result = test_1a / test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            Class1 expected_result = new Class1(-2, 3);

            // действие
            Class1 result = -(test_1a / test_1b);
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod6()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            bool expected_result = false;

            // действие
            bool result = test_1a > test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod7()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            bool expected_result = true;

            // действие
            bool result = test_1a < test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod8()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            bool expected_result = false;

            // действие
            bool result = test_1a >= test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod9()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            bool expected_result = true;

            // действие
            bool result = test_1a <= test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod10()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            bool expected_result = false;

            // действие
            bool result = test_1a == test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }

        [TestMethod]
        public void TestMethod11()
        {
            // размещение
            int num_1 = 1;
            int dem_1 = 3;
            int num_2 = 1;
            int dem_2 = 2;
            Class1 test_1a = new Class1(num_1, dem_1);
            Class1 test_1b = new Class1(num_2, dem_2);
            bool expected_result = true;

            // действие
            bool result = test_1a != test_1b;
            // утверждение
            Assert.AreEqual(expected_result.ToString(), result.ToString());
        }
    }


    internal class Class1
    {
        int numerator; // числитель
        int denominator; // знаменатель

        public int Numerator
        {
            get { return numerator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public void Criteria()
        {
            int maxi = 1;
            for (int i = 1; i <= numerator; i++)
            {
                if (numerator < 0) // работа с отрицательными числами
                {
                    numerator *= -1;
                    denominator *= -1;
                }

                if (numerator % i == 0 && denominator % i == 0) // сокращение дроби
                {
                    maxi = i;
                }
                numerator = numerator / maxi;
                denominator = denominator / maxi;
                if (denominator < 0) // работа с отрицательными числами
                {
                    numerator *= -1;
                    denominator *= -1;
                }
            }
        }
        public override string ToString() //переопределение object.ToString()
        {
            if (denominator == 0)
            {
                return "Division by a constant equal to zero";
            }
            if (numerator % denominator == 0)
            {
                int a = numerator / denominator;
                return a.ToString();
            }
            else
            {
                Criteria();
                return Numerator.ToString() + "/" + Denominator.ToString();
            }
        }

        public Class1(int numerator, int denominator) // конструктор с двумя целочисленными параметрами
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Class1 operator +(Class1 a, Class1 b)
        {
            if ((a.denominator == 0) || (b.denominator == 0))
            {
                Console.WriteLine("Error: Division by a constant equal to zero. Variable changed to 1/1");
                return new Class1(1, 1);
            }
            int numerator_ONE, numerator_TWO, denominator_NEW;
            numerator_ONE = a.numerator * b.denominator;
            numerator_TWO = b.numerator * a.denominator;
            denominator_NEW = a.denominator * b.denominator;
            return new Class1(numerator_ONE + numerator_TWO, denominator_NEW);
        }
        public static Class1 operator -(Class1 a, Class1 b)
        {
            if ((a.denominator == 0) || (b.denominator == 0))
            {
                Console.WriteLine("Error: Division by a constant equal to zero. Variable changed to 1/1");
                return new Class1(1, 1);
            }
            int numerator_ONE, numerator_TWO, denominator_NEW;
            numerator_ONE = a.numerator * b.denominator;
            numerator_TWO = b.numerator * a.denominator;
            denominator_NEW = a.denominator * b.denominator;
            return new Class1(numerator_ONE - numerator_TWO, denominator_NEW);
        }
        public static Class1 operator *(Class1 a, Class1 b)
        {
            if ((a.denominator == 0) || (b.denominator == 0))
            {
                Console.WriteLine("Error: Division by a constant equal to zero. Variable changed to 1/1");
                return new Class1(1, 1);
            }
            int numerator_NEW, denominator_NEW;
            numerator_NEW = a.numerator * b.numerator;
            denominator_NEW = a.denominator * b.denominator;
            return new Class1(numerator_NEW, denominator_NEW);
        }
        public static Class1 operator /(Class1 a, Class1 b)
        {
            if ((a.denominator == 0) || (b.denominator == 0))
            {
                Console.WriteLine("Error: Division by a constant equal to zero. Variable changed to 1/1");
                return new Class1(1, 1);
            }
            int numerator_NEW, denominator_NEW;
            numerator_NEW = a.numerator * b.denominator;
            denominator_NEW = a.denominator * b.numerator;
            return new Class1(numerator_NEW, denominator_NEW);
        }
        public static Class1 operator -(Class1 a)
        {
            int numerator_NEW, denominator_NEW;
            numerator_NEW = a.numerator * -1;
            denominator_NEW = a.denominator;
            return new Class1(numerator_NEW, denominator_NEW);
        }
        public static bool operator ==(Class1 a, Class1 b)
        {
            if (a.numerator == b.numerator && a.denominator == b.denominator) { return true; }
            else { return false; }
        }
        public static bool operator !=(Class1 a, Class1 b)
        {
            if (a.numerator == b.numerator && a.denominator == b.denominator) { return false; }
            else { return true; }
        }
        public static bool operator <(Class1 a, Class1 b)
        {
            if (a.denominator != b.denominator)
            {
                int numerator_ONE, numerator_TWO, denominator_NEW;
                numerator_ONE = a.numerator * b.denominator;
                numerator_TWO = b.numerator * a.denominator;
                denominator_NEW = a.denominator * b.denominator;

                if (numerator_ONE < numerator_TWO) { return true; }
                else { return false; }
            }
            else
            {
                if (a.numerator < b.numerator) { return true; }
                else { return false; }
            }
        }
        public static bool operator >(Class1 a, Class1 b)
        {
            if (a.denominator != b.denominator)
            {
                int numerator_ONE, numerator_TWO, denominator_NEW;
                numerator_ONE = a.numerator * b.denominator;
                numerator_TWO = b.numerator * a.denominator;
                denominator_NEW = a.denominator * b.denominator;

                if (numerator_ONE > numerator_TWO) { return true; }
                else { return false; }
            }
            else
            {
                if (a.numerator > b.numerator) { return true; }
                else { return false; }
            }
        }
        public static bool operator <=(Class1 a, Class1 b)
        {
            if (a.denominator != b.denominator)
            {
                int numerator_ONE, numerator_TWO, denominator_NEW;
                numerator_ONE = a.numerator * b.denominator;
                numerator_TWO = b.numerator * a.denominator;
                denominator_NEW = a.denominator * b.denominator;

                if (numerator_ONE <= numerator_TWO) { return true; }
                else { return false; }
            }
            else
            {
                if (a.numerator <= b.numerator) { return true; }
                else { return false; }
            }
        }
        public static bool operator >=(Class1 a, Class1 b)
        {
            if (a.denominator != b.denominator)
            {
                int numerator_ONE, numerator_TWO, denominator_NEW;
                numerator_ONE = a.numerator * b.denominator;
                numerator_TWO = b.numerator * a.denominator;
                denominator_NEW = a.denominator * b.denominator;

                if (numerator_ONE >= numerator_TWO) { return true; }
                else { return false; }
            }
            else
            {
                if (a.numerator >= b.numerator) { return true; }
                else { return false; }
            }
        }
    }
}
