using MAUI_App.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_App.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ClothViewModels
    {
        public ObservableCollection<Cloth>
             Products { get; set; } = new ObservableCollection<Cloth>();
        public bool IsRefresh { get; set; }

        public ICommand DeleteCommand => 
            new Command((i) =>
        {
            Products.Remove((Cloth)i);
        });

        public ICommand RefreshCommand => new Command(async ()=>{
            IsRefresh= true;
            await Task.Delay(2000);
            RefreshItem(/*Products.Count*/);
            IsRefresh= false;
            });

        public ICommand ReachedCommand => new Command(() => {
            RefreshItem(/*Products.Count*/);
        });


        public ClothViewModels()
        {
            RefreshItem();   
        }

        private void RefreshItem( /*int lastItem=0*/)
        {
            //var ItemPerPage = 2;
            var Items = new ObservableCollection<Cloth>()
            {
                new Cloth
                {
                    Title ="Red T-Shirt",
                    Description="",
                    Price = 1200,
                    Image = "a1.jpeg",
                    Stock = 4 ,
                    HasOffer = false,
                    HasPrice = 1000
                },
                new Cloth
                {
                    Title ="Red Jacket",
                    Description="",
                    Price = 1200,
                    Image = "a2.jpeg",
                    Stock = 4 ,
                    HasOffer = true,
                    HasPrice = 1000
                },
                new Cloth
                {
                    Title ="Light Green T-Shirt",
                    Description="",
                    Price = 800,
                    Image = "a3.jpeg",
                    Stock = 4 ,
                    HasOffer = false,
                    HasPrice = 550
                },
                new Cloth
                {
                    Title ="Red T-Shirt",
                    Description="",
                    Price = 1200,
                    Image = "a4.jpeg",
                    Stock = 4 ,
                    HasOffer = true,
                    HasPrice = 1000
                },
                new Cloth
                {
                    Title ="Black Shirt",
                    Description="",
                    Price = 550,
                    Image = "a5.jpeg",
                    Stock = 4 ,
                    HasOffer = true,
                    HasPrice = 300
                },
                new Cloth
                {
                    Title ="Light-Blue Shirt",
                    Description="",
                    Price = 600,
                    Image = "a6.jpeg",
                    Stock = 4 ,
                    HasOffer = true,
                    HasPrice = 420
                },
                new Cloth
                {
                    Title ="Light-Blue Shirt",
                    Description="",
                    Price = 600,
                    Image = "a7.jpeg",
                    Stock = 4 ,
                    HasOffer = false,
                    HasPrice = 420
                },
                new Cloth
                {
                    Title ="Light-Blue Shirt",
                    Description="",
                    Price = 600,
                    Image = "a8.jpeg",
                    Stock = 4 ,
                    HasOffer = true,
                    HasPrice = 420
                },
                new Cloth
                {
                    Title ="Light-Blue Shirt",
                    Description="",
                    Price = 600,
                    Image = "a9.jpeg",
                    Stock = 4 ,
                    HasOffer = false,
                    HasPrice = 420
                },
                new Cloth
                {
                    Title ="Light-Blue Shirt",
                    Description="",
                    Price = 600,
                    Image = "a10.jpeg",
                    Stock = 4 ,
                    HasOffer = true,
                    HasPrice = 420
                },
            };
            //var PageItems= Items.Skip(lastItem).Take(ItemPerPage);
            foreach (var item in Items)
            {
                Products.Add(item);
            }
        }
    }
}
