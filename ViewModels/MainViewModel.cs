using LanchesterLaw.Commands;
using LanchesterLaw.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LanchesterLaw.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        //public ICommand OnLinearCommand { get; }
        //public ICommand OnSquareCommand { get; }
        //public ICommand OnUniversalCommand { get; }
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        private RelayCommand _onLinearCommand;
        public RelayCommand OnLinearCommand
        {
            get
            {
                return _onLinearCommand ?? new RelayCommand(obj =>
                {
                    _navigationStore.CurrentViewModel = new LinearLanchesterLawViewModel();
                });
            }
        }
        private RelayCommand _onSquareCommand;
        public RelayCommand OnSquareCommand
        {
            get
            {
                return _onSquareCommand ?? new RelayCommand(obj =>
                {
                    _navigationStore.CurrentViewModel = new SquareLanchesterLawViewModel();
                });
            }
        }
        private RelayCommand _onUniversalCommand;
        public RelayCommand OnUniversalCommand
        {
            get
            {
                return _onUniversalCommand ?? new RelayCommand(obj =>
                {
                    _navigationStore.CurrentViewModel = new UniversalLanchesterLawViewModel();
                });
            }
        }
    }
}
