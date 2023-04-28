using System;



class Program
{
    static void Main(string[] args) //The Main of the program
    {
        Console.WriteLine("================================================================================");
        Console.WriteLine("Welcome to the Program");
        Console.WriteLine("================================================================================");



        Data data = new Data(); 
        while (true)
        {
            //The Main Window of the Recipe Program
            Console.WriteLine();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset recipe");
            Console.WriteLine("5. Clear recipe data");
            Console.WriteLine("6. Quit");
            Console.WriteLine("");
            Console.WriteLine("================================================================================");

            string input = Console.ReadLine();
            Console.WriteLine();


            switch (input)
            {
                case "1":
                    data.EnterDetails();
                    break;

                case "2":
                    data.Display();
                    break;

                case "3":
                    Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                    Console.WriteLine("================================================================================");
                    double factor = double.Parse(Console.ReadLine());
                    data.Scale(factor);
                    break;

                case "4":
                    data.Reset();
                    break;

                case "5":
                    data.Clear();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
class Data
{
    private string[] ingredients;
    private double[] quan;
    private string[] units;
    private string[] steps;

    public void Scale(double factor)
    {
        for (int i = 0; i < quan.Length; i++)
        {
            quan[i] *= factor;
        }
    }
    public void EnterDetails()
    {
        Console.WriteLine("================================================================================");
        Console.WriteLine("");
        Console.Write("Enter the number of ingredients: ");
        int numIng = int.Parse(Console.ReadLine());

        ingredients = new string[numIng];
        quan = new double[numIng];
        units = new string[numIng];

        for (int i = 0; i < numIng; i++)
        {
            Console.WriteLine($"Enter details for ingredient #{i + 1}:");
            Console.Write("Name: ");
            ingredients[i] = Console.ReadLine();
            Console.Write("Quantity: ");
            quan[i] = double.Parse(Console.ReadLine());
            Console.Write("Unit of measurement: ");
            units[i] = Console.ReadLine();
        }


        Console.Write("Enter the number of steps: ");
        int numStep = int.Parse(Console.ReadLine());

        steps = new string[numStep];


        for (int i = 0; i < numStep; i++)
        {
            Console.Write($"Enter step #{i + 1}: ");
            steps[i] = Console.ReadLine();
        }
        Console.WriteLine("");
        Console.WriteLine("================================================================================");
    }

    public void Display()
    {
        Console.WriteLine("================================================================================");
        Console.WriteLine("");
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine($"- {quan[i]} {units[i]} of {ingredients[i]}");
        }

        Console.WriteLine("Steps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"- {steps[i]}");
        }
        Console.WriteLine("");
        Console.WriteLine("================================================================================");
    }
   
    public Data()
    {
        ingredients = new string[0];
        quan = new double[0];
        units = new string[0];
        steps = new string[0];
    }
    public void Reset()
    {
        for (int i = 0; i < quan.Length; i++)
        {
            quan[i] /= 2;
        }
    }

    public void Clear()
    {
        ingredients = new string[0];
        quan = new double[0];
        units = new string[0];
        steps = new string[0];
    }
}