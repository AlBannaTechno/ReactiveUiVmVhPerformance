using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using ReactiveUiVmVhPerformance.ViewModels;

namespace ReactiveUiVmVhPerformance.Views
{
    /// <summary>
    /// Interaction logic for SideMenuView.xaml
    /// </summary>
    public partial class SideMenuView : ReactiveUserControl<SideMenuViewModel>
    {
        public SideMenuView()
        {
            InitializeComponent();

            IDisposable mainDisposable = null;
            mainDisposable = this.WhenActivated(disposable =>
            {
                this.BindCommand(ViewModel, vm => vm.ShowSimpleUserInterface, v => v.ShowSimpleUi).DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.ShowComplexUserInterface, v => v.ShowComplexU).DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.ShowNothing, v => v.ShowNothing).DisposeWith(disposable);
                mainDisposable.DisposeWith(disposable);
            });
        }
    }
}
