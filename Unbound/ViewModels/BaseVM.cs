using System.ComponentModel;

namespace Unbound.ViewModels
{
    class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
