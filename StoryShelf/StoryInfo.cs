using System;
namespace StoryShelf
{
    public class StoryInfo
    {
        public String title;
        public String content;

        public StoryInfo(string newTitle, string newcontent)
        {
            title = newTitle;
            content = newcontent;
        }
    }
}
