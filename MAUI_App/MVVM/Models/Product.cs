using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_App.MVVM.Models
{
    public class Product
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int AvailQty { get; set; }

        public int ProductWeight { get; set; }

        public bool IsPopular { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
