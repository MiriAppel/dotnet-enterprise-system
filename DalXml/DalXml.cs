using System.Diagnostics;
using DalApi;

namespace Dal;

internal sealed class DalXml : IDal
{
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public ICustomer Customer => new CustomerImplementation();

    private static readonly DalXml instance = new DalXml();
    public static DalXml Instance { get { return instance; } }
    private DalXml() { }
}
