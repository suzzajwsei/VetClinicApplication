using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VetClinicApplication.Core
{
    class VisualObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
