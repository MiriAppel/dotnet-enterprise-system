using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : ISale
{
    public const string FILE_PATH = @"..\xml\sales.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));

    public int Create(Sale item)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale s = item with { IdSale = Config.SaleCode };
            sales.Add(s);
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            return s.IdSale;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale? s = sales.FirstOrDefault(s => s.IdSale == id);
            return s ?? throw new DalIdNotExistException("מבצע לא קיים");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale? s = sales.FirstOrDefault(s => filter(s) == true);
            return s ?? throw new DalIdExistException("לא קיים מבצע עם סינון זה");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            if (filter != null)
            {
                sales = sales.Where(s => filter(s) == true).ToList();
            }
            return sales;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Update(Sale item)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            int index = sales.FindIndex(s => s.IdSale == item.IdSale);
            sales[index] = item;
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fileStream, sales);
            }
        }
        catch
        {
            throw new DalIdNotExistException("מזהה מבצע לא קיים");
        }
    }

    public void Delete(int id)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale s = Read(id);
            sales.Remove(s);
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
