namespace MethodOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heightInt, weightInt;
            double heightDoub = 0, weightDoub = 0;
            bool heightIsInt, weightIsInt;
            //vissa skriver heltal vissa skriver decimaler jag gör en metod för varje med samma namn
            Console.WriteLine("Enter your weight!");
            if (int.TryParse(Console.ReadLine(), out heightInt))
            {
                heightIsInt = true;
            }
            else if (double.TryParse(Console.ReadLine(), out heightDoub))
            {
                heightIsInt = false;
            }
            else
            {
                Main(args);
                return;
            }

            Console.WriteLine("Enter your height!");
            if (int.TryParse(Console.ReadLine(), out weightInt))
            {
                weightIsInt = true;
            }
            else if (double.TryParse(Console.ReadLine(), out weightDoub))
            {
                weightIsInt = false;
            }
            else
            {
                Main(args);
                return;
            }

            if (heightIsInt && weightIsInt)
            {
                WeightHeight(heightInt, weightInt);
            }
            else if (!heightIsInt && weightIsInt)
            {
                WeightHeight(heightDoub, weightInt);
            }
            else if (heightIsInt && !weightIsInt)
            {
                WeightHeight(weightInt, weightDoub);

            }
            else
            {
                WeightHeight(weightDoub, weightDoub);
            }

        }
        static void WeightHeight(int height, int weight)
        {
            Console.WriteLine(height + weight);
        }

        static void WeightHeight(double height, int weight)
        {
            Console.WriteLine(height + weight);

        }

        static void WeightHeight(int height, double weight)
        {
            Console.WriteLine(height + weight);

        }

        static void WeightHeight(double height, double weight)
        {
            Console.WriteLine(height + weight);

        }
    }
}
