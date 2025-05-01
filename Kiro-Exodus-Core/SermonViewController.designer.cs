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
    [Register ("SermonViewController")]
    partial class SermonViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPlaySermon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSermonName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtAboutSermon { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnPlaySermon != null) {
                btnPlaySermon.Dispose ();
                btnPlaySermon = null;
            }

            if (lblSermonName != null) {
                lblSermonName.Dispose ();
                lblSermonName = null;
            }

            if (txtAboutSermon != null) {
                txtAboutSermon.Dispose ();
                txtAboutSermon = null;
            }
        }
    }
}