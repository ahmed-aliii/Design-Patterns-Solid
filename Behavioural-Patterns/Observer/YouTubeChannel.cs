using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Publisher
    class YouTubeChannel
    {
        //Ivocation List
        List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }


        //Notify Here
        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"YouTube Channel: Uploaded '{videoTitle}'");
            //Notification Here => Call Notification Function
            NotifySubscribers(videoTitle);
        }


        //Notification Function
        public void NotifySubscribers(string videoTitle)
        {
            foreach(var subscriber in _subscribers)
            {
                subscriber.Update(videoTitle);
            }
        }


    }
}
