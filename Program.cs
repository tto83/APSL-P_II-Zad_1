using System;

namespace Zadanie_1
{
  class Trojat
  {
    double a, b, c, p;
    public double b1
    {
      get { return a; }
      set
      {
        if (value < 0) //zerujemy jeśli użytkowanik poda wartość ujemną
        {
          a = 0;
        }
        else
        {
          a = value;
        }
      }
    }

    public double b2
    {
      get { return b; }
      set
      {
        if (value < 0) //zerujemy jeśli użytkowanik poda wartość ujemną
        {
          b = 0;
        }
        else
        {
          b = value;
        }
      }
    }

    public double b3
    {
      get { return c; }
      set
      {
        if (value < 0) //zerujemy jeśli użytkowanik poda wartość ujemną
        {
          c = 0;
        }
        else
        {
          c = value;
        }
      }
    }

    public double Pole()
    {
      if (Math.Max(Math.Max(a, b), c) < a + b + c - (Math.Max(Math.Max(a, b), c))) //sprawdzenie warunku koniecznego istnienia trójkąta
      {
        p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
      }
      else //jeśli warunek nie jest spełniony zerujemy pole
      {
        return 0;
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      double pole = 0;
      int i = 0;
      string taknie = "T";
      Trojat pTr = new Trojat();

      while (taknie.ToUpper() == "T")
      {
        Console.Write("\nPodaj bok a :");
        double bokA = Convert.ToDouble(Console.ReadLine());
        pTr.b1 = bokA;
        Console.Write("Podaj bok b :");
        double bokB = Convert.ToDouble(Console.ReadLine());
        pTr.b2 = bokB;
        Console.Write("Podaj bok c :");
        double bokC = Convert.ToDouble(Console.ReadLine());
        pTr.b3 = bokC;
        Console.WriteLine("Pole trójkąta: {0:0.####}", pTr.Pole());
        Console.Write("\nCzy obliczać pole następnego trójkąta? (T/N): ");
        taknie = Console.ReadLine();
        if (pTr.Pole() != 0) //program policzy do średniej tylko poprawne trójkąty 
        {
          i++;
          pole = pole + pTr.Pole();
        }
      }
      Console.WriteLine("\nŚrednie pole wprowadzonych trójkątów to: {0:0.####}", pole / i);
    }
  }
}