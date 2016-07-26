using Android.App;
using MvvmCross.Droid.Views;

namespace Droid.View
{
    [Activity(Label = "SQLite mvvmcross example", MainLauncher = false)]
    public class ProductView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.second);
        }
    }
}