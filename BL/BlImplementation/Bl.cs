using BlApi;

namespace BlImplementation;

internal class Bl : IBl
{
    public IProduct Product => new ProductImplementation();

    public ISale Sale => new SaleImplementation();

    public ICustomer Customer => new CustomerImplementation();

    public IOrder Order => new OrderImplementation();
}
