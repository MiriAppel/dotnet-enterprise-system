namespace BlApi;

public interface IProduct
{
    int Create(BO.Product item);
    BO.Product? Read(int id);
    //BO.Product? Read(Func<BO.Product, bool> filter);
    //List<BO.Product?> ReadAll();
    List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);
    void Update(BO.Product item);
    void Delete(int id);
    List<BO.SaleInProduct> SaleInForce(int idProduct, bool isPriorityCustomer);
}
