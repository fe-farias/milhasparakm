using System;

namespace milhasparakm
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhasdigitada, milhasparakm;

            Console.Write("Entre com a medida (em milhas): ");
            milhasdigitada = Convert.ToDouble(Console.ReadLine());

            milhasparakm = milhasdigitada * 1.609;

            Console.WriteLine($"{milhasparakm} Km");
        }
    }
}
