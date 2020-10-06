using Xunit;
using AgeOfVillagers;
using System.Windows.Forms;
using System.Drawing;


namespace AgeOfVillagers_Test
{

    public class NationElementTest
    {

        [Fact]
        public void TestNationHouse()
        {
            Panel panel = new Panel();
            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsHouse = new EgyptianKings(newg, panel);
            Assert.IsType<EgyptianKingsHouse>(egyptianKingsHouse.getHouseType());
            NationAbstract bangladeshiFarmersHouse = new BangladeshiFarmers(newg, panel);
            Assert.IsType<BangladeshiFarmersHouse>(bangladeshiFarmersHouse.getHouseType());
            NationAbstract arabBedouinHouse = new ArabBedouin(newg, panel);
            Assert.IsType<ArabBedouinHouse>(arabBedouinHouse.getHouseType());
            NationAbstract inuitHuntersHouse = new InuitHunters(newg, panel);
            Assert.IsType<InuitHuntersHouse>(inuitHuntersHouse.getHouseType());

        }

        [Fact]
        public void TestNationTree()
        {
            Panel panel = new Panel();

            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsTree = new EgyptianKings(newg, panel);
            Assert.IsType<EgyptianKingsTree>(egyptianKingsTree.getTreeType());
            NationAbstract bangladeshiFarmerTree = new BangladeshiFarmers(newg, panel);
            Assert.IsType<BangladeshiFarmersTree>(bangladeshiFarmerTree.getTreeType());
            NationAbstract arabBedouinTree = new ArabBedouin(newg, panel);
            Assert.IsType<ArabBedouinTree>(arabBedouinTree.getTreeType());
            NationAbstract inuitHuntersTree = new InuitHunters(newg, panel);
            Assert.IsType<NullTree>(inuitHuntersTree.getTreeType());

        }

        [Fact]
        public void TestNationWaterResource()
        {
            Panel panel = new Panel();

            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsWS = new EgyptianKings(newg, panel);
            Assert.IsType<EgyptianKingsWaterSource>(egyptianKingsWS.getWaterSourceType());
            NationAbstract bangladeshiFarmerWS = new BangladeshiFarmers(newg, panel);
            Assert.IsType<BangladeshiFarmersWaterSource>(bangladeshiFarmerWS.getWaterSourceType());
            NationAbstract arabBedouinWS = new ArabBedouin(newg, panel);
            Assert.IsType<NullWaterSource>(arabBedouinWS.getWaterSourceType());
            NationAbstract inuitHuntersTree = new InuitHunters(newg, panel);
            Assert.IsType<NullWaterSource>(inuitHuntersTree.getWaterSourceType());

        }

        [Fact]
        public void TestNationTerrainColor()
        {
            Panel panel = new Panel();

            Graphics newg = panel.CreateGraphics();
            NationAbstract egyptianKingsT = new EgyptianKings(newg, panel);
            Color color = egyptianKingsT.getBackColor();
            Color expected = Color.Yellow;
            Assert.IsType<Color>(egyptianKingsT.getBackColor());
            NationAbstract bangladeshiFarmersT = new BangladeshiFarmers(newg, panel);
            Color color1 = bangladeshiFarmersT.getBackColor();
            Color expected1 = Color.Green;
            Assert.IsType<Color>(bangladeshiFarmersT.getBackColor());
            NationAbstract ArabT = new ArabBedouin(newg, panel);
            Color color2 = ArabT.getBackColor();
            Color expected2 = Color.LightGoldenrodYellow;
            Assert.IsType<Color>(ArabT.getBackColor());
            NationAbstract InuitT = new InuitHunters(newg, panel);
            Color color3 = InuitT.getBackColor();
            Color expected3 = Color.FloralWhite;
            Assert.IsType<Color>(InuitT.getBackColor());

        }
    }
}
