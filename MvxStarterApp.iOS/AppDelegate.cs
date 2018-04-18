using Foundation;
using UIKit;
using MvvmCross.Platforms.Ios.Core;

namespace MvxStarterApp.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<Core.App>, Core.App>
    {
    }
}

