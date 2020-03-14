using Strev.QuickTools.Core.ViewModel;
using Strev.QuickTools.Demo.Core.Service;
using Strev.QuickTools.Demo.Service;
using Strev.QuickTools.Demo.ViewModel;
using Strev.QuickTools.MainApp;
using Strev.QuickTools.ViewModel;
using System;

namespace Strev.QuickTools.Demo.MainApp
{
    public class Starter : BaseStarter
    {
        [STAThread]
        public static void Main()
        {
            BaseApp<Starter>.MainEntryPoint();
        }

        public override void OnCreate()
        {
            ISumService sumService = new SumService();
            IScreenVM sumScreenVm(IScreenContainerVM parent) => new SumScreenVM(InitDisposeManager, parent, sumService);
            MainWindowVM = new MainWindowVM(InitDisposeManager, "QuickTools Demo", sumScreenVm);
        }
    }
}