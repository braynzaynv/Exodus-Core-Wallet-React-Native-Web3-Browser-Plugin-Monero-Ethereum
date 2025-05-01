using System;
using UIKit;

namespace Exodus3.iOS.Helpers
{
    public class UITextViewFixed : UITextView
    {
        public UITextViewFixed()
        {
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            TextContainerInset = UIEdgeInsets.Zero;
            TextContainer.LineFragmentPadding = 0;
        }    
    }
}
