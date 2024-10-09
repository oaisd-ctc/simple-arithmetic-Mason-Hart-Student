using System;

public class program
{
    public static void Main(string[] args) {
        Console.WriteLine("What operation would you like to do: Addition, subtraction, multiplication, division, modulus?");
        string operation = Console.ReadLine();
        if (operation == "subtraction") {
            Console.WriteLine("Provide one number to use for the subtraction equation.");
            double sub1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Great, now provide a number to subtract from " + sub1);
            double sub2 = double.Parse(Console.ReadLine());
            double difference = sub1 - sub2;
            Console.WriteLine("The answer to your problem of " + sub1 + " - " + sub2 + " = " + difference);
        }
        if (operation == "addition") {
            Console.WriteLine("Provide one number to use for the addition equation.");
            double add1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Great, now provide a number to add to " + add1);
            double add2 = double.Parse(Console.ReadLine());
            double sum = add1 + add2;
            Console.WriteLine("The answer to your problem of " + add1 + " + " + add2 + " = " + sum);
        }
        if (operation == "multiplication") {
            Console.WriteLine("Provide one number to use for the multiplication equation.");
            double multi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Great, now provide a number to mutliply to " + multi1);
            double multi2 = double.Parse(Console.ReadLine());
            double difference = multi1 * multi2;
            Console.WriteLine("The answer to your problem of " + multi1 + " * " + multi2 + " = " + difference);
        }
        if (operation == "division") {
            Console.WriteLine("Provide one number to use for the division equation.");
            double div1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Great, now provide a number to divide " + div1 + " by");
            double div2 = double.Parse(Console.ReadLine());
            double divAns = div1 / div2;
            Console.WriteLine("The answer to your problem of " + div1 + " / " + div2 + " = " + divAns);
        }
        if (operation == "modulus") {
            Console.WriteLine("Provide one number to use for the modulus equation.");
            double mod1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Great, now provide a second number for the equation");
            double mod2 = double.Parse(Console.ReadLine());
            double modAns = mod1 % mod2;
            Console.WriteLine("The answer to your problem of " + mod1 + " % " + mod2 + " = " + modAns);
        }
    }
}