using System;
using System.Drawing;

public class BangladeshiFarmersWaterSource : IWaterSource
{
    Pen p = new Pen(Color.White);
    public void drawWaterSource(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X, Y + 4, X + 4, Y);
        g.DrawLine(p, X + 4, Y, X + 9, Y + 4);
        g.DrawLine(p, X + 9, Y + 4, X + 24, Y );
        g.DrawLine(p, X + 24, Y , X + 20, Y + 12);
        g.DrawLine(p, X + 20, Y + 12, X + 15, Y + 16);
        g.DrawLine(p, X + 15, Y + 16, X + 6, Y + 10);
        g.DrawLine(p, X + 6, Y + 10, X + 7, Y + 14);
        g.DrawLine(p, X + 7, Y + 14, X + 5, Y + 13);
        g.DrawLine(p, X + 5, Y + 13 , X , Y + 4);

    }
}
