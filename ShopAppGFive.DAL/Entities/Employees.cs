

using ShopAppGFive.DAL.Core;

namespace ShopAppGFive.DAL.Entities
{
    public abstract class Employees : ShopPersonal
    {
        public string firstname { get; set; }

        public string lastname { get; set; }

        public int empid { get; set; }

    }
}
