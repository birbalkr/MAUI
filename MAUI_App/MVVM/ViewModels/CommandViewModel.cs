using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_App.MVVM.ViewModels
{
    public class CommandViewModel
    {
        public ICommand CommandClick =>
            new Command(ExecuteAlert);
private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("hi", "helloo", "ok");
        }
    }
}
