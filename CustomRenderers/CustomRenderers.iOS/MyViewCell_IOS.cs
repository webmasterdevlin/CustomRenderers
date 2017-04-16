using CustomRenderers;
using CustomRenderers.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(MyViewCell), typeof(MyViewCell_IOS))]
namespace CustomRenderers.iOS
{
    internal class MyViewCell_IOS : ViewCellRenderer
    {
        public override UIKit.UITableViewCell GetCell(Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell,
            UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.BackgroundColor = UIColor.Red;
            return cell;
        }
    }
}