using Android.Content.PM;
using Android.Views;
using Microsoft.Extensions.Logging;
using MvvmCross;
using MvvmCross.Logging;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using MvvmCrossVMIssue.Core.ViewModels;

namespace MvvmCrossVMIssue.Droid.Views
{
   [MvxActivityPresentation(ViewModelType = typeof(MainViewModel), ViewType = typeof(MainView))]
   [Activity(
      AlwaysRetainTaskState = true,
      ConfigurationChanges =                          
                   ConfigChanges.Locale
                 | ConfigChanges.Keyboard
                 | ConfigChanges.KeyboardHidden
                 | ConfigChanges.ScreenLayout
                 | ConfigChanges.ScreenSize
                 | ConfigChanges.Mnc                    
                 | ConfigChanges.Mcc                    
                 | ConfigChanges.UiMode,
      Exported = true,
      Enabled = true,
      Label = "@string/app_name",
      LaunchMode = LaunchMode.SingleTask,
      MainLauncher = true,
      Theme = "@style/AppTheme",
      WindowSoftInputMode = Android.Views.SoftInput.AdjustPan | Android.Views.SoftInput.StateAlwaysHidden,
      UiOptions = UiOptions.SplitActionBarWhenNarrow
     )]
   public class MainView : MvxActivity<MainViewModel>
   {
      protected override void OnCreate(Bundle? savedInstanceState)
      {
         MvxLogHost.Default?.Log(LogLevel.Information, "MainView::Created");
         /*
         // Work around for MVVM Cross Bug https://github.com/MvvmCross/MvvmCross/issues/4957
         if (Mvx.IoCProvider?.TryResolve(out IMvxAndroidViewModelLoader? viewModelLoader) == true && viewModelLoader != null)
         {
            IMvxBundle? bundle = null;
            if (Mvx.IoCProvider?.TryResolve<IMvxSavedStateConverter>(out var converter) == true && converter != null)
            {
               bundle = converter.Read(savedInstanceState);
            }

            var vm = viewModelLoader.Load(this.Intent, bundle, typeof(MainViewModel));
            var view = (IMvxView)this;
            view.OnViewCreate(() => vm);
         }
         */
         base.OnCreate(savedInstanceState);

         SetContentView(Resource.Layout.activity_main);
      }
   }
}