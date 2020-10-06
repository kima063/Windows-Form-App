using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class NationAbstract
{
    protected Graphics g;
    protected Panel panel; 
    protected Color color;
    protected ITree tree;
    protected IHouse house;
    protected IWaterSource waterSource;
    public NationAbstract(Graphics newg , Panel panel)
    {
        g = newg;
        this.panel = panel;
    }
	public void drawTree(int X, int Y)
    {
        tree.drawTree(g, X, Y);
    }
    public void drawHouse(int X , int Y)
    {
        house.drawHouse(g, X, Y);

    }

    public void drawWaterSource(int X , int Y)
    {
        waterSource.drawWaterSource(g, X, Y);

    }
    public void paintTerrain()
    {
        panel.BackColor = color;
    }

    public IHouse getHouseType()
    {
        return this.house;
    }
    public ITree getTreeType()
    {
        return this.tree;
    }
    public IWaterSource getWaterSourceType()
    {
        return this.waterSource;
    }

    public Color getBackColor()
    {
        return this.panel.BackColor;
    }
}
