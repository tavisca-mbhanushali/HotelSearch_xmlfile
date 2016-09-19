using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using XmlToClass;

namespace HotelResponseService.Implementation
{
    public class XmlOperation
    {
       public static Response GetHotels()
        {
            Response r = new Response();
            XmlSerializer serializer = new XmlSerializer(typeof(SearchResult));
            StreamReader file = new StreamReader(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\XML.xml");
            var test = (SearchResult)serializer.Deserialize(file);
            List<FirstResponse> list = new List<FirstResponse>();
            foreach(var x in test.HotelList)
            {
                FirstResponse first = new FirstResponse();
                first.hotelId = x.hotelId.ToString();
                first.name = x.name;
                first.location = x.Location.location;
                first.minAverPrice = x.minAverPrice.ToString();
                first.NumOfRoom = x.NumOfRoom.ToString();
                first.bestValue = x.bestValue.ToString();
                list.Add(first);
            }
            r.ListofHotels = list;
            return r;
        }
    }
}