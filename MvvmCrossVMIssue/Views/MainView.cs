using Android.Views;
using MvvmCross;
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