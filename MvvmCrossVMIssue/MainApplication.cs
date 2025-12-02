using Android.Runtime;
using MvvmCross;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using MvvmCrossVMIssue.Core;
using System.Diagnostics.CodeAnalysis;

namespace MvvmCrossVMIssue.Droid
{
   [RequiresUnreferencedCode("Uses MvvmCross reflection based plugin loading")]
   [Application(HardwareAccelerated = true, UsesCleartextTraffic = true)]
   public class MainApplication : MvxAndroidApplication<Setup, App>
   {
      public MainApplication()
      {
      }

      public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
          : base(javaReference, transfer)
      {
      }

      public override async void OnCreate()
      {
         base.OnCreate();

         if (Mvx.IoCProvider?.TryResolve(out IMvxAppStart? startup) == true && !startup!.IsStarted)
         {
            await startup.StartAsync();
         }
      }
   }
}
