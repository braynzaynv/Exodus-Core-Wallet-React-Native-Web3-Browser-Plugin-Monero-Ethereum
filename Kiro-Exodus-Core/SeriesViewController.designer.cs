// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Exodus3.iOS
{
    [Register ("SeriesViewController")]
    partial class SeriesViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblViewSermons { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtAboutSeries { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblTitle != null) {
                lblTitle.Dispose ();
                lblTitle = null;
            }

            if (tblViewSermons != null) {
                tblViewSermons.Dispose ();
                tblViewSermons = null;
            }

            if (txtAboutSeries != null) {
                txtAboutSeries.Dispose ();
                txtAboutSeries = null;
            }
        }
    }
}