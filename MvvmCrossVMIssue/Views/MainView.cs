using Android.Views;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCrossVMIssue.Core.ViewModels;

namespace MvvmCrossVMIssue.Droid.Views
{
   [MvxActivityPresentation(ViewModelType = typeof(MainViewModel), ViewType = typeof(MainView))]
   [Activity(
      Exported = true,
      Enabled = true,
      Label = "@string/app_name",
      Theme = "@style/AppTheme",
      WindowSoftInputMode = SoftInput.AdjustPan,
      MainLauncher = true)]
   public class MainView : MvxActivity<MainViewModel>
   {
      protected override void OnCreate(Bundle? savedInstanceState)
      {
         base.OnCreate(savedInstanceState);
         SetContentView(Resource.Layout.activity_main);
      }
   }
}