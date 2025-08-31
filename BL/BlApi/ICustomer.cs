namespace BlApi;

public interface ICustomer
{
    int Create(BO.Customer item);
    BO.Customer? Read(int id);
    //BO.Customer? Read(Func<BO.Customer, bool> filter);
    //List<BO.Customer?> ReadAll();
    List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null);
    void Update(BO.Customer item);
    void Delete(int id);
    bool isExistCustomer(int id);
}

