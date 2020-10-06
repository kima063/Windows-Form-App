using System;
using System.Drawing;

public class InuitHuntersHouse : IHouse
{
    Pen p = new Pen(Color.Black);
    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X, Y, 16 , 16 , 180, 180);
        g.DrawArc(p, X+4, Y+4 , 9, 9, 180, 180);
        g.DrawLine(p, X, Y + 8, X + 16, Y + 8);
    }
}
