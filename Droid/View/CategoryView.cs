using Android.App;
using MvvmCross.Droid.Views;

namespace Droid.View
{
    [Activity(Label = "SQLite mvvmcross example", MainLauncher = true)]
    public class CategoryView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.main);
        }
    }
}