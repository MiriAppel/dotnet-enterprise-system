namespace BlApi;

public interface IBl
{
    IProduct Product { get; }
    ISale Sale { get; }
    ICustomer Customer { get; }
    IOrder Order { get; }
}
