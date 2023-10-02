namespace DrawShapes;
class Diamond : Shape
{
    public Diamond(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
    }
    
    public override void drawShape()
    {
        var middle = (this.Size + 1) / 2;
        //Draw a diamond
        //Prints out row by row each part of the diamond
        for (int i = 1; i <= this.Size; i++)
        {
            if (i <= middle)
            {
                for (int j = 1; j <= this.Size; j++)
                {
                    if (
                        j > (middle - i) //is position within left most boundary
                        && j < (middle + i) //is position within the right most boundary
                        && (((middle % 2 == 0) && ((j % 2) != (i % 2))) || ((middle % 2 != 0) && ((j % 2) == (i % 2)))))
                    //((is middle even) and ((position is odd and line is even) or (position is even and line is odd))) or ((is middle odd) and (position is even and line is even) or (position is odd and line is odd))
                    {
                        Console.Write(this.DrawChar); //print X
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
                        j >= (i - middle + 1) //is position within left most boundary
                        && j <= (this.Size + middle - i) //is position within the right most boundary
                        && (((middle % 2 == 0) && ((j % 2) != (i % 2))) || ((middle % 2 != 0) && ((j % 2) == (i % 2))))
                        //((is middle even) and ((position is odd and line is even) or (position is even and line is odd))) or ((is middle odd) and (position is even and line is even) or (position is odd and line is odd))
                        )
                    {
                        Console.Write(this.DrawChar); //print X
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