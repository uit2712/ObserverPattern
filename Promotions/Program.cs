using Promotions.ConcreteObservers;
using Promotions.Entities;
using Promotions.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            Vincom vincom = new Vincom();
            vincom.Attach(new NormalCustomer(1, "Pham Teo"));
            vincom.Attach(new NormalCustomer(2, "Pham Ty"));
            vincom.Attach(new NormalCustomer(3, "Pham Bum"));
            vincom.Attach(new VIPCustomer(4, "Pham Toi"));
            vincom.Attach(new VIPCustomer(5, "Pham Hanh"));

            vincom.AddPromotion(new Promotion(false, "Mua 1 xe vinfast, tang 2 can ho gia 1 ty dong!"));
            Console.WriteLine();
            vincom.AddPromotion(new Promotion(true, "Mua 5 can ho, tang 1 phieu mua hang tri gia 100 trieu dong!"));
        }
    }
}
