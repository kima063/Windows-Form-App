using System;
using System.Drawing;

public class ArabBedouinTree : ITree
{
    Pen p = new Pen(Color.Black);


    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X - 5, Y, X - 5, Y - 14);
        g.DrawLine(p, X - 7, Y, X - 7, Y - 14);
        g.DrawLine(p, X - 5, Y, X - 7, Y);
        g.DrawLine(p, X - 5, Y - 14, X - 7, Y - 14);
        g.DrawLine(p, X - 6, Y - 14, X - 6, Y - 24);
        g.DrawLine(p, X - 6, Y - 14, X  , Y - 17);
        g.DrawLine(p, X - 6, Y - 14, X - 3, Y - 21);
        g.DrawLine(p, X - 6, Y - 14, X - 9, Y - 21);
        g.DrawLine(p, X - 6, Y - 14, X - 15, Y - 17);
    }
}
