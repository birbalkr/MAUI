using MAUI_App.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_App.Selectors
{
    public class ClothDataTemplateSelector :
            DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var cloth = item as Cloth;
            if (!cloth.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ClothRes", out var clothRes);
                return clothRes as DataTemplate;
            }
            else
            {
                Application.Current.Resources.TryGetValue("OfferCloth", out var offerCloth);
                return offerCloth as DataTemplate;
            }
            return new DataTemplate();
        }
    }
}
