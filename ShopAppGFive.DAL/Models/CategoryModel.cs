namespace Shop.DAL.Models
{
    public class CategoryModel // Vista detallada de la categoria, no le aplique herencia.
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
    }
}
