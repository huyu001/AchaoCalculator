using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace huyu001Tests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("第一个数：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入运算符（+—*/）");
            // c=Console.ReadLine();
            char str = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("第er个数：");
            int b = Int32.Parse(Console.ReadLine());
            //int c = a + b;
            //Console.WriteLine("两个数和为：{0}",c);
            switch (str)
            {
                case '+':
                    Console.WriteLine("两个数和为：{0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("两个数差为：{0}", a - b);
                    break;
                case '*':
                    Console.WriteLine("两个数积为：{0}", a * b);
                    break;
                case '/':
                    Console.WriteLine("两个数商为：{0}", a / b);
                    break;

                default:
                    Console.WriteLine("输入正确的运算符！！");
                    break;
            }
            Console.ReadKey();
        }
    }
}
