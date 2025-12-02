using MvvmCross.ViewModels;


namespace MvvmCrossVMIssue.Core.ViewModels
{
   public class TestViewModel : MvxViewModel
   {
      public string TestViewBoundText
      {
         get
         {
            return "Bound Text From TestViewModel";
         }
      }
      public TestViewModel()
      {
      }
   }
}
