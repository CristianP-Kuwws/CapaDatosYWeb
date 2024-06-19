

namespace ShopAppGFive.DAL.Entities
{
    public abstract class OrderDetails
    {
        public int orderid { get; set; }

        public int productid { get; set; }

        public decimal unitprice { get; set; }
    }
}
