using DalApi;
using System.Xml.Linq;

namespace Dal;

internal static class XmlTools
{
    // פונקציה ששולפת מהקובץ ערך של תכונה לפי השם שלה, אחרי קידום ב - 1
    public static string GetValueByName(string name)
    {
        XElement dataConfig = XElement.Load(Config.dataConfigXML) ??
           throw new DalConfigException("data-config.xml file is not found");

        XElement element = dataConfig.Element(name) ?? throw new DalConfigException("<dal> element is missing");

        int newVal = int.Parse(element.Value);
        element.SetValue(newVal + 1);

        dataConfig.Save(Config.dataConfigXML);

        return newVal.ToString();
    }
}
