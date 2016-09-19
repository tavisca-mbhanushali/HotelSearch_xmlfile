using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using XmlToClass;
using Newtonsoft.Json;
using Json1ToClass;

namespace ConsoleApplication1
{
    public class Deserialization
    {
        static void Main(string[] args)
        {
           // SearchResult search = new SearchResult();
            XmlSerializer serializer = new XmlSerializer(typeof(SearchResult));
            StreamReader file = new StreamReader(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\XML.xml");
            var test = (SearchResult)serializer.Deserialize(file);
            Console.ReadKey();

            List<HotelListHotel> list = new List<HotelListHotel>();

            foreach(var x in test.HotelList)
            {
                HotelListHotel hotel = new HotelListHotel();
                hotel.Location = x.Location;
                hotel.NumOfRoom = x.NumOfRoom;
                hotel.RoomTypes = x.RoomTypes;
                hotel.bestValue = x.bestValue;
                hotel.minAverPrice = x.minAverPrice;
                hotel.name = x.name;
                hotel.hotelId = x.hotelId;
                list.Add(hotel);
            }

            Console.WriteLine("Hotel Id :" + list[0].hotelId);
            Console.WriteLine("Address :" + list[0].locationField.address);
            Console.WriteLine("Minimum Prize :" + list[0].minAverPrice);
            Console.WriteLine("Hotel Name :" + list[0].name);
            Console.ReadKey();

            // var ResultList = JsonConverter.DeserializeObjest<List<>
            // JsonSerializer serializer1 = new JsonSerializer();

            StreamReader r = new StreamReader(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\json1.json");
            string json = r.ReadToEnd();

           var test2 = JsonConvert.DeserializeObject<Rootobject>(json);

            List<Hotelsummary> list2 = new List<Hotelsummary>();

            foreach (var item in test2.HotelListResponse.HotelList.HotelSummary)
            {
                list2.Add(item);
                Console.WriteLine(item);
            }

            Console.ReadKey();

            // var test2 = (SearchResult)serializer.Deserialize(file2);

            //List<HotelListHotel> list2 = new List<HotelListHotel>();

            //var ResultList = Newtonsoft.Json.JsonConvert.DeserializeObject(file2);
            //object JsonDe = JsonConvert.DeserializeObject(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\json1.json");

            // var tmp = JsonConvert.DeserializeObject(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\json1.json");


            //foreach (string typeStr in tmp.)
            //{
            //    // Do something with typeStr
            //}






            //foreach (var y in test2)
            //{
            //HotelListHotel hotel2 = new HotelListHotel();
            //hotel.Location = y.Location;
            //hotel.NumOfRoom = y.NumOfRoom;
            //hotel.RoomTypes = y.RoomTypes;
            //hotel.bestValue = y.bestValue;
            //hotel.minAverPrice = y.minAverPrice;
            //hotel.name = y.name;
            //hotel.hotelId = y.hotelId;
            //list.Add(hotel);
            ////}
            //Console.WriteLine("Hotel Id :" + list2[0].hotelId);
            //Console.WriteLine("Address :" + list2[0].locationField.address);
            //Console.WriteLine("Minimum Prize :" + list2[0].minAverPrice);
            //Console.WriteLine("Hotel Name :" + list2[0].name);
            //Console.ReadKey();
            //foreach(var y in test2.HotelList)
        }
    }
}
