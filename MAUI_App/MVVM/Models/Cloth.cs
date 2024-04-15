﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_App.MVVM.Models
{
    public class Cloth
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public int Stock { get; set; }

        public bool HasOffer { get; set; }

        public decimal HasPrice { get; set; }
    }
}
