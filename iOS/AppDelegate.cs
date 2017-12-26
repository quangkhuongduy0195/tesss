using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Practices.Unity;
using Prism.Unity;
using UIKit;
using Views;

namespace MutiProject.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Base.WidthScreen = UIScreen.MainScreen.Bounds.Width;
            Base.HeightScreen = UIScreen.MainScreen.Bounds.Height;
            LoadApplication(new App(new iOSdInitializer()));

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSdInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}
