using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string[] ett = new string[] { "a" ,"b","b","c","hej"};
        string[] två = new string[] { "hej", "a","a","b","programmering" };
        string[] tre = FinnsIBåda(ett, två);
        for(int i = 0; i < tre.Length; i++)
        {
            Console.Write(tre[i]+" ");
        }
        Console.WriteLine();
    }
    static string[] FinnsIBåda(string[] a, string[] b)
    {
        int gånger = 0;
        string[] resultat = new string[a.Length];
        for (int i = 0; i<a.Length;i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j] && false == resultat.Contains(b[j]))
                {
                    resultat[gånger] = b[j];
                    gånger++;
                }
            }
        }
        return resultat;
    }
}
