using MVVMTest.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        //public event EventHandler CloseHandler;
        //public RelayCommand CloseCommand { get; private set; }

        public ViewModelBase()
        {
            //CloseCommand = new RelayCommand(p => { if (CloseHandler != null) CloseHandler(this, EventArgs.Empty); });
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
