using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for SimpleUserInterfaceView.xaml
    /// </summary>
    public partial class SimpleUserInterfaceView : ReactiveUserControl<SimpleUserInterfaceViewModel>
    {
        public SimpleUserInterfaceView()
        {
            InitializeComponent();
        }
    }
}
