using System;
using System.Collections.Generic;
using System.Text;

namespace _13._05.pr
{
    public class lib1
    {
        static public string stpow(string a, int b)
        {
            string ag = "";
            for(int i = 0; i < b; i++)
            {
                ag = ag + a;
            }
            a = ag;
            return a;
        }
        static public string rev(string a)
        {
            string ag = "";
            for(int i = a.Length - 1; i >= 0; i--)
            {
                ag = ag + a[i];
            }
            a = ag;
            return a;
        }
        static public string remov(string a, string b)
        {
            a = a.Replace(b, "");
            return a;
        }
        static public int leng(string a)
        {

            return a.Length;
        }
    }
}
