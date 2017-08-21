using Android.App;
using Android.Widget;
using Android.OS;

namespace TestGit
{
    [Activity(Label = "TestGit", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private string d = "dd";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

