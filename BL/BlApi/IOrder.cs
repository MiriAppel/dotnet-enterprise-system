namespace BlApi;

public interface IOrder
{
    List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int idProduct, int amountToOrder);
    void CalcTotalPriceForProduct(BO.ProductInOrder product);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    void SearchSaleForProduct(BO.ProductInOrder product, bool isPriorityCustomer);
}
