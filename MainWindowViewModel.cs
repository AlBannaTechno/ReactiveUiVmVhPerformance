using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUiVmVhPerformance.ViewModels;

namespace ReactiveUiVmVhPerformance
{
    public class MainWindowViewModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; }
        public SideMenuViewModel SideMenuViewModel { get; set; }
        [Reactive] public object BodyContent { get; set; }

        public MainWindowViewModel()
        {
            Activator = new ViewModelActivator();
            SideMenuViewModel = new SideMenuViewModel();

            this.WhenActivated(disposable =>
            {
                SideMenuViewModel.ShowSimpleUserInterface.Subscribe(_ =>
                {
                    BodyContent = new SimpleUserInterfaceViewModel();
                }).DisposeWith(disposable);

                SideMenuViewModel.ShowComplexUserInterface.Subscribe(_ =>
                {
                    BodyContent = new ComplexUserInterfaceViewModel();
                }).DisposeWith(disposable);

                SideMenuViewModel.ShowNothing.Subscribe(_ =>
                {
                    BodyContent = null;
                }).DisposeWith(disposable);

            });
        }
    }
}
