using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantApp
{
    public class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Tax { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }

    }
}
