using MvvmCross.ViewModels;
using MvvmCrossVMIssue.Core.ViewModels;
using NLog;
using System.Reflection;

namespace MvvmCrossVMIssue.Core
{
   public class App : MvxApplication
   {
      public override void Initialize()
      {
         NLog.LogManager.Setup().LoadConfigurationFromAssemblyResource(typeof(App).GetTypeInfo().Assembly);
         RegisterCustomAppStart<AppStart>();
      }
   }
}
