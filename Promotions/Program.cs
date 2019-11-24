using Promotions.ConcreteObservers;
using Promotions.ConcreteSubjects;
using Promotions.Entities;
using Promotions.Subjects;
using System;

namespace Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingMall vincom = new Vincom();
            ShoppingMall gigaMall = new GigaMall();
            vincom.Attach(new NormalCustomer(1, "Pham Teo"));
            vincom.Attach(new NormalCustomer(2, "Pham Ty"));
            vincom.Attach(new NormalCustomer(3, "Pham Bum"));
            vincom.Attach(new VIPCustomer(4, "Pham Toi"));
            vincom.Attach(new VIPCustomer(5, "Pham Hanh"));
            gigaMall.Attach(new NormalCustomer(1, "Pham Mit"));
            gigaMall.Attach(new NormalCustomer(2, "Pham Buoi"));
            gigaMall.Attach(new VIPCustomer(3, "Pham Oi"));

            vincom.AddPromotion(new Promotion(false, "Mua 1 xe vinfast, tang 2 can ho gia 1 ty dong!"));
            Console.WriteLine();
            vincom.AddPromotion(new Promotion(true, "Mua 5 can ho, tang 1 phieu mua hang tri gia 100 trieu dong!"));
            Console.WriteLine();
            gigaMall.AddPromotion(new Promotion(true, "Mua 1 tui Hermès Birkin Ginza Tanaka, tang ngay 50 chiec ao so mi tri gia 1 trieu dong!"));
            Console.WriteLine();
            gigaMall.AddPromotion(new Promotion(false, "Mua 1 ao khoac Denim, tang ngay 1 can ho sang chanh tri gia 2 ty dong!"));
        }
    }
}
