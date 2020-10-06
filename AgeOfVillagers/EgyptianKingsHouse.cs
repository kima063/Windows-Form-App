using System;
using System.Drawing;

public class EgyptianKingsHouse : IHouse
{
    Pen p = new Pen(Color.Black);
    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X, Y -2 , X + 9 , Y);
        g.DrawLine(p, X + 9, Y, X + 16, Y - 4);
        g.DrawLine(p, X + 16, Y - 4, X + 7, Y - 16);
        g.DrawLine(p, X + 7, Y - 16, X, Y - 2);
        g.DrawLine(p, X + 7, Y - 16, X + 9, Y);
    }
}
