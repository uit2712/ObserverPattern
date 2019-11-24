namespace Promotions.Entities
{
    class Promotion
    {
        public bool ForVIPCustomer { get; set; }
        public string Content { get; set; }

        public Promotion(bool forVIPCustomer, string content)
        {
            ForVIPCustomer = forVIPCustomer;
            Content = content;
        }
    }
}
