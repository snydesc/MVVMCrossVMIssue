using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossVMIssue.Core.ViewModels;

namespace MvvmCrossVMIssue.Core
{
   public class AppStart : MvxAppStart
   {
      public AppStart(IMvxApplication application, IMvxNavigationService navigationService)
         : base(application, navigationService)
      {
      }

      protected override async Task<object?> ApplicationStartup(object? hint = null!)
      {
         return base.ApplicationStartup(hint);
      }

      protected override async Task NavigateToFirstViewModel(object? hint = null)
      {
         await this.NavigationService.Navigate<TestViewModel>();
      }
   }
}
