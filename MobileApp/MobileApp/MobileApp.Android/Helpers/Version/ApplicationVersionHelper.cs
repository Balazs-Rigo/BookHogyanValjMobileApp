using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileApp.Droid.Helpers.Version;
using Android.Content;
using MobileApp.Helpers.Version;

namespace MobileApp.Droid.Helpers.Version
{
    class ApplicationVersionHelper : IApplicationVersionHelper
    {
        public string GetApplicationVersion()
        {
            Context context = Android.App.Application.Context;
            var versionInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);
            return versionInfo.VersionName;
        }
    }
}