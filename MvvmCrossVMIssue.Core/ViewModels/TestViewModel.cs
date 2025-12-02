using Microsoft.Extensions.Logging;
using MvvmCross.Logging;
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
         MvxLogHost.Default?.Log(LogLevel.Information, "TestViewModel::Constructed");
      }
   }
}
