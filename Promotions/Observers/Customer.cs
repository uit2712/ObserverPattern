using Promotions.Entities;

namespace Promotions.Observers
{
    abstract class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public abstract void Update(Promotion promotion);
    }
}
