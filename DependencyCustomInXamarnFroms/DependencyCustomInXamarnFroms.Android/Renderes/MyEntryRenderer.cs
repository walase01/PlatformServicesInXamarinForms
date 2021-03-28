using Android.App;
using Android.Content;
using Android.OS;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using DependencyCustomInXamarnFroms.Controls;
using DependencyCustomInXamarnFroms.Droid.Renderes;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]

namespace DependencyCustomInXamarnFroms.Droid.Renderes
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                   Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }    
    }
}