namespace DrawShapes;
    class Program
    {
        static void Main(string[] args)
        {
            // Your code goes here
            Shape shape = new Triangle(11);
            Shape shape2 = new Triangle(12);
            shape.drawShape();
            shape2.drawShape();
        }
    }