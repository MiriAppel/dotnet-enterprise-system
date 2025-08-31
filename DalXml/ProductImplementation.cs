using DalApi;
using DO;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public const string FILE_PATH = @"..\xml\products.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

    public int Create(Product item)
    {
        try 
        {
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                products = serializer.Deserialize(fileStream) as List<Product?>;
            }
            Product p = item with { IdProduct = Config.ProductCode };
            products.Add(p);
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, products);
            }
            return p.IdProduct;
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }

    public Product? Read(int id)
    {
        try
        {
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                products = serializer.Deserialize(fileStream) as List<Product?>;
            }
            Product? p = products.FirstOrDefault(p => p.IdProduct == id);
            return p ?? throw new DalIdNotExistException("מוצר לא קיים");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                products = serializer.Deserialize(fileStream) as List<Product?>;
            }
            Product? p = products.FirstOrDefault(p => filter(p) == true);
            return p ?? throw new DalIdExistException("לא קיים מוצר עם סינון זה");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        try
        {
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                products = serializer.Deserialize(fileStream) as List<Product?>;
            }
            if (filter != null)
            {
                products = products.Where(p => filter(p) == true).ToList();
            }
            return products;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Update(Product item)
    {
        try
        {
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                products = serializer.Deserialize(fileStream) as List<Product?>;
            }
            int index = products.FindIndex(p => p.IdProduct == item.IdProduct);
            products[index] = item;
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fileStream, products);
            }
        }
        catch
        {
            throw new DalIdNotExistException("מזהה מוצר לא קיים");
        }
    }

    public void Delete(int id)
    {
        try
        {
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            {
                products = serializer.Deserialize(fileStream) as List<Product?>;
            }
            Product p = Read(id);
            products.Remove(p);
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, products);
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
