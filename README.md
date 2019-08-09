# StoryShelf
Platform: Xamarin.Ios Application 

# Description 
The StoryShelf is an ios application which is created using C# and .NET framework in Visula studio using Xamarin.The story shelf contains short stories of 3 different geners namely adventure , horror and fiction.The app can be used to develop one's own story using by filling the form provided under "Creation Tab". The story will be saved and displayed as list which can be modified and completely destroyed too.The application has interactive element and bright colour combinations to enhace the appearance of the application.

# Project Directories Justification 
- MainstoryBoard: StoryShelf/Main.storyboard. Contains the UI screens and the navigation Controllers for the application. In total 6 UI screens with 2 navigations controllers and one table view.The UI screens make use of UI elements like button, text views, imageViews etc.

- LaunchScreen.Storyboard: StoryShelf/LaunchScreen.storyboard. Contains the splash screen for the application.

- Resources: StoryShelf/StoryShelf/Resources.Contains the list of images used.Please note all images have liscene bearing free for commerical use.

- StoryInfo.cs: StoryShelf/StoryInfo.cs. Contains two strings and a constructor(parametrised) to store the data and then obtain the data in the list for accesing.

- DisplayStoryClass.cs: StoryShelf/DisplayStoryClass.cs. Contains functions implemented on TableView and its cell to get the data and store it in the cell and display as a list.Also the table rows and index path are used to add the delete option in the list.

- EntryFieldVC.cs: StoryShelf/EntryFieldVC.cs.Store and save the data entered by the user in the text field and text views and displays the conformation message in the form of alert once the user presses the save button.



