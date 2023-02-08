using System;

namespace TPFinal_LopezCardena
{
  class Program
  {
    static void Main(string[] args)
    {
      // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero
      // A partir de dichos datos informar:
      // a. El mayor de los números pares.
      // b. La cantidad de números impares.
      // c. El menor de los números primos.
      // Nota: evaluar el uso de una función que analice si un número dado es primo o no y 
      // Que devuelva true o false según corresponda.

      int n, conPrimo = 0, min = 0;
      int conPar = 0, max = 0;
      int conImpar = 0;

      Console.WriteLine("Ingrese un 1 para empezar con el programa y un 0 para terminar con el mismo");
      n = int.Parse(Console.ReadLine());

      while (n != 0)
      {
        Console.WriteLine("Ingrese un numero");
        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
          //punto A
          conPar++;
          if (conPar == 1)
            max = n;
          else if (n > max)
            max = n;
        }
        //punto B
        else
        {
          conImpar++;
        }
        //punto C
        if (primo(n))
        {
          conPrimo++;
          if (conPrimo == 1)
            min = n;
          else if (n < min)
            min = n;
        }

      }
      // punto A
      Console.WriteLine("El mayor de los numeros pares es: " + max);

      // punto B
      Console.WriteLine("La cantidad de numeros impares es: " + conImpar);

      //punto C
      Console.WriteLine("El menor de los numeros primos es: " + min);

    }
    static bool primo(int a)
    {
      int con = 0;
      for (int x = 1; x <= a; x++)
      {
        if (a % x == 0)
          con++;
      }
      if (con == 2)
        return true;
      else
        return false;
    }

  }
}
