﻿
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace TccWposMvx4.Droid.Views
{
    [Activity(Label = "Main View")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}