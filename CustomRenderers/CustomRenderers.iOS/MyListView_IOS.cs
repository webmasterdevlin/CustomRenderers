using CustomRenderers;
using CustomRenderers.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyListView), typeof(MyListView_IOS))]

namespace CustomRenderers.iOS
{
    internal class MyListView_IOS : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SeparatorColor = UIKit.UIColor.Red;
            }
        }
    }
}