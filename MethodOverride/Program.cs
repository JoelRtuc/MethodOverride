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
            Console.WriteLine("Enter your height!");
            string input = Console.ReadLine();

            if (int.TryParse(input, out heightInt))
            {
                heightIsInt = true;
            }
            else if (double.TryParse(input, out heightDoub))
            {
                heightIsInt = false;
            }
            else
            {
                Main(args);
                return;
            }

            Console.WriteLine("Enter your weight!");
            string input1 = Console.ReadLine();

            if (int.TryParse(input1, out weightInt))
            {
                weightIsInt = true;
            }
            else if (double.TryParse(input1, out weightDoub))
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
                WeightHeight(heightInt, weightDoub);
            }
            else
            {
                WeightHeight(weightDoub, weightDoub);
            }

        }
        static void WeightHeight(int height, int weight)
        {
            Console.WriteLine("You are " + height + " tall and weigh " + weight);
        }

        static void WeightHeight(double height, int weight)
        {
            Console.WriteLine("You are " + height + " tall and weigh " + weight);
        }

        static void WeightHeight(int height, double weight)
        {
            Console.WriteLine("You are " + height + " tall and weigh " + weight);
        }

        static void WeightHeight(double height, double weight)
        {
            Console.WriteLine("You are " + height + " tall and weigh " + weight);
        }
    }
}
