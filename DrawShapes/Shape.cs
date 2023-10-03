namespace DrawShapes;
abstract class Shape
{
    private int size;
    private char drawChar = 'X';
    private int middle;
    public int Size
    {
        get { return size; }
        set { size = value; }
    }
    public char DrawChar
    {
        get { return drawChar; }
        set { drawChar = value; }
    }
    public int Middle
    {
        get { return middle; }
        set { middle = value; }
    }
    public abstract void drawShape();
}