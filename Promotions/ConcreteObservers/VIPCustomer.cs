using Promotions.Entities;
using Promotions.Observers;
using System;

namespace Promotions.ConcreteObservers
{
    class VIPCustomer : Customer
    {
        public VIPCustomer(int customerId, string customerName): base(customerId, customerName)
        {
        }

        public override void Update(Promotion promotion)
        {
            if (promotion == null)
                return;

            Console.WriteLine(string.Format("Xin chao {0}, ban co 1 khuyen mai: {1}", CustomerName, promotion.Content));
        }
    }
}
