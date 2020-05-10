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
    /// Interaction logic for ComplexUserInterfaceView.xaml
    /// </summary>
    public partial class ComplexUserInterfaceView : ReactiveUserControl<ComplexUserInterfaceViewModel>
    {
        public ComplexUserInterfaceView()
        {
            InitializeComponent();

            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, vm => vm.FirstName, v => v.FirstName.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName, v => v.LastName.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email, v => v.Email.Text).DisposeWith(disposable);


                this.Bind(ViewModel, vm => vm.FirstName1, v => v.FirstName1.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName2, v => v.LastName2.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email3, v => v.Email3.Text).DisposeWith(disposable);

                this.Bind(ViewModel, vm => vm.FirstName4, v => v.FirstName4.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName5, v => v.LastName5.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email6, v => v.Email6.Text).DisposeWith(disposable);

                this.Bind(ViewModel, vm => vm.FirstName7, v => v.FirstName7.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName8, v => v.LastName8.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email9, v => v.Email9.Text).DisposeWith(disposable);

                this.Bind(ViewModel, vm => vm.FirstName10, v => v.FirstName10.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName11, v => v.LastName11.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email12, v => v.Email12.Text).DisposeWith(disposable);

                this.Bind(ViewModel, vm => vm.FirstName13, v => v.FirstName13.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName14, v => v.LastName14.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email15, v => v.Email15.Text).DisposeWith(disposable);

                this.Bind(ViewModel, vm => vm.FirstName16, v => v.FirstName16.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.LastName17, v => v.LastName17.Text).DisposeWith(disposable);
                this.Bind(ViewModel, vm => vm.Email18, v => v.Email18.Text).DisposeWith(disposable);


            });
        }
    }
}
