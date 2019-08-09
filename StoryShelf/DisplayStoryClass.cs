using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace StoryShelf
{
    public partial class DisplayStoryClass : UITableViewController
    {
        //string of the class type StoryInfo to get the data from the strings 
        public List<StoryInfo> allStories { get; set; }

        //new string to story the data in the cells 
        static NSString allStoryCellId = new NSString("allStoryCell");

        
        public DisplayStoryClass(IntPtr handle) : base(handle)
        {
            //getting the data in the cell of table using the class AllStories type 
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), allStoryCellId);
            TableView.Source = new AllStoriesDataSource(this);
            allStories = new List<StoryInfo>();
        }

        //creating a class of the type UitableViewSouce
        class AllStoriesDataSource : UITableViewSource
        {

            public List<string> TableData { get; private set; }
            //string of the class type StoryInfo to get the data from the strings 
            public List<StoryInfo> allStories { get; private set; }

            //implemneting the function to get the cell and the count from the rows and storing the data
            //in the cell.
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

            //function to delete the rows selected from the table view.
            public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
            {
                if (editingStyle == UITableViewCellEditingStyle.Delete)
                {

                    this.allStories.RemoveAt(indexPath.Row);
                    tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Automatic);

                }


            }
        }
         
    }
    
}
