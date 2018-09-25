using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Cinema.ViewModels 
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        MainViewModel()
        {
            PropertyChanged += (sender, e) =>
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(sender)));
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
