namespace DrawShapes;
class Triangle : Shape
{
    public Triangle(int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
    }
    public override void drawShape()
    {
        //Draw a triangle
        //Prints out row by row each part of the triangle
        for (int i = 0; i < this.Size; i++)
        {
            //Prints the rows that don't contain the embedded text
            for (int j = 1; j < (this.Size * 2); j++)
            {
                if (
                    j >= this.Size - i
                    && j <= this.Size + i
                    && (((this.Size % 2 == 0) && ((j % 2) == (i % 2))) || ((this.Size % 2 != 0) && ((j % 2) != (i % 2))))
                    )
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