using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicWPF.Core;

namespace VetClinicWPF.MVVM.ViewModel
{
    class MainViewModel : VisualObject
    {
        public RelayCommand ClientViewCommand { get; set; }
        public RelayCommand ClientsListViewCommand { get; set; }


        public ClientViewModel ClientVM { get; set; }

        public ClientsListViewModel ClientsListVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            ClientVM = new ClientViewModel();
            ClientsListVM = new ClientsListViewModel();
         
            CurrentView = ClientVM;

            ClientViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClientVM;
            });

            ClientsListViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClientsListVM;
            });

        }
    }
}
