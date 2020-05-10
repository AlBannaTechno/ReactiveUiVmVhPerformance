using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;
using ReactiveUiVmVhPerformance.ViewModels;
using ReactiveUiVmVhPerformance.Views;
using Splat;

namespace ReactiveUiVmVhPerformance
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Locator.CurrentMutable.Register(() => new SideMenuView(), typeof(IViewFor<SideMenuViewModel>));
            Locator.CurrentMutable.Register(() => new SimpleUserInterfaceView(), typeof(IViewFor<SimpleUserInterfaceViewModel>));
            Locator.CurrentMutable.Register(() => new ComplexUserInterfaceView(), typeof(IViewFor<ComplexUserInterfaceViewModel>));
        }
    }
}
