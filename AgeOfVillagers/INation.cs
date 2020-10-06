using System;
using System.Drawing;

public interface INation
{
    public void drawHouse(Graphics g, int X, int Y);
    public void drawTree(Graphics g, int X, int Y);
    public void drawWaterSource(Graphics g, int X, int Y);
    public void paintTerrain();

    IHouse getHouseType();
    ITree getTreeType();
    IWaterSource getWaterSourceType();

}
