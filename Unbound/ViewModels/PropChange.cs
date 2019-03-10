using System.ComponentModel;

// Basic implementation of the INotifyPropertyChanged interface.
namespace Unbound.ViewModels
{
    class PropChange : INotifyPropertyChanged
    {
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new System.NotImplementedException();
            }

            remove
            {
                throw new System.NotImplementedException();
            }
        }
    }
}