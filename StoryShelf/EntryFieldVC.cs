using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace StoryShelf
{
    public partial class EntryFieldVC : UIViewController
    {

        public List<StoryInfo> allTitle { get; set; }

        public EntryFieldVC (IntPtr handle) : base (handle)
        {
            allTitle = new List<StoryInfo>();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            savebtn.TouchUpInside += (object sender, EventArgs e) =>
            {
                StoryInfo newStory = new StoryInfo(storytitle.Text , storycontent.Text);
                allTitle.Add(newStory);
                string infoString = "Title:" + newStory.title + "Content" + newStory.content;
                var alert = UIAlertController.Create("New Title Added", infoString, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);

            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var displayStoryCollection = segue.DestinationViewController as
            DisplayStoryClass;
            if (displayStoryCollection != null)
            {
                displayStoryCollection.allStories = allTitle;
            }
        }
    }
}
