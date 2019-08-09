using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace StoryShelf
{
    public partial class DisplayStoryClass : UITableViewController
    {
        public List<StoryInfo> allStories { get; set; }

        static NSString allStoryCellId = new NSString("allStoryCell");

        
        public DisplayStoryClass(IntPtr handle) : base(handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), allStoryCellId);
            TableView.Source = new AllStoriesDataSource(this);
            allStories = new List<StoryInfo>();
        }

        class AllStoriesDataSource : UITableViewSource
        {
            public List<string> TableData { get; private set; }
            public List<StoryInfo> allStories { get; private set; }

            DisplayStoryClass controller;
            public AllStoriesDataSource(DisplayStoryClass controller)
            {
                this.controller = controller;
            }
            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return controller.allStories.Count;
            }
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(DisplayStoryClass.allStoryCellId);
                int row = indexPath.Row;
                cell.TextLabel.Text = controller.allStories[row].title + " " + controller.allStories[row].content;
                return cell;
            }
            public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
            {
                if (editingStyle == UITableViewCellEditingStyle.Delete)
                {

                    this.allStories.RemoveAt(indexPath.Row);
                    tableView.DeleteRows(new NSIndexPath[] { indexPath },
                      UITableViewRowAnimation.Automatic);

                }


            }
        }
         
    }
    
}
