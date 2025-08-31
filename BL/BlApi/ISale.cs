namespace BlApi;

public interface ISale
{
    int Create(BO.Sale item);
    BO.Sale? Read(int id);
    //BO.Sale? Read(Func<BO.Sale, bool> filter);
    //List<BO.Sale?> ReadAll();
    List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null);
    void Update(BO.Sale item);
    void Delete(int id);
}
