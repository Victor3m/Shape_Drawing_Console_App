namespace DrawShapes;

class InputCheck
{
    public InputCheck()
    {

    }

    public char checkChar()
    {
        string input = Console.ReadLine();
        while (input.Length > 1)
        {
            Console.WriteLine("Please enter a character. ");
            input = Console.ReadLine();
        }
        if (input == "")
        {
            return 'X';
        }
        return Convert.ToChar(input);
    }

    //This method checks if the input is a positive integer and returns it as an int
    public int positiveIntCheck()
    {
        string input = Console.ReadLine();
        while (input == "" || !int.TryParse(input, out int result) || result < 0)
        {
            Console.WriteLine("Please enter a positive integer. ");
            input = Console.ReadLine();
        }
        return Convert.ToInt32(input);
    }

    //This method checks if the input is a valid shape and returns it as a string
    public string checkShape()
    {
        string input = Console.ReadLine();
        while (input == "" || (input != "diamond" && input != "triangle" && input != "square"))
        {
            Console.WriteLine("Please enter either 'diamond', 'triangle', or 'square'. ");
            input = Console.ReadLine();
        }
        return input;
    }

    //This method checks if the user wants to continue drawing shapes
    public bool checkContinue()
    {
        Console.WriteLine("Would you like to draw another shape? (y/n) ");
        string input = Console.ReadLine();
        while (input == "" || (input != "y" && input != "n"))
        {
            Console.WriteLine("Please enter either 'y' or 'n'. ");
            input = Console.ReadLine();
        }
        if (input == "y")
        {
            Console.Clear();
            return true;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            return false;
        }
    }

}