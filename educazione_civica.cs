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

    public static int Terza_richiesta(string s, int n)
    {
        int index = 0;
        int tot = 0;
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != Alfabeto[index])
            {
                index++;
            }
            tot += index + 1;
        }
        return tot * n;
    }

    public static double Quarta_richiesta(string s, int n)
    {
        int index = 0;
        double tot = 1;
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != Alfabeto[index])
            {
                index++;
            }
            tot *= (index + 1);
        }
        return Math.Ceiling(tot / n);
    }
    public static double Quinta_richiesta(string s, int n)
    {
        contatore++;
        if (n % 2 == 0) { return Terza_richiesta(s, n); }
        else
            return Quarta_richiesta(s, n);

    }
}