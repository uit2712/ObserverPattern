using Promotions.Entities;
using Promotions.Observers;
using System.Collections.Generic;

namespace Promotions.Subjects
{
    class Vincom
    {
        public List<Customer> Customers { get; set; }
        public List<Promotion> Promotions { get; set; }

        public Vincom()
        {
            Customers = new List<Customer>();
            Promotions = new List<Promotion>();
        }

        public void AddPromotion(Promotion promotion)
        {
            if (promotion != null)
            {
                Promotions.Add(promotion);
                Notify(promotion);
            }
        }

        public void Attach(Customer customer)
        {
            if (customer != null)
                Customers.Add(customer);
        }

        public void Deattach(Customer customer)
        {
            Customers.Remove(customer);
        }

        private void Notify(Promotion promotion)
        {
            foreach (Customer customer in Customers)
                if (customer != null)
                    customer.Update(promotion);
        }
    }
}
