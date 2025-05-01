using Foundation;
using System;
using UIKit;

namespace Exodus3.iOS
{
    public partial class SeriesViewController : UIViewController
    {
        public string SeriesName { get; set; }

        public SeriesViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           
            lblTitle.Font = UIFont.FromName("BrandonGrotesque-Bold", 26f);
            txtAboutSeries.Font = UIFont.FromName("BrandonGrotesque-Medium", 20f);
            //txtAboutSeries.TextContainerInset = UIEdgeInsets.Zero;
            //txtAboutSeries.TextContainer.LineFragmentPadding = 0;
            Title = "Current Series";

            //table source will be obtained via api call
            SeriesName = "Judges";
            lblTitle.Text = SeriesName;
            tblViewSermons.Source = new SermonsTableSource(new string[] { "First Sermon", "Second Sermon", "Third Sermon", "Fourth Sermon", "Fifth Sermon", "Sixth Sermon", "Seventh Sermon", "Eighth Sermon", "Ninth Sermon" }, this);
            tblViewSermons.BackgroundColor = UIColor.FromRGB(47f / 255f, 43f / 255f, 33f / 255f);

            //fix to eliminate the topmost section header and the gap it creates
            var frame = CoreGraphics.CGRect.Empty;
            frame.Height = 1;
            tblViewSermons.TableHeaderView = new UIView(frame);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.NavigationBarHidden = true;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            NavigationController.NavigationBarHidden = false;
        }
    }

    public class SermonsTableSource : UITableViewSource
    {
        string[] TableItems;
        string CellIdentifier = "TableCell";

        SeriesViewController owner;

        public SermonsTableSource(string[] items, SeriesViewController owner)
        {
            TableItems = items;
            this.owner = owner;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return TableItems.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var board = UIStoryboard.FromName("Main", null);

            var sermonCtrl = board.InstantiateViewController("SermonViewController") as SermonViewController;
            //sermonCtrl.Title = TableItems[indexPath.Section];
            sermonCtrl.SermonName = TableItems[indexPath.Section];
            sermonCtrl.SeriesName = owner.SeriesName;

            owner.NavigationController.PushViewController(sermonCtrl, true);

            tableView.DeselectRow(indexPath, true);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            E3TableViewCell cell = (E3TableViewCell)tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Section];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new E3TableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item;
            
            return cell;
        }
    }

    public class E3TableViewCell : UITableViewCell
    {
        public E3TableViewCell(UITableViewCellStyle style, string identifier) : base(style, identifier)
        {
            BackgroundColor = UIColor.FromRGB(67f / 255f, 68f / 255f, 59f / 255f);
            TextLabel.TextColor = UIColor.FromRGB(150f / 255f, 154f / 255f, 156f / 255f);
            TextLabel.Font = UIFont.FromName("BrandonGrotesque-Medium", 20f);
        }
    }
}