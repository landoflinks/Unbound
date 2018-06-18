using System.ComponentModel;

namespace Unbound.ViewModels
{
    // Base event for INotifyPropertyChanged.
    public abstract class BaseProperty : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
