namespace DrawShapes;
abstract class Shape
{
    private int size;
    private char drawChar = 'X';
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
    public abstract void drawShape();
}