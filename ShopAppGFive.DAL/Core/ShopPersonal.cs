namespace ShopAppGFive.DAL.Core
{
    public abstract class ShopPersonal : BaseShopEntity
    {
        public string address { get; set; }

        public string? region { get; set; }

        public string? postalcode { get; set; }

        public string phone { get; set; }
    }
}
