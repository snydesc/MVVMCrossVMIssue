using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCrossVMIssue.Core.ViewModels;
using NLog;
using System.Reflection;

namespace MvvmCrossVMIssue.Core
{
   public class AppStart : MvxAppStart
   {
      public AppStart(IMvxApplication application, IMvxNavigationService navigationService)
         : base(application, navigationService)
      {
         NLog.LogManager.Setup().LoadConfigurationFromAssemblyResource(typeof(App).GetTypeInfo().Assembly);
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
