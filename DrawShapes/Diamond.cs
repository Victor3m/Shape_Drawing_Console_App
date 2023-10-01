namespace DrawShapes;
class Diamond : Shape
{
    public Diamond(int size)
    {
        this.Size = size;
    }
    public override void drawShape()
    {
        //Draw a diamond
        //Prints out row by row each part of the diamond
        for (int i = 0; i < this.Size; i++)
        {
            //Prints the rows that don't contain the embedded text
            for (int j = 1; j <= this.Size; j++)
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