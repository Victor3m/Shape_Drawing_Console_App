namespace DrawShapes;

class InputCheck
{
    private bool isStringEmpty(string input)
    {
        return input == "";
    }
    private bool doesStringMatch(string input, string[] validInputs)
    {
        foreach (string validInput in validInputs)
        {
            if (input == validInput)
            {
                return true;
            }
        }
        return false;
    }
    public InputCheck()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the shape drawer!\n");
    }
    
    //This method checks if the input is an even number and returns true or false
    public bool isEven(int value)
    {
        return (value % 2 == 0);
    }

    //This method checks if the input is an even number and returns it as an int
    public int checkForEven(int value)
    {
        while (isEven(value))
        {
            Console.WriteLine("Height must be an odd number due to how this shape is drawn.\nPlease try again with an odd number. ");
            value = positiveIntCheck();
        }
        return value;
    }

    //This method checks if the input is a character and returns it as a char
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
        while (isStringEmpty(input) || !int.TryParse(input, out int result) || result < 0)
        {
            Console.WriteLine("Please enter a positive integer. ");
            input = Console.ReadLine();
        }
        return Convert.ToInt32(input);
    }

    //This method checks if the input is a valid shape and returns it as a string
    public string checkShape()
    {
        string input = Console.ReadLine().ToLower();
        string[] validInputs = { "diamond", "triangle", "square", "circle" };
        while (isStringEmpty(input) || !doesStringMatch(input, validInputs))
        {
            Console.WriteLine("Please enter either 'circle', 'diamond', 'triangle', or 'square'. ");
            input = Console.ReadLine();
        }
        return input;
    }

    //This method checks if the user wants to continue drawing shapes
    public bool checkContinue()
    {
        Console.WriteLine("Would you like to draw another shape? (y/n) ");
        string input = Console.ReadLine();
        string[] validInputs = { "y", "n" };
        while (isStringEmpty(input) || !doesStringMatch(input, validInputs))
        {
            Console.Clear();
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