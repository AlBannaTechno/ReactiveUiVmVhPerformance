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

namespace ReactiveUiVmVhPerformance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            ViewModel = new MainWindowViewModel();

            InitializeComponent();
            IDisposable mainDisposable = null;
            mainDisposable = this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel, vm => vm.SideMenuViewModel, v => v.SideMenu.ViewModel).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.BodyContent, v => v.BodyContent.ViewModel).DisposeWith(disposable);

                mainDisposable.DisposeWith(disposable);
            });
        }
    }
}
