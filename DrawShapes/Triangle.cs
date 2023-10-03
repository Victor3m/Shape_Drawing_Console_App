namespace DrawShapes;
class Triangle : Shape
{
   private bool isPrintOnEvenOrOddPosition(int row, int pos)
    {
        return (
            ( isMiddleEven() && isPositionSameAsLine(row, pos)) ||
            ( !isMiddleEven() && isPositionSameAsLine(row, pos))
        );
    }
    public Triangle(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
        this.Middle = (this.Size + 1) / 2;
    }
    protected override int leftBound(int row)
    {
        return (this.Size - row);
    }
    protected override int rightBound(int row)
    {
        return (this.Size + row);
    }
    public override void drawShape()
    {
        //Draw a triangle
        //Prints out row by row each part of the triangle
        for (int row = 1; row <= this.Size; row++)
        {
            //Itterate through each position in the row
            for (int pos = 1; pos <= (this.Size * 2); pos++)
            {
                /* Checks if the position is within the left and right most boundarys
                   and if the position(even or odd) matches the row(even or odd)  */ 
                if (
                    isInLeftAndRightBound(row, pos) && 
                    isPrintOnEvenOrOddPosition(row, pos)
                    )
                {
                    Console.Write(this.DrawChar); //print character
                }
                else
                {
                    Console.Write(" "); //print space
                }
            }
            //Continue to next line to draw
            Console.Write("\n");
        }
    }

 
}