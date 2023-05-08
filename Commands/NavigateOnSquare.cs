using LanchesterLaw.Stores;
using LanchesterLaw.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesterLaw.Commands
{
    internal class NavigateOnSquare : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public NavigateOnSquare(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parametr)
        {
            _navigationStore.CurrentViewModel = new SquareLanchesterLawViewModel();
        }
    }
}
