using System;
using System.Drawing;

public class BangladeshiFarmersHouse : IHouse
{
    Pen p = new Pen(Color.White);
    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X, Y, X -16, Y);
        g.DrawLine(p, X - 16, Y, X - 16, Y - 9);
        g.DrawLine(p, X - 16, Y - 9, X , Y - 9);
        g.DrawLine(p, X, Y - 9, X, Y );
        g.DrawLine(p, X - 16, Y - 9, X - 8, Y - 16);
        g.DrawLine(p, X - 8, Y - 16, X, Y - 9);
    }
}
