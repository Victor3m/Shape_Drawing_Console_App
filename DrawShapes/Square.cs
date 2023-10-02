namespace DrawShapes;
class Square : Shape
{
    public Square(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
    }
    public override void drawShape()
    {
        //Draw a square
        //Prints out row by row each part of the square
        for (int i = 0; i < this.Size; i++)
        {
            //Prints the rows that don't contain the embedded text
                for (int j = 0; j < (this.Size * 2 - 1); j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(this.DrawChar);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            //Continue to next line to draw
            Console.Write("\n");
        }
    }
}