using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Facade Class
    class HotelFacade
    {
        private readonly RoomService _roomService;
        private readonly HouseKeeping _houseKeeping;
        private readonly Billing _billing;

        public HotelFacade()
        {
            _roomService = new RoomService();
            _houseKeeping = new HouseKeeping();
            _billing = new Billing();
        }


        //Facade Function
        public void RequestFullHotelServices()
        {
            Console.WriteLine("Processing full hotel service...");
            _roomService.OrderFood();
            _houseKeeping.CleanRoom();
            _billing.GenerateInvoice();
            Console.WriteLine("All hotel services completed.");
        }

    }
}
