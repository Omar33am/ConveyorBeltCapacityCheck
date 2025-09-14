using System;

class ConveyorBeltCapacityCheck
{
    static bool KanBaere(double totalKg, int motorer) => totalKg <= motorer * 6.0;

    static void Main()
    {
        Console.Write("Antal motorer: ");
        int motorer = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Total vægt i kg: ");
        double vaegt = double.Parse(Console.ReadLine() ?? "0");

        if (KanBaere(vaegt, motorer))
            Console.WriteLine("✔ Transportbåndet kan bære vægten.");
        else
            Console.WriteLine("✘ Transportbåndet kan ikke bære vægten.");
    }
}
