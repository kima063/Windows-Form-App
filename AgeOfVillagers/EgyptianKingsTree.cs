using System;
using System.Drawing;

public class EgyptianKingsTree : ITree
{
    Pen p = new Pen(Color.Black);

    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X - 8, Y , X - 2, Y - 24);
        g.DrawLine(p, X - 8, Y , X - 14, Y - 24);
        g.DrawLine(p, X - 4, Y - 10, X , Y- 16);
        g.DrawLine(p, X - 4 , Y -10, X - 6, Y-20);
        g.DrawLine(p, X - 12, Y - 10, X - 16, Y - 14);
        g.DrawLine(p, X - 12, Y - 10, X - 16, Y - 20);
    }
}