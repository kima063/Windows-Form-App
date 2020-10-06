using System;
using System.Drawing;

public class BangladeshiFarmersTree : ITree
{
    Pen p = new Pen(Color.White);
    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X - 11, Y - 23, 10, 14, 0, 360);

        g.DrawLine(p, X - 4, Y , X - 4, Y - 10);
        g.DrawLine(p, X - 8, Y , X - 8, Y - 10);
        g.DrawLine(p, X - 4, Y , X - 8, Y);
    }
}
