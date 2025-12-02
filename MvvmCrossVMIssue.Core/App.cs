using MvvmCross.ViewModels;

namespace MvvmCrossVMIssue.Core
{
   public class App : MvxApplication
   {
      public override void Initialize()
      {
         RegisterCustomAppStart<AppStart>();
      }
   }
}
