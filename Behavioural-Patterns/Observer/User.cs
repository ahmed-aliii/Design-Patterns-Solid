using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Subscriber
    class User : ISubscriber
    {
        private string _name;

        public User(string name)
        {
            _name = name;
        }
        //CallBack Function
        public void Update(string videoTitle)
        {
            Console.WriteLine($"user '{_name}' received a notification: New video uploaded - '{videoTitle}'");
        }
    }
}
