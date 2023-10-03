namespace DrawShapes;
class Diamond : Shape
{
    public Diamond(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
        this.Middle = (this.Size + 1) / 2;
    }
    private bool isTopInLeftAndRightBound(int i, int j)
    {
        //Is position in the top of the diamond within left and right most boundarys
        return ((j > (Middle - i)) && (j < (Middle + i)));
    }
    private bool isBotInLeftAndRightBound(int i, int j)
    {
        //Is position in the bottom of the diamond within left and right most boundarys
        return ((j >= (i - Middle + 1)) && (j <= (this.Size + Middle - i)));
    }
    private bool isMiddleEven(int i, int j)
    {
        return ((Middle % 2 == 0)); //Is the middle number an even or odd number
    }
    private bool isPositionSameAsLine(int i, int j)
    {
        return ((j % 2) == (i % 2)); //Are the position and line either even or odd at the same time
    }
    public override void drawShape()
    {
        //Draw a diamond
        //Prints out row by row each part of the diamond
        for (int i = 1; i <= this.Size; i++)
        {
            if (i <= Middle)
            {
                for (int j = 1; j <= this.Size; j++)
                {
                    if (
                        isTopInLeftAndRightBound(i, j) &&
                        ((isMiddleEven(i, j) && !isPositionSameAsLine(i, j)) ||
                        (!isMiddleEven(i, j) && isPositionSameAsLine(i, j)))
                    )
                    {
                        Console.Write(this.DrawChar); //print character
                    }
                    else
                    {
                        Console.Write(" "); //print space
                    }
                }
            }
            else
            {
                for (int j = 1; j <= this.Size; j++)
                {
                    if (
                        isBotInLeftAndRightBound(i, j) &&
                        ((isMiddleEven(i, j) && !isPositionSameAsLine(i, j)) ||
                        (!isMiddleEven(i, j) && isPositionSameAsLine(i, j)))
                    )
                    {
                        Console.Write(this.DrawChar); //print character
                    }
                    else
                    {
                        Console.Write(" "); //print space
                    }
                }
            }
            //Continue to next line to draw
            Console.Write("\n");
        }
    }
}