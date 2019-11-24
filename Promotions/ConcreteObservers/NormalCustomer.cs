using Promotions.Entities;
using Promotions.Observers;
using System;

namespace Promotions.ConcreteObservers
{
    class NormalCustomer : Customer
    {
        public NormalCustomer(int customerId, string customerName)
            : base(customerId, customerName)
        {
        }

        public override void Update(Promotion promotion)
        {
            if (promotion == null || promotion.ForVIPCustomer)
                return;

            Console.WriteLine(string.Format("Xin chao {0}, ban co 1 khuyen mai: {1}", CustomerName, promotion.Content));
        }
    }
}
