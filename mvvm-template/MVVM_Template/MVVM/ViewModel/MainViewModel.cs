using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Template.Core;

namespace MVVM_Template.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SecondViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public SecondViewModel SecondVM { get; set; }

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
            HomeVM = new HomeViewModel();
            SecondVM = new SecondViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            { 
                CurrentView = HomeVM;
            });

            SecondViewCommand = new RelayCommand(o => 
            { 
                CurrentView = SecondVM;
            });
        }
    }
}
