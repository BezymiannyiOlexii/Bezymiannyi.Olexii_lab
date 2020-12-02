using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Olexii_lab1
{
    class Test
    {
        [TestCase(new[] { 1, 2, 'a', 'b' }, new[] { 1, 2 })]
        [TestCase(new[] { 1, 2, 'a', 'b', 0, 15 }, new[] { 1, 2, 0, 15 })]
        //[TestCase(new[] { 1, 2, 'a', 'b', "assf", 1, "123", 231 }, new[] { 1, 2, 231 })]

        public void Task_1_test(List<object> input, List<object> output)
        {
            var ans = Task.Task_1(input);
            Assert.AreEqual(output, ans, "Another answer!");

        }

        [TestCase("stress", 't')]
        [TestCase("sTreSS", 'T')]
        public void Task_2_test(string input, Char output)
        {
            var ans = Task.Task_2(input);
            Assert.AreEqual(output, ans, "Another answer!");
        }


        [TestCase(16, 7)]
        [TestCase(942, 6)]
        [TestCase(493193, 2)]
        public void Task_3_test(int input, int output)
        {
            var ans = Task.Task_3(input);
            Assert.AreEqual(output, ans, "Another answer!");
        }


        [TestCase(new[] { 1, 3, 6, 2, 2, 0, 4, 5 }, 5, 4)]
        [TestCase(new[] { 1, 2, 4, 2, 0, 5 }, 6, 3)]
        public void Task_4_test(List<int> input_1, int input_2, int output)
        {
            var ans = Task.Task_4(input_1, input_2);
            Assert.AreEqual(output, ans, "Another answer!");
        }

        [TestCase("Fred: Corwill;Wilfred: Corwill;Barney: Tornbull", "(CORWILL, FRED)(CORWILL, WILFRED)(TORNBULL, BARNEY)")]
        public void Task5_test(string input, string output)
        {
            var ans = Task.Task_5(input);
            Assert.AreEqual(output, ans, "Task 5 have another answer!");
        }

    }
}
