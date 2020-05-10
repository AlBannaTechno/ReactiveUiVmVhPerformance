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

namespace ReactiveUiVmVhPerformance.Helpers
{
    /// <summary>
    /// Interaction logic for SimpleViewModelViewHost.xaml
    /// </summary>
    public partial class SimpleViewModelViewHost : UserControl
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(object), typeof(SimpleViewModelViewHost), new PropertyMetadata(default(object)));

        public object ViewModel
        {
            get => GetValue(ViewModelProperty);
            set
            {
                SetValue(ViewModelProperty, value);
                if (value == null) { return; }
                var view = ViewLocator.Current.ResolveView(value);
                if (view != null)
                {
                    View = view;
                    View.ViewModel = value;

                }
                else
                {
                    MainContent.Content = value;
                }
            }
        }


        public static readonly DependencyProperty ViewProperty = DependencyProperty.Register(
            "View", typeof(IViewFor), typeof(SimpleViewModelViewHost), new PropertyMetadata(default(IViewFor)));

        public IViewFor View
        {
            get => (IViewFor)GetValue(ViewProperty);
            set => SetValue(ViewProperty, value);
        }

        public SimpleViewModelViewHost()
        {
            DataContext = this;
            InitializeComponent();
        }
    }
}
