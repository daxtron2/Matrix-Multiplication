using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int response;
            Console.Write("Press 1 for Matrix * Vector, 2 for Matrix * Matrix: ");
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("\nPlease only enter a number...\nPress any key to exit...");
                Console.ReadKey();
                return;
            }

            switch (response)
            {
                case 1: MultiplyVector();
                    break;
                case 2: MultiplyMatrix();
                    break;
                default: Console.WriteLine("Invalid selection...");
                    return;
            }
        }

        private static void MultiplyMatrix()
        {
            Console.WriteLine("\n| a b |\n| c d |\n");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("d: ");
            int d = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("| {0} {1} | * | e f |\n| {2} {3} |   | g h |", a, b, c, d);

            Console.Write("e: ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("f: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("g: ");
            int g = int.Parse(Console.ReadLine());

            Console.Write("h: ");
            int h = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("| {0} {1} | * | {4} {5} |\n| {2} {3} |   | {6} {7} |", a, b, c, d, e, f, g, h);

            int[] newMatrix = new int[4];
            newMatrix[0] = (a * e) + (b * g);
            newMatrix[1] = (a * f) + (b * h);
            newMatrix[2] = (c * e) + (d * g);
            newMatrix[3] = (c * f) + (d * h);

            Console.Clear();
            Console.WriteLine("Resulting Matrix: ");
            Console.WriteLine("| {0} {1} |\n| {2} {3} |", newMatrix[0], newMatrix[1], newMatrix[2], newMatrix[3]);

        }

        private static void MultiplyVector()
        {
            Console.WriteLine("\n| a b |\n| c d |\n");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("d: ");
            int d = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("| {0} {1} | * | u |\n| {2} {3} |   | v |", a, b, c, d);

            Console.Write("u: ");
            int u = int.Parse(Console.ReadLine());

            Console.Write("v: ");
            int v = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("| {0} {1} | * | {4} |\n| {2} {3} |   | {5} |", a, b, c, d, u, v);

            int[] newVector = new int[2];
            newVector[0] = (a * u) + (b * v);
            newVector[1] = (c * u) + (d * v);
            Console.WriteLine("Resulting vector:");
            Console.WriteLine("| {0} |\n| {1} |", newVector[0], newVector[1]);
        }
    }
}
