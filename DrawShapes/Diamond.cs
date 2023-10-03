using System.Net.Security;

namespace DrawShapes;
class Diamond : Shape
{
    public Diamond(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
        this.Middle = (this.Size + 1) / 2;
    }

    protected override int leftBound(int row)
    {
        return (Middle - row);
    }
    protected override int rightBound(int row)
    {
        return (Middle + row);
    }
    public override void drawShape()
    {
        //Draw a diamond
        //Prints out row by row each part of the diamond
        for (int row = 1; row <= Middle; row++)
        {
            for (int pos = 1; pos <= this.Size; pos++)
            {
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
            Console.Write("\n");
        }
        for (int row = Middle - 1; row >= 0; row--)
        {
            for (int pos = 1; pos <= this.Size; pos++)
            {
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
            Console.Write("\n");
        }
    }
    protected override bool isPrintOnEvenOrOddPosition(int row, int pos)
    {
        return (
            ( isMiddleEven() && !isPositionSameAsLine(row, pos)) ||
            ( !isMiddleEven() && isPositionSameAsLine(row, pos))
        );
    }
}