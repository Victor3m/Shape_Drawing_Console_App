using System.Security.Cryptography.X509Certificates;

namespace DrawShapes;

class Circle : Shape
{
    private int calculateRadius(int pos, int row)
    {
        //Pythagorean Theorem Calculates the radius at the current position
        return (int)Math.Sqrt(Math.Pow(pos, 2) + Math.Pow(row, 2));
    }
    public Circle (int size, char drawChar)
    {
        this.Size = size;
        this.DrawChar = drawChar;
        this.Middle = this.Size - 1;
    }
    public override void drawShape()
    {        
        for (int row = this.Middle; row >= -this.Middle; row-=2) //Start at the Top of the circle and work down
        {
            for (int pos =-this.Middle; pos <= this.Middle; pos++) //Start at the left of the circle and work right
            {
                if (calculateRadius(pos, row) <= this.Middle && 
                    isPositionSameAsLine(Math.Abs(row), Math.Abs(pos)) 
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
    protected override int leftBound(int row)
    {
        throw new NotImplementedException();
    }
    protected override int rightBound(int pos)
    {
        throw new NotImplementedException();
    }
}