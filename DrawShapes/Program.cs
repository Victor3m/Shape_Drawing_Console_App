namespace DrawShapes;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the shape drawer!\n");

        // Your code goes here
        while (shapeHandler()) { }

    }

    //This method handles the shape selection and drawing
    static bool shapeHandler()
    {
        InputCheck inputCheck = new();

        Console.WriteLine("What shape would you like to print?");
        string shapeType = inputCheck.checkShape();
        Console.WriteLine("\nWhat character would you like to use to draw the shape (Leave blank for default \'X\')?");
        char drawChar = inputCheck.checkChar();
        Console.WriteLine("\nHow tall should the shape be?");
        int height = inputCheck.positiveIntCheck();

        switch (shapeType)
        {
            case "diamond":
                while (height % 2 == 0)
                {
                    Console.WriteLine("Height must be an odd number due to the shape of the diamond.\nPlease try again with an odd number. ");
                    height = inputCheck.positiveIntCheck();
                }
                Diamond diamond = new(height, drawChar);
                diamond.drawShape();
                break;
            case "triangle":
                Triangle triangle = new(height, drawChar);
                triangle.drawShape();
                break;
            case "square":
                Square square = new(height, drawChar);
                square.drawShape();
                break;
        }

        return inputCheck.checkContinue();
    }
}