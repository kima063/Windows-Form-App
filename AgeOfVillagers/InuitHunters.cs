using System;
using System.Drawing;
using System.Windows.Forms;

public class InuitHunters : NationAbstract
{
    public InuitHunters(Graphics newg , Panel panel) : base(newg , panel)
    {
        base.color = Color.FloralWhite;
        g = newg;
        base.house = new InuitHuntersHouse();
        base.tree = new NullTree();
        base.waterSource = new NullWaterSource();
        paintTerrain();
    }
 
}
