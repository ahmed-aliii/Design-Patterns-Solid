



namespace Composite
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
              When to Use Composite Pattern?
                ✅ When dealing with hierarchical structures (file systems, menus, organizations).
                ✅ Treats a group of objects like a single object.
             */

            // Create individual files
            IFileSystemItem file1 = new File("Document.txt");
            IFileSystemItem file2 = new File("Image.png");


            // Create a folder and add files to it
            Folder myFolder = new Folder("My Folder");
            myFolder.AddItem(file1);
            myFolder.AddItem(file2);


            // Create another folder and add File To it
            Folder subFolder = new Folder("Sub Folder");
            subFolder.AddItem(new File("Music.mp3"));

            // Add sub-folder to main folder
            myFolder.AddItem(subFolder);

            // Display folder structure
            myFolder.ShowDetails();
        }
    }
}