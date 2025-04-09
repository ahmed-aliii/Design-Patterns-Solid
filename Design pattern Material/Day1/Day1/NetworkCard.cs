using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class NetworkCard
    {
        static NetworkCard networkCard;

        private NetworkCard()
        {

        }

        public static NetworkCard Create()
        {
            if (networkCard == null)
                networkCard = new NetworkCard();

            return networkCard;
        }
    }
}
