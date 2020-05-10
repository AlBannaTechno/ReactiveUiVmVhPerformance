using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace ReactiveUiVmVhPerformance.ViewModels
{
    public class SideMenuViewModel
    {
        #region Proxy Commands

        /// <summary>
        ///
        /// </summary>
        public ReactiveCommand<Unit, Unit> ShowSimpleUserInterface { get; }
        public ReactiveCommand<Unit, Unit> ShowComplexUserInterface { get; }
        public ReactiveCommand<Unit, Unit> ShowNothing { get; }

        #endregion

        public SideMenuViewModel()
        {
            #region Commands

            ShowSimpleUserInterface = ReactiveCommand.Create(() => { });
            ShowComplexUserInterface = ReactiveCommand.Create(() => { });
            ShowNothing = ReactiveCommand.Create(() => { });

            #endregion


        }
    }
}
