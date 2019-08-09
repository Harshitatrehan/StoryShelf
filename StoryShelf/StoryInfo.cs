using System;
namespace StoryShelf
{
    public class StoryInfo
    {
        //string to save the title and content of the story
        public String title;
        public String content;

        //creating constructor
        public StoryInfo(string newTitle, string newcontent)
        {
            //assigning values
            title = newTitle;
            content = newcontent;
        }
    }
}
