namespace Observer
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
               Observer Pattern
                🔹 Intent
                1) The Observer Pattern defines a one-to-many dependency between objects, (publisher to subscribers)
                2) It is commonly used in event-driven systems, such as publish-subscribe models.
             */

            // Create Publisher
            YouTubeChannel channel = new YouTubeChannel();

            // Create Subscribers
            User user1 = new User("Ahmed");
            User user2 = new User("Mariam");

            //// Register Subscribers to Publisher
            channel.Subscribe(user1);
            channel.Subscribe(user2);

            // Upload a new video (Subscribers get notified)
            channel.UploadVideo("Design Patterns in C#");

            // Output:
            // YouTube Channel: Uploaded 'Design Patterns in C#'
            // User 'Ahmed' received a notification: New video uploaded - 'Design Patterns in C#'
            // User 'Mariam' received a notification: New video uploaded - 'Design Patterns in C#'

            Console.WriteLine();
            Console.WriteLine();


            // De-Register a user
            channel.Unsubscribe(user1);

            // Upload another video
            channel.UploadVideo("Observer Pattern Explained");

            // Output:
            // YouTube Channel: Uploaded 'Design Patterns in C#'
            // User 'Mariam' received a notification: New video uploaded - 'Design Patterns in C#'

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}