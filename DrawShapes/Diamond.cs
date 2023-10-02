namespace DrawShapes;
class Diamond : Shape
{
    public Diamond(int size)
    {
        this.Size = size;
    }
    public override void drawShape()
    {
        var middle = (this.Size + 1) / 2;
        //Draw a diamond
        //Prints out row by row each part of the diamond
        for (int i = 1; i <= this.Size; i++)
        {
            if(i <= middle)
            {
                for (int j = 1; j <= this.Size; j++)
                {
                    if (j > (middle - i) 
                    && j < (middle + i) && (((middle % 2 == 0) && 
                    ((j % 2) != (i % 2)) ) || ((middle % 2 != 0) && ((j % 2) == (i % 2)))))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                } 
            }
            else
            {
                for (int j = 1; j <= this.Size; j++)
                {
                    if (
                        j >= (i - middle + 1) 
                        && j <= (this.Size + middle - i) 
                        && (((middle % 2 == 0) && ((j % 2) != (i % 2)) ) || ((middle % 2 != 0) && ((j % 2) == (i % 2))))
                        )
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

            Console.Write("\n");
        }
    }
}