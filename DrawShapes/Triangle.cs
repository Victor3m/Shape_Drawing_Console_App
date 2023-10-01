namespace DrawShapes;
class Triangle : Shape
{
    public Triangle(int size)
    {
        this.Size = size;
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
                if (j >= this.Size - i && j <= this.Size + i && j % 2 == i % 2)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
}