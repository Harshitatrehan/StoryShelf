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

namespace StoryShelf
{
    [Register ("EntryFieldVC")]
    partial class EntryFieldVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DisplayStories { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton savebtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView storycontent { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField storytitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DisplayStories != null) {
                DisplayStories.Dispose ();
                DisplayStories = null;
            }

            if (savebtn != null) {
                savebtn.Dispose ();
                savebtn = null;
            }

            if (storycontent != null) {
                storycontent.Dispose ();
                storycontent = null;
            }

            if (storytitle != null) {
                storytitle.Dispose ();
                storytitle = null;
            }
        }
    }
}