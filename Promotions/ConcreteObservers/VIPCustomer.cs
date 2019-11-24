using Promotions.Entities;
using Promotions.Observers;
using Promotions.Subjects;
using System;

namespace Promotions.ConcreteObservers
{
    class VIPCustomer : Customer
    {
        public VIPCustomer(int customerId, string customerName): base(customerId, customerName)
        {
        }

        public override void Update(Promotion promotion, ShoppingMall shoppingMall)
        {
            if (promotion == null || shoppingMall == null)
                return;

            Console.WriteLine(string.Format("Xin chao {0}, ban co 1 khuyen mai tu {1}: {2}", CustomerName, shoppingMall.Name, promotion.Content));
        }
    }
}
