using System.ComponentModel.DataAnnotations;

namespace ShopAppGFive.DAL.Entities
{
    public class Categories
    {
        [Key]
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
    }
}

