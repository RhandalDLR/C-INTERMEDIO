public class CustomerRepository : ICustomerRepository
{
    public string GetCustomerName(int id)
    {
        return $"Cliente real #{id}";
    }
}