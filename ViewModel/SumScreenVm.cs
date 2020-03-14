using Strev.QuickTools.Core.Service;
using Strev.QuickTools.Core.ViewModel;
using Strev.QuickTools.Demo.Core.Service;
using Strev.QuickTools.DomainModel.Enumeration;
using Strev.QuickTools.ViewModel;

namespace Strev.QuickTools.Demo.ViewModel
{
    public class SumScreenVM : BaseScreenGenericVM
    {
        private ISumService SumService { get; }

        public SumScreenVM(IInitDisposeManager initDisposeManager, IScreenContainerVM parent, ISumService sumService)
            : base(initDisposeManager, parent)
        {
            ScreenName = "Addition";
            SumService = sumService;
        }

        public override void InitLayout()
        {
            LayoutVM
                .StartLayout(120)
                    .TopStack()
                        .AddInput("Value1", "Value1 : ", "")
                        .AddInput("Value2", "Value2 : ", "")
                    .EndStack()
                    .BottomStack()
                        .AddInputReadOnly("Result", "Result : ", "", TextSizeType.Medium)
                        .AddButton("Sum", "Sum", Sum)
                    .EndStack()
                .EndLayout();
        }

        private void Sum()
        {
            LayoutVM.SetValue("Result", SumService.Sum(LayoutVM.GetValue("Value1"), LayoutVM.GetValue("Value2")));
        }
    }
}