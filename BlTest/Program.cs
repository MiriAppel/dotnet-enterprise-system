using DalTest;

namespace BlTest;

internal class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    private static void AddProduct(int select, BO.Order order)
    {
        try
        {
            int select2 = 1;
            Console.WriteLine("To add product press 1");
            Console.WriteLine("To exit press 0");
            if (!int.TryParse(Console.ReadLine(), out select2))
                select2 = 1;
            while (select2 == 1)
            {
                int id;
                int amount;
                Console.WriteLine("enter id of product");
                if (!int.TryParse(Console.ReadLine(), out id))
                    id = 100;
                Console.WriteLine("enter amount");
                if (!int.TryParse(Console.ReadLine(), out amount))
                    amount = 1;
                List<BO.SaleInProduct> listSale;
                if (s_bl.Customer.isExistCustomer(select))
                {
                    order.IsPriorityCustomer = true;
                    listSale = s_bl.Order.AddProductToOrder(order, id, amount);
                }
                else
                {
                    order.IsPriorityCustomer = false;
                    listSale = s_bl.Order.AddProductToOrder(order, id, amount);
                }
                foreach (BO.SaleInProduct sale in listSale)
                {
                    Console.WriteLine("sale:");
                    Console.WriteLine(sale.ToString());
                }
                Console.WriteLine($"total sum for the order so far: {order.FinalSumToPay}");
                Console.WriteLine("To add product enter 1");
                if (!int.TryParse(Console.ReadLine(), out select2))
                    select2 = 1;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Main(string[] args)
    {
        Initialization.Initialize();
        try
        {
            int select = -1;
            Console.WriteLine("Press id of customer");
            Console.WriteLine("or:");
            Console.WriteLine("Press 0 to exit");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            while (select != 0)
            {
                BO.Order order = new BO.Order();
                order.ProductsListInOrder = new List<BO.ProductInOrder>();
                AddProduct(select, order);
                Console.WriteLine("Press id of customer");
                Console.WriteLine("or:");
                Console.WriteLine("Press 0 to exit");
                if (!int.TryParse(Console.ReadLine(), out select))
                    select = -1;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
