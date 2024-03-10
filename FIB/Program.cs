using System;

class Program
{
    static bool Verificando(int numero)
    {
        int a = 0, b = 1;

        while (a <= numero)
        {
            if (a == numero)
                return true;

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }

    static void Main()
    {
        Console.Write("Informe um número: ");
        int numeroInformado = Convert.ToInt32(Console.ReadLine());

        if (Verificando(numeroInformado))
            Console.WriteLine($"O número {numeroInformado} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numeroInformado} não pertence à sequência de Fibonacci.");
    }
}
