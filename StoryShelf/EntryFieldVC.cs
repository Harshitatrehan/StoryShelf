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
            //implementing the save button and adding data 
            savebtn.TouchUpInside += (object sender, EventArgs e) =>
            {
                StoryInfo newStory = new StoryInfo(storytitle.Text , storycontent.Text);
                allTitle.Add(newStory);
                string infoString = "Title:" + newStory.title + "Content" + newStory.content;
                //adding alert when the data is stored successfully 
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

        //function to shift from one screen to the other 
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
