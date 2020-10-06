using System;
using System.Drawing;

public class ArabBedouinHouse : IHouse
{
    Pen p = new Pen(Color.Black);
    public void drawHouse(Graphics g, int X, int Y)
    {

        g.DrawLine(p, X, Y, X + 4, Y - 16);
        g.DrawLine(p, X + 4, Y-16 , X + 8, Y);
        g.DrawLine(p, X, Y, X , Y);
        g.DrawLine(p, X, Y , X + 16 , Y);
        g.DrawLine(p, X + 16, Y, X + 10, Y - 16);
        g.DrawLine(p, X + 10, Y - 16, X + 4, Y - 16);
    }
}
