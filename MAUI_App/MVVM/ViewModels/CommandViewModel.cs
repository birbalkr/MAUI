using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_App.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class CommandViewModel
    {
        public int first {  get; set; }
        public int second { get; set; }
        public int result { get; set; }

        public ICommand ResultCommand =>
            new Command(Calculate);

        public void Calculate(object obj)
        {
            result = first + second;
        }

        public ICommand CommandClick =>
            new Command(ExecuteAlert);

        public ICommand CommandSearch =>
           new Command(Commandpara);

        public ICommand CommandSearch1 =>
           new Command(Commandpara1);

        private void Commandpara1(object obj)
        {
            App.Current.MainPage.DisplayAlert("hi", $"{obj}", "ok");
        }

        private void Commandpara(object obj)
        {
            App.Current.MainPage.DisplayAlert("hi", $"{searchCommand}", "ok");
        }

        public string searchCommand {  get; set; }

private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("hi", "helloo", "ok");
        }
    }
}
