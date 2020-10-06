using System;
using System.Drawing;
using System.Windows.Forms;

public class BangladeshiFarmers : NationAbstract
{
    public BangladeshiFarmers(Graphics newg, Panel panel) : base(newg, panel)
    {
        base.color = Color.Green;
        g = newg;
        base.house = new BangladeshiFarmersHouse();
        base.tree = new BangladeshiFarmersTree();
        base.waterSource = new BangladeshiFarmersWaterSource();
        paintTerrain();
    }
}
