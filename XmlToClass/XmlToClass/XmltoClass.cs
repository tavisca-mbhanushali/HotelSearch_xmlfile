using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlToClass
{

     
         public class XMLTstDataResponse1
        {
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial  class SearchResult
        {

        public Info infoField;

        public HotelListHotel[] hotelListField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
            public Info Info
            {
                get { return this.infoField; }
                set { this.infoField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Hotel", IsNullable = false)]
            public HotelListHotel[] HotelList
            {
                get { return this.hotelListField; }
                set { this.hotelListField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.tourico.com/webservices/hotelv3",
             IsNullable = false)]
        public partial class Info
        {

            private byte versionField;

            private string cultureField;

            private System.DateTime serverTimeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte version
            {
                get { return this.versionField; }
                set { this.versionField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string culture
            {
                get { return this.cultureField; }
                set { this.cultureField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime serverTime
            {
                get { return this.serverTimeField; }
                set { this.serverTimeField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotel
        {

            public HotelListHotelLocation locationField;

            public HotelListHotelRoomType[] roomTypesField;

            public ushort brandIdField;

            public string brandNameField;

            public string categoryField;

            public string propertySubTypeField;

            public ushort numOfRoomField;

            public decimal minAverPublishPriceField;

            public string propertyTypeField;

            public string nameField;

            public bool bestValueField;

            public uint hotelIdField;

            public string providerField;

            public string thumbField;

            public string currencyField;

            public decimal minAverPriceField;

            public decimal starsLevelField;

            public string descField;

            /// <remarks/>
            public HotelListHotelLocation Location
            {
                get { return this.locationField; }
                set { this.locationField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("RoomType", IsNullable = false)]
            public HotelListHotelRoomType[] RoomTypes
            {
                get { return this.roomTypesField; }
                set { this.roomTypesField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort brandId
            {
                get { return this.brandIdField; }
                set { this.brandIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string brandName
            {
                get { return this.brandNameField; }
                set { this.brandNameField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string category
            {
                get { return this.categoryField; }
                set { this.categoryField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PropertySubType
            {
                get { return this.propertySubTypeField; }
                set { this.propertySubTypeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort NumOfRoom
            {
                get { return this.numOfRoomField; }
                set { this.numOfRoomField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal minAverPublishPrice
            {
                get { return this.minAverPublishPriceField; }
                set { this.minAverPublishPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string PropertyType
            {
                get { return this.propertyTypeField; }
                set { this.propertyTypeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get { return this.nameField; }
                set { this.nameField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool bestValue
            {
                get { return this.bestValueField; }
                set { this.bestValueField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint hotelId
            {
                get { return this.hotelIdField; }
                set { this.hotelIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string provider
            {
                get { return this.providerField; }
                set { this.providerField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string thumb
            {
                get { return this.thumbField; }
                set { this.thumbField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currency
            {
                get { return this.currencyField; }
                set { this.currencyField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal minAverPrice
            {
                get { return this.minAverPriceField; }
                set { this.minAverPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal starsLevel
            {
                get { return this.starsLevelField; }
                set { this.starsLevelField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string desc
            {
                get { return this.descField; }
                set { this.descField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelLocation
        {

            private string countryCodeField;

            private string stateCodeField;

            private string cityField;

            private string searchingStateField;

            private string searchingCityField;

            private string locationField;

            private string addressField;

            private string longitudeField;

            private string latitudeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string countryCode
            {
                get { return this.countryCodeField; }
                set { this.countryCodeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string stateCode
            {
                get { return this.stateCodeField; }
                set { this.stateCodeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string city
            {
                get { return this.cityField; }
                set { this.cityField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string searchingState
            {
                get { return this.searchingStateField; }
                set { this.searchingStateField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string searchingCity
            {
                get { return this.searchingCityField; }
                set { this.searchingCityField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string location
            {
                get { return this.locationField; }
                set { this.locationField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string address
            {
                get { return this.addressField; }
                set { this.addressField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longitude
            {
                get { return this.longitudeField; }
                set { this.longitudeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latitude
            {
                get { return this.latitudeField; }
                set { this.latitudeField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomType
        {

            public HotelListHotelRoomTypeAvailability[] availabilityBreakdownField;

            public HotelListHotelRoomTypeDiscount discountField;

            public HotelListHotelRoomTypeOccupancies occupanciesField;

            public byte numOfBathroomsField;

            public string roomTypeCategoryField;

            public byte roomTypeCategoryIdField;

            public byte nightsField;

            public string nameField;

            public string productIdField;

            public System.DateTime startDateField;

            public uint hotelRoomTypeIdField;

            public uint roomIdField;

            public bool isAvailableField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Availability", IsNullable = false)]
            public HotelListHotelRoomTypeAvailability[] AvailabilityBreakdown
            {
                get { return this.availabilityBreakdownField; }
                set { this.availabilityBreakdownField = value; }
            }

            /// <remarks/>
            public HotelListHotelRoomTypeDiscount Discount
            {
                get { return this.discountField; }
                set { this.discountField = value; }
            }

            /// <remarks/>
            public HotelListHotelRoomTypeOccupancies Occupancies
            {
                get { return this.occupanciesField; }
                set { this.occupanciesField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte NumOfBathrooms
            {
                get { return this.numOfBathroomsField; }
                set { this.numOfBathroomsField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string roomTypeCategory
            {
                get { return this.roomTypeCategoryField; }
                set { this.roomTypeCategoryField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte roomTypeCategoryId
            {
                get { return this.roomTypeCategoryIdField; }
                set { this.roomTypeCategoryIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte nights
            {
                get { return this.nightsField; }
                set { this.nightsField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get { return this.nameField; }
                set { this.nameField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string productId
            {
                get { return this.productIdField; }
                set { this.productIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime startDate
            {
                get { return this.startDateField; }
                set { this.startDateField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint hotelRoomTypeId
            {
                get { return this.hotelRoomTypeIdField; }
                set { this.hotelRoomTypeIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint roomId
            {
                get { return this.roomIdField; }
                set { this.roomIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isAvailable
            {
                get { return this.isAvailableField; }
                set { this.isAvailableField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeAvailability
        {

            private byte offsetField;

            private bool statusField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte offset
            {
                get { return this.offsetField; }
                set { this.offsetField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool status
            {
                get { return this.statusField; }
                set { this.statusField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeDiscount
        {

            private System.DateTime fromField;

            private System.DateTime toField;

            private string typeField;

            private byte valueField;

            private bool valueFieldSpecified;

            private string nameField;

            private byte payField;

            private bool payFieldSpecified;

            private byte stayField;

            private bool stayFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime from
            {
                get { return this.fromField; }
                set { this.fromField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime to
            {
                get { return this.toField; }
                set { this.toField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get { return this.typeField; }
                set { this.typeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get { return this.valueField; }
                set { this.valueField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool valueSpecified
            {
                get { return this.valueFieldSpecified; }
                set { this.valueFieldSpecified = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get { return this.nameField; }
                set { this.nameField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte pay
            {
                get { return this.payField; }
                set { this.payField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool paySpecified
            {
                get { return this.payFieldSpecified; }
                set { this.payFieldSpecified = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte stay
            {
                get { return this.stayField; }
                set { this.stayField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool staySpecified
            {
                get { return this.stayFieldSpecified; }
                set { this.stayFieldSpecified = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupancies
        {

            private HotelListHotelRoomTypeOccupanciesOccupancy occupancyField;

            /// <remarks/>
            public HotelListHotelRoomTypeOccupanciesOccupancy Occupancy
            {
                get { return this.occupancyField; }
                set { this.occupancyField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancy
        {

            private HotelListHotelRoomTypeOccupanciesOccupancyPrice[] priceBreakdownField;

            private HotelListHotelRoomTypeOccupanciesOccupancyRooms roomsField;

            private HotelListHotelRoomTypeOccupanciesOccupancySupplement[] selctedSupplementsField;

            private HotelListHotelRoomTypeOccupanciesOccupancyBoardbase[] boardBasesField;

            private decimal taxPublishField;

            private decimal avrNightPublishPriceField;

            private string occupIdField;

            private decimal occupPriceField;

            private decimal taxField;

            private byte maxGuestsField;

            private byte maxChildField;

            private decimal avrNightPriceField;

            private decimal occupPublishPriceField;

            private bool isPublishField;

            private string beddingField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Price", IsNullable = false)]
            public HotelListHotelRoomTypeOccupanciesOccupancyPrice[] PriceBreakdown
            {
                get { return this.priceBreakdownField; }
                set { this.priceBreakdownField = value; }
            }

            /// <remarks/>
            public HotelListHotelRoomTypeOccupanciesOccupancyRooms Rooms
            {
                get { return this.roomsField; }
                set { this.roomsField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Supplement", IsNullable = false)]
            public HotelListHotelRoomTypeOccupanciesOccupancySupplement[] SelctedSupplements
            {
                get { return this.selctedSupplementsField; }
                set { this.selctedSupplementsField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Boardbase", IsNullable = false)]
            public HotelListHotelRoomTypeOccupanciesOccupancyBoardbase[] BoardBases
            {
                get { return this.boardBasesField; }
                set { this.boardBasesField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal taxPublish
            {
                get { return this.taxPublishField; }
                set { this.taxPublishField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal avrNightPublishPrice
            {
                get { return this.avrNightPublishPriceField; }
                set { this.avrNightPublishPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string occupId
            {
                get { return this.occupIdField; }
                set { this.occupIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal occupPrice
            {
                get { return this.occupPriceField; }
                set { this.occupPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal tax
            {
                get { return this.taxField; }
                set { this.taxField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte maxGuests
            {
                get { return this.maxGuestsField; }
                set { this.maxGuestsField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte maxChild
            {
                get { return this.maxChildField; }
                set { this.maxChildField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal avrNightPrice
            {
                get { return this.avrNightPriceField; }
                set { this.avrNightPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal occupPublishPrice
            {
                get { return this.occupPublishPriceField; }
                set { this.occupPublishPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPublish
            {
                get { return this.isPublishField; }
                set { this.isPublishField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bedding
            {
                get { return this.beddingField; }
                set { this.beddingField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancyPrice
        {

            private byte offsetField;

            private decimal valueField;

            private decimal valuePublishField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte offset
            {
                get { return this.offsetField; }
                set { this.offsetField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get { return this.valueField; }
                set { this.valueField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal valuePublish
            {
                get { return this.valuePublishField; }
                set { this.valuePublishField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancyRooms
        {

            private HotelListHotelRoomTypeOccupanciesOccupancyRoomsRoom roomField;

            /// <remarks/>
            public HotelListHotelRoomTypeOccupanciesOccupancyRoomsRoom Room
            {
                get { return this.roomField; }
                set { this.roomField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancyRoomsRoom
        {

            private byte adultNumField;

            private byte childNumField;

            private byte seqNumField;

            /// <remarks/>
            public byte AdultNum
            {
                get { return this.adultNumField; }
                set { this.adultNumField = value; }
            }

            /// <remarks/>
            public byte ChildNum
            {
                get { return this.childNumField; }
                set { this.childNumField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte seqNum
            {
                get { return this.seqNumField; }
                set { this.seqNumField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancySupplement
        {

            private HotelListHotelRoomTypeOccupanciesOccupancySupplementSuppAgeGroup suppAgeGroupField;

            private uint suppIdField;

            private string suppNameField;

            private byte supptTypeField;

            private bool suppIsMandatoryField;

            private string suppChargeTypeField;

            private decimal priceField;

            private decimal publishPriceField;

            /// <remarks/>
            public HotelListHotelRoomTypeOccupanciesOccupancySupplementSuppAgeGroup SuppAgeGroup
            {
                get { return this.suppAgeGroupField; }
                set { this.suppAgeGroupField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint suppId
            {
                get { return this.suppIdField; }
                set { this.suppIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string suppName
            {
                get { return this.suppNameField; }
                set { this.suppNameField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte supptType
            {
                get { return this.supptTypeField; }
                set { this.supptTypeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool suppIsMandatory
            {
                get { return this.suppIsMandatoryField; }
                set { this.suppIsMandatoryField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string suppChargeType
            {
                get { return this.suppChargeTypeField; }
                set { this.suppChargeTypeField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal price
            {
                get { return this.priceField; }
                set { this.priceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal publishPrice
            {
                get { return this.publishPriceField; }
                set { this.publishPriceField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancySupplementSuppAgeGroup
        {

            private HotelListHotelRoomTypeOccupanciesOccupancySupplementSuppAgeGroupSupplementAge supplementAgeField;

            /// <remarks/>
            public HotelListHotelRoomTypeOccupanciesOccupancySupplementSuppAgeGroupSupplementAge SupplementAge
            {
                get { return this.supplementAgeField; }
                set { this.supplementAgeField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancySupplementSuppAgeGroupSupplementAge
        {

            private byte suppFromField;

            private byte suppToField;

            private byte suppQuantityField;

            private decimal suppPriceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte suppFrom
            {
                get { return this.suppFromField; }
                set { this.suppFromField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte suppTo
            {
                get { return this.suppToField; }
                set { this.suppToField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte suppQuantity
            {
                get { return this.suppQuantityField; }
                set { this.suppQuantityField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal suppPrice
            {
                get { return this.suppPriceField; }
                set { this.suppPriceField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        public partial class HotelListHotelRoomTypeOccupanciesOccupancyBoardbase
        {

            private uint bbIdField;

            private string bbNameField;

            private decimal bbPriceField;

            private decimal bbPublishPriceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint bbId
            {
                get { return this.bbIdField; }
                set { this.bbIdField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bbName
            {
                get { return this.bbNameField; }
                set { this.bbNameField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal bbPrice
            {
                get { return this.bbPriceField; }
                set { this.bbPriceField = value; }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal bbPublishPrice
            {
                get { return this.bbPublishPriceField; }
                set { this.bbPublishPriceField = value; }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
             Namespace = "http://schemas.tourico.com/webservices/hotelv3")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.tourico.com/webservices/hotelv3",
             IsNullable = false)]
        public partial class HotelList
        {

            private HotelListHotel[] hotelField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Hotel")]
            public HotelListHotel[] Hotel
            {
                get { return this.hotelField; }
                set { this.hotelField = value; }
            }
        }

    }

