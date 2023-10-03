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
                    if (j % 2 == 0)  //Will print if the position is even starting from 0
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
}