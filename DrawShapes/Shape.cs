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
    protected bool isInLeftAndRightBound(int row, int pos)
    {
        //Is the position within left and right most boundarys
        return ((pos > leftBound(row)) && (pos < rightBound(row)));
    }
    protected bool isMiddleEven()
    {
        return (Middle % 2 == 0); //Is the middle position number even
    }
    protected bool isSizeEven()
    {
        return (this.Size % 2 == 0); //Is the size of the shape even
    }
    protected bool isPositionSameAsLine(int row, int pos)
    {
        return ((pos % 2) == (row % 2)); //Are the position and line either even or odd at the same time
    }
    protected abstract int leftBound( int row );
    protected abstract int rightBound( int row );
}