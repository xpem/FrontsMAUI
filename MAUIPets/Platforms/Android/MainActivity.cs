using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MAUIPets;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Locked)]
public class MainActivity : MauiAppCompatActivity
{
}
