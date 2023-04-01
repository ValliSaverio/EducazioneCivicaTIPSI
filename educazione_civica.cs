using System;
using System.Reflection;

public class Progetto
{
    private static string Alfabeto = "abcdefghijklmnopqrstuvwxyz";
    private static int contatore = 0;

    public static string Prima_richiesta(string s, int n)
    {
        int index = 0;
        string stringaFinale = "";
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != Alfabeto[index])
            {
                index++;
            }
            index += n;
            if (index > 25)
            {
                index -= 25;
            }
            stringaFinale += Alfabeto[index];
        }
        return stringaFinale;
    }

    public static string Seconda_richiesta(string s, int n)
    {
        int index = 0;
        string stringaFinale = "";
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != Alfabeto[index])
            {
                index++;
            }
            index -= n;
            if (index < 0)
            {
                index += 25;
            }
            stringaFinale += Alfabeto[index];
        }
        return stringaFinale;
    }
    
}