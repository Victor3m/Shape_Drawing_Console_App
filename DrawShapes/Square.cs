namespace DrawShapes;
class Square : Shape
{
    public Square(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
    }
    protected override int leftBound(int row)
    {
        return 0;
    }
    protected override int rightBound(int row)
    {
        return (this.Size * 2 - 1);
    }
    public override void drawShape()
    {
        //Draw a square
        //Prints out row by row each part of the square
        for (int row = 0; row < this.Size; row++)
        {
            //Prints the rows that don't contain the embedded text
            for (int pos = 0; pos < this.rightBound(row); pos++)
            {
                if (pos % 2 == 0)  //Will print if the position is even starting from 0
                {
                    Console.Write(this.DrawChar); //print chracter
                }
                else //Will skip and add a space character if the position is odd
                {
                    Console.Write(" "); //print space
                }
            }
            //Continue to next line to draw
            Console.Write("\n");
        }
    }

    protected override bool isPrintOnEvenOrOddPosition(int row, int pos)
    {
        throw new System.NotImplementedException();
    }
}