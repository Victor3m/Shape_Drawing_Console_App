namespace DrawShapes;
abstract class Shape
{
    private int size;
    public int Size
    {
        get { return size; }
        set { size = value; }
    }
    public abstract void drawShape();
}