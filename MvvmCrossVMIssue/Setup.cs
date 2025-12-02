using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using MvvmCrossVMIssue.Core;
using MvvmCrossVMIssue.Core.ViewModels;
using MvvmCrossVMIssue.Droid.Views;
using NLog.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace MvvmCrossVMIssue.Droid
{
   [RequiresUnreferencedCode("Uses MvvmCross reflection based plugin loading")]
   public class Setup : MvxAndroidSetup<App>
   {

      protected override ILoggerFactory CreateLogFactory()
      {
         NLogLoggerFactory factory = new NLogLoggerFactory();
         factory.CreateLogger("MVVMCross");
         return factory;
      }

      protected override ILoggerProvider CreateLogProvider()
      {
         return new NLogLoggerProvider();
      }
   }
}
