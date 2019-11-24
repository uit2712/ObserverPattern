using Promotions.Entities;
using Promotions.Observers;
using Promotions.Subjects;
using System;

namespace Promotions.ConcreteObservers
{
    class NormalCustomer : Customer
    {
        public NormalCustomer(int customerId, string customerName)
            : base(customerId, customerName)
        {
        }

        public override void Update(Promotion promotion, ShoppingMall shoppingMall)
        {
            if (promotion == null || shoppingMall == null || promotion.ForVIPCustomer)
                return;

            Console.WriteLine(string.Format("Xin chao {0}, ban co 1 khuyen mai tu {1}: {2}", CustomerName, shoppingMall.Name, promotion.Content));
        }
    }
}
