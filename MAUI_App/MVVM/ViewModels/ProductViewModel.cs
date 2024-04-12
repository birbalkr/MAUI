using MAUI_App.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_App.MVVM.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public ProductViewModel()
        {
            Product = new Product()
            {
                Title = "HP",
                Description = "laptop",
                AvailQty = 5,
                ProductWeight = 100,
                IsPopular = true,
                CreatedDate = new DateTime(2024, 03, 26)
            };
        }

    }
}
