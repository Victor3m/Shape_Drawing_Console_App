namespace DrawShapes;
class Program
{
    static void Main(string[] args)
    {
        // Runs the shapeHandler method until the user chooses to exit
        while (shapeHandler()) { }
    }

    //This method handles the shape selection and drawing
    static bool shapeHandler()
    {
        InputCheck inputCheck = new();

        Console.WriteLine("What shape would you like to print?\nOptions: 'diamond', 'triangle', 'square', 'circle'");
        string shapeType = inputCheck.checkShape();
        Console.WriteLine("\nWhat character would you like to use to draw the shape (Leave blank for default \'X\')?");
        char drawChar = inputCheck.checkChar();
        Console.WriteLine("\nHow tall should the shape be?");
        int height = inputCheck.positiveIntCheck();

        //Use the input to select the shape to draw
        switch (shapeType)
        {
            case "diamond":           
                Diamond diamond = new(inputCheck.checkForEven(height), drawChar);
                diamond.drawShape();
                break;
            case "triangle":
                Triangle triangle = new(inputCheck.checkForEven(height), drawChar);
                triangle.drawShape();
                break;
            case "square":
                Square square = new(height, drawChar);
                square.drawShape();
                break;
            case "circle":
                Circle circle = new(height, drawChar);
                circle.drawShape();
                break;
        }

        return inputCheck.checkContinue();
    }
}