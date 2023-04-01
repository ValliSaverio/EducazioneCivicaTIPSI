using System;
using System.Reflection;

public class Progetto
{
    private static string alfabeto = "abcdefghijklmnopqrstuvwxyz";
    private static int contatore = 0;

    public static string Es1(string s, int n)
    {
        int index = 0;
        string stringaFinale = "";
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != alfabeto[index])
            {
                index++;
            }
            index += n;
            if (index > 25)
            {
                index -= 25;
            }
            stringaFinale += alfabeto[index];
        }
        return stringaFinale;
    }
}