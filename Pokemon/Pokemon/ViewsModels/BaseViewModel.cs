using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pokemon.ViewsModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool isBusy;

        public bool GetIsBusy()
        {
            return isBusy;
        }

        public void SetIsBusy(bool value)
        {
            isBusy = value;
            OnPropertyChanged();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
