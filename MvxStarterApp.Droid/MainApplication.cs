using System;
using Android.Runtime;
using MvvmCross.Core;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Core;
using Android.App;

namespace MvxStarterApp.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<Core.App>, Core.App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
