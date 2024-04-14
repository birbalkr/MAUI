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
        public int first { get; set; }
        public int second { get; set; }
        public string input {  get; set; }
        public int result { get; set; }

        public ICommand ResultCommand =>
            new Command(Calculate);

        public void Calculate(object obj)
        {
            if (input == "-")
            {
                result = first - second;
            }
            if (input == "+")
            {
                result = first + second;
            }
            if (input == "*")
            {
                result = first * second;
            }
            else if (input == "/") {result = first / second; }
        }
        
    }
}