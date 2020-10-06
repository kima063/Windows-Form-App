using System;
using System.Drawing;
using System.Windows.Forms;

public class EgyptianKings : NationAbstract
{
   
    public EgyptianKings(Graphics newg , Panel panel) : base(newg , panel)
    {
        base.color = Color.Yellow;
        base.house = new EgyptianKingsHouse();
        base.tree = new EgyptianKingsTree();
        base.waterSource = new EgyptianKingsWaterSource();
        paintTerrain();
    }
}
