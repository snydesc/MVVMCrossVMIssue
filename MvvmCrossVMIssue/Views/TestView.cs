using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCrossVMIssue.Core.ViewModels;

namespace MvvmCrossVMIssue.Droid.Views
{
   [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
   public class TestView : MvxFragment<TestViewModel>
   {
      public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
      {
         base.OnCreateView(inflater, container, savedInstanceState);
         View v = this.BindingInflate(Resource.Layout.screen_test, null);
         return v;
      }
   }
}
