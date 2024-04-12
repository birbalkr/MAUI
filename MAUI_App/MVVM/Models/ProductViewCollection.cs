using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_App.MVVM.Models
{
    public class ProductViewCollection
    {   
        public List<Product> ProductView { get; set;} = new List<Product>();

        public ProductViewCollection()
        {
            ProductView.Add(new Product
            {
                Title = "Title",
                AvailQty = 20,
                ProductWeight = 5
            });
            ProductView.Add(new Product
            {
                Title = "HP",
                AvailQty = 25,
                ProductWeight = 4
            });
        }
    }
}
