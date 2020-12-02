//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Olexii_lab1
{
    public class Task
    {
        public static List<object> Task_1(List<object> input)                              
        {
            List<object> res = input.FindAll(x => x.GetType() == typeof(System.Int32)).ToList();
            return res;
        }
    


        public static Char Task_2(string str)
        {
            string temp = str.ToLower();
            char result = temp.FirstOrDefault(ch => temp.IndexOf(ch) == temp.LastIndexOf(ch));
            int ind = temp.IndexOf(result);
            return str.ToList()[ind];
        }



        public static int Task_3(int n)
        {
            int sum = 0;
            while (sum >= 10 || sum == 0)
            {
                sum = 0;
                while (n > 0)
                {
                    int m = n % 10;
                    sum += m;
                    n /= 10;
                }
                n = sum;
            }
            return sum;
           
        }

        

        public static int Task_4(List<int> arr, int numb)
        {
            int res = 0;
            for (int i=0; i < arr.Count; i++)
            {
                for (int j=i + 1; j < arr.Count; j++)
                {
                    if ((arr[i] + arr[j]) == numb)
                    {
                        res += 1;
                    }
                }
            }
            return res;
        }

       

        public static string Task_5(string s)
        {
            string[] A = s.ToUpper().Split(';');
            string[] replace_A = new string[A.Length];

            for (int i = 0; i < replace_A.Length; i++)
            {
                string[] temp = A[i].Split(':');
                replace_A[i] = temp[1] + " " + temp[0]; 
            }

            replace_A = replace_A.OrderBy(f => f).ToArray();
            string result = "";

            foreach (var element in replace_A)
            {
                result += "(" + element.Replace(" ", ", ") + ")";
            }
            return result;
        }

    }
}
