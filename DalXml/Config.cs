using System.Xml.Linq;

namespace Dal;

public static class Config
{
    public const string dataConfigXML = @"../xml/data-config.xml";

    public static int ProductCode => int.Parse(XmlTools.GetValueByName("ProductCode"));
    public static int SaleCode => int.Parse(XmlTools.GetValueByName("SaleCode"));
}
