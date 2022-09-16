using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicApplication.Core;

namespace VetClinicApplication.MVVM.ViewModel
{
    class MainViewModel : VisualObject
    {
        public RelayCommand ClientViewCommand { get; set; }
        public RelayCommand ClientsListViewCommand { get; set; }
        public RelayCommand AnimalsViewCommand { get; set; }
        public RelayCommand ChipsViewCommand { get; set; }
        public RelayCommand ProceduresViewCommand { get; set; }


        public ClientViewModel ClientVM { get; set; }

        public ClientsListViewModel ClientsListVM { get; set; }

        public AnimalsViewModel AnimalsVM { get; set; }
        public ChipsViewModel ChipsVM { get; set; }
        public ProceduresViewModel ProceduresVM { get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        public MainViewModel()
        {
            ClientVM = new ClientViewModel();
            ClientsListVM = new ClientsListViewModel();
            AnimalsVM = new AnimalsViewModel();
            ChipsVM = new ChipsViewModel();
            ProceduresVM = new ProceduresViewModel();
         
            CurrentView = ClientVM;

            ClientViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClientVM;
            });

            ClientsListViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClientsListVM;
            });

            AnimalsViewCommand = new RelayCommand(o =>
            {
                CurrentView = AnimalsVM;
            });
           
            ChipsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ChipsVM;
            });

            ProceduresViewCommand = new RelayCommand(o =>
            {
                CurrentView = ProceduresVM;
            });
        }
    }
}
