using DalApi;
using DO;
using System.Xml.Linq;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public const string FILE_PATH = @"..\xml\customers.xml";
    private const string CUSTOMER = "Customer";
    private const string IDENTITY = "Identity";
    private const string CUSTOMER_NAME = "CustomerName";
    private const string ADDRESS = "Address";
    private const string PHONE = "Phone";

    public int Create(Customer item)
    {
        try
        {
            XElement customerXml = XElement.Load(FILE_PATH);
            if (customerXml.Descendants(IDENTITY).Any(c => int.Parse(c.Value) == item.Identity))
                throw new DalIdExistException("הלקוח כבר קיים");
            XElement newCustomer = new XElement(CUSTOMER,
                                    new XElement(IDENTITY, item.Identity),
                                    new XElement(CUSTOMER_NAME, item.CustomerName),
                                    new XElement(ADDRESS, item.Address),
                                    new XElement(PHONE, item.Phone));
            customerXml.Add(newCustomer);
            customerXml.Save(FILE_PATH);
            return item.Identity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Customer? Read(int id)
    {
        try
        {
            XElement customerXml = XElement.Load(FILE_PATH);
            XElement idXml = customerXml.Descendants(IDENTITY).Single(c => int.Parse(c.Value) == id);
            XElement cXml = idXml.Parent;
            Customer customer = new Customer()
            {
                Identity = int.Parse(cXml.Element(IDENTITY).Value),
                CustomerName = cXml.Element(CUSTOMER_NAME).Value,
                Address = cXml.Element(ADDRESS).Value,
                Phone = cXml.Element(PHONE).Value
            };
            return customer ?? throw new DalIdNotExistException("לקוח לא קיים");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            XElement customerXml = XElement.Load(FILE_PATH);
            List<Customer?> customers = customerXml.Element(CUSTOMER).Elements().Where(c => filter(new Customer()
            {
                Identity = int.Parse(c.Element(IDENTITY).Value),
                CustomerName = c.Element(CUSTOMER_NAME).Value,
                Address = c.Element(ADDRESS).Value,
                Phone = c.Element(PHONE).Value
            }) == true).Select(c => new Customer()
            {
                Identity = int.Parse(c.Element(IDENTITY).Value),
                CustomerName = c.Element(CUSTOMER_NAME).Value,
                Address = c.Element(ADDRESS).Value,
                Phone = c.Element(PHONE).Value
            }).ToList();
            Customer? c = customers.FirstOrDefault();
            return c ?? throw new DalIdNotExistException("לקוח לא קיים");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        try
        {
            XElement customerXml = XElement.Load(FILE_PATH);
            if (filter != null)
            {
                List<Customer?> customers = customerXml.Element(CUSTOMER).Elements().Where(c => filter(new Customer()
                {
                    Identity = int.TryParse(c.Element(IDENTITY)?.Value, out var id) ? id : 0,
                    CustomerName = c.Element(CUSTOMER_NAME)?.Value ?? string.Empty,
                    Address = c.Element(ADDRESS)?.Value ?? string.Empty,
                    Phone = c.Element(PHONE)?.Value ?? string.Empty
                }) == true).Select(c => new Customer()
                {
                    Identity = int.TryParse(c.Element(IDENTITY)?.Value, out var id) ? id : 0,
                    CustomerName = c.Element(CUSTOMER_NAME)?.Value ?? string.Empty,
                    Address = c.Element(ADDRESS)?.Value ?? string.Empty,
                    Phone = c.Element(PHONE)?.Value ?? string.Empty
                }).ToList();
                return customers;
            }
            List<Customer> list = new List<Customer?>(customerXml.Elements().Select(c => new Customer()
            {
                Identity = int.TryParse(c.Element(IDENTITY)?.Value, out var id) ? id : 0,
                CustomerName = c.Element(CUSTOMER_NAME)?.Value ?? string.Empty,
                Address = c.Element(ADDRESS)?.Value ?? string.Empty,
                Phone = c.Element(PHONE)?.Value ?? string.Empty
            }).ToList());
            return list;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Update(Customer item)
    {
        Delete(item.Identity);
        Create(item);
    }

    public void Delete(int id)
    {
        try
        {
            XElement customerXml = XElement.Load(FILE_PATH);
            Customer c = Read(id);
            XElement idXml = customerXml.Descendants(IDENTITY).Single(c => int.Parse(c.Value) == id);
            XElement cXml = idXml.Parent;
            cXml.Remove();
            customerXml.Save(FILE_PATH);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
