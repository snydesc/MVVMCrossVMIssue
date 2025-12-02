using MvvmCross.ViewModels;

namespace MvvmCrossVMIssue.Core.ViewModels
{
   public class MainViewModel : MvxViewModel
   {
      public string MainViewBoundText
      {
         get
         {
            return "Bound Text From MainViewModel";
         }
      }

      public MainViewModel()
      {
      }
   }
}
