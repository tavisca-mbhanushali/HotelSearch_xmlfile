using HotelResponseClientt.HotelServiceClientReference;
using System;

namespace HotelResponse
{
    class Program
    {
        static void Main(string[] args)
        {

            HotelResponseClientt.HotelServiceClientReference.HotelResponseClient client = new HotelResponseClientt.HotelServiceClientReference.HotelResponseClient();
            Response res = client.GetHotels();
            //HotelResponseService.HotelResponseClient client = new HotelResponseService.HotelResponseClient();
            //HotelResponseService.Response res = new HotelResponseService.Response();
            //res= client.GetHotels();

            foreach(var x in res.ListofHotels)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Hotel Id  = {0}",x.hotelId);
                Console.WriteLine("Hotel name  = {0}", x.name);
                Console.WriteLine("Hotel Location = {0}", x.location);
                Console.WriteLine("No. Of Rooms = {0} ", x.NumOfRoom);
                Console.WriteLine("No. Of RoomTypes = {0} ", x.RoomTypes);
                Console.WriteLine("------------------------------------------------------------------");
           
            }
           // Console.ReadKey();

        }
    }
}
