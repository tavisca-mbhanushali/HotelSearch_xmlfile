//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace XmlToClass
//{

//    public class Rootobject
//    {
//        public GethotelratesLiveNet getHotelRatesLiveNet { get; set; }
//    }

//    public class GethotelratesLiveNet
//    {
//        public Results results { get; set; }
//    }

//    public class Results
//    {
//        public string status { get; set; }
//        public int status_code { get; set; }
//        public Hotel_Data hotel_data { get; set; }
//        public string time { get; set; }
//    }

//    public class Hotel_Data
//    {
//        public Hotel_0 hotel_0 { get; set; }
//        public Hotel_1 hotel_1 { get; set; }
//        public Hotel_2 hotel_2 { get; set; }
//    }

//    public class Hotel_0
//    {
//        public int id { get; set; }
//        public string check_in_time { get; set; }
//        public string check_out_time { get; set; }
//        public Rate_Data rate_data { get; set; }
//    }

//    public class Rate_Data
//    {
//        public Rate_0 rate_0 { get; set; }
//        public Rate_1 rate_1 { get; set; }
//        public Rate_2 rate_2 { get; set; }
//        public Rate_3 rate_3 { get; set; }
//        public Rate_4 rate_4 { get; set; }
//        public Rate_5 rate_5 { get; set; }
//    }

//    public class Rate_0
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information important_information { get; set; }
//    }

//    public class Details_Summary
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data night_price_data { get; set; }
//    }

//    public class Night_Price_Data
//    {
//        public Night_Price_0 night_price_0 { get; set; }
//        public Night_Price_1 night_price_1 { get; set; }
//        public Night_Price_2 night_price_2 { get; set; }
//        public Night_Price_3 night_price_3 { get; set; }
//        public Night_Price_4 night_price_4 { get; set; }
//    }

//    public class Night_Price_0
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_1
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_2
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_3
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_4
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data
//    {
//        public Promo_0 promo_0 { get; set; }
//    }

//    public class Promo_0
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information
//    {
//        public Policy_0 policy_0 { get; set; }
//        public Policy_1 policy_1 { get; set; }
//    }

//    public class Policy_0
//    {
//        public string title { get; set; }
//        public Paragraph_Data paragraph_data { get; set; }
//    }

//    public class Paragraph_Data
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_1
//    {
//        public string title { get; set; }
//        public Paragraph_Data1 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data1
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_1
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary1 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details1 price_details { get; set; }
//        public Plugin_Data plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information1 important_information { get; set; }
//    }

//    public class Details_Summary1
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details1
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data1 night_price_data { get; set; }
//    }

//    public class Night_Price_Data1
//    {
//        public Night_Price_01 night_price_0 { get; set; }
//        public Night_Price_11 night_price_1 { get; set; }
//        public Night_Price_21 night_price_2 { get; set; }
//        public Night_Price_31 night_price_3 { get; set; }
//        public Night_Price_41 night_price_4 { get; set; }
//    }

//    public class Night_Price_01
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_11
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_21
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_31
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_41
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data
//    {
//        public Aaa aaa { get; set; }
//    }

//    public class Aaa
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information1
//    {
//        public Policy_01 policy_0 { get; set; }
//        public Policy_11 policy_1 { get; set; }
//        public Policy_2 policy_2 { get; set; }
//    }

//    public class Policy_01
//    {
//        public string title { get; set; }
//        public Paragraph_Data2 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data2
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_11
//    {
//        public string title { get; set; }
//        public Paragraph_Data3 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data3
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_2
//    {
//        public string title { get; set; }
//        public Paragraph_Data4 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data4
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_2
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary2 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details2 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data1 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information2 important_information { get; set; }
//    }

//    public class Details_Summary2
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details2
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data2 night_price_data { get; set; }
//    }

//    public class Night_Price_Data2
//    {
//        public Night_Price_02 night_price_0 { get; set; }
//        public Night_Price_12 night_price_1 { get; set; }
//        public Night_Price_22 night_price_2 { get; set; }
//        public Night_Price_32 night_price_3 { get; set; }
//        public Night_Price_42 night_price_4 { get; set; }
//    }

//    public class Night_Price_02
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_12
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_22
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_32
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_42
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data1
//    {
//        public Promo_01 promo_0 { get; set; }
//    }

//    public class Promo_01
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information2
//    {
//        public Policy_02 policy_0 { get; set; }
//        public Policy_12 policy_1 { get; set; }
//    }

//    public class Policy_02
//    {
//        public string title { get; set; }
//        public Paragraph_Data5 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data5
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_12
//    {
//        public string title { get; set; }
//        public Paragraph_Data6 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data6
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_3
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary3 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details3 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information3 important_information { get; set; }
//    }

//    public class Details_Summary3
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details3
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public int source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public int display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data3 night_price_data { get; set; }
//    }

//    public class Night_Price_Data3
//    {
//        public Night_Price_03 night_price_0 { get; set; }
//        public Night_Price_13 night_price_1 { get; set; }
//        public Night_Price_23 night_price_2 { get; set; }
//        public Night_Price_33 night_price_3 { get; set; }
//        public Night_Price_43 night_price_4 { get; set; }
//    }

//    public class Night_Price_03
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_13
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_23
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_33
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_43
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information3
//    {
//        public Policy_03 policy_0 { get; set; }
//        public Policy_13 policy_1 { get; set; }
//    }

//    public class Policy_03
//    {
//        public string title { get; set; }
//        public Paragraph_Data7 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data7
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_13
//    {
//        public string title { get; set; }
//        public Paragraph_Data8 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data8
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_4
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary4 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details4 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information4 important_information { get; set; }
//    }

//    public class Details_Summary4
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details4
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data4 night_price_data { get; set; }
//    }

//    public class Night_Price_Data4
//    {
//        public Night_Price_04 night_price_0 { get; set; }
//        public Night_Price_14 night_price_1 { get; set; }
//        public Night_Price_24 night_price_2 { get; set; }
//        public Night_Price_34 night_price_3 { get; set; }
//        public Night_Price_44 night_price_4 { get; set; }
//    }

//    public class Night_Price_04
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_14
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_24
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_34
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_44
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information4
//    {
//        public Policy_04 policy_0 { get; set; }
//        public Policy_14 policy_1 { get; set; }
//    }

//    public class Policy_04
//    {
//        public string title { get; set; }
//        public Paragraph_Data9 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data9
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_14
//    {
//        public string title { get; set; }
//        public Paragraph_Data10 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data10
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_5
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary5 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details5 price_details { get; set; }
//        public Plugin_Data1 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information5 important_information { get; set; }
//    }

//    public class Details_Summary5
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details5
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data5 night_price_data { get; set; }
//    }

//    public class Night_Price_Data5
//    {
//        public Night_Price_05 night_price_0 { get; set; }
//        public Night_Price_15 night_price_1 { get; set; }
//        public Night_Price_25 night_price_2 { get; set; }
//        public Night_Price_35 night_price_3 { get; set; }
//        public Night_Price_45 night_price_4 { get; set; }
//    }

//    public class Night_Price_05
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_15
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_25
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_35
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_45
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data1
//    {
//        public Aaa1 aaa { get; set; }
//    }

//    public class Aaa1
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information5
//    {
//        public Policy_05 policy_0 { get; set; }
//        public Policy_15 policy_1 { get; set; }
//        public Policy_21 policy_2 { get; set; }
//    }

//    public class Policy_05
//    {
//        public string title { get; set; }
//        public Paragraph_Data11 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data11
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_15
//    {
//        public string title { get; set; }
//        public Paragraph_Data12 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data12
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_21
//    {
//        public string title { get; set; }
//        public Paragraph_Data13 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data13
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Hotel_1
//    {
//        public int id { get; set; }
//        public string check_in_time { get; set; }
//        public string check_out_time { get; set; }
//        public Rate_Data1 rate_data { get; set; }
//    }

//    public class Rate_Data1
//    {
//        public Rate_01 rate_0 { get; set; }
//        public Rate_11 rate_1 { get; set; }
//        public Rate_21 rate_2 { get; set; }
//        public Rate_31 rate_3 { get; set; }
//        public Rate_41 rate_4 { get; set; }
//        public Rate_51 rate_5 { get; set; }
//        public Rate_6 rate_6 { get; set; }
//        public Rate_7 rate_7 { get; set; }
//        public Rate_8 rate_8 { get; set; }
//        public Rate_9 rate_9 { get; set; }
//        public Rate_10 rate_10 { get; set; }
//        public Rate_111 rate_11 { get; set; }
//        public Rate_12 rate_12 { get; set; }
//        public Rate_13 rate_13 { get; set; }
//    }

//    public class Rate_01
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary6 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details6 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data2 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information6 important_information { get; set; }
//    }

//    public class Details_Summary6
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details6
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public int source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public int display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data6 night_price_data { get; set; }
//    }

//    public class Night_Price_Data6
//    {
//        public Night_Price_06 night_price_0 { get; set; }
//        public Night_Price_16 night_price_1 { get; set; }
//        public Night_Price_26 night_price_2 { get; set; }
//        public Night_Price_36 night_price_3 { get; set; }
//        public Night_Price_46 night_price_4 { get; set; }
//    }

//    public class Night_Price_06
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_16
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_26
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_36
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_46
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data2
//    {
//        public Promo_02 promo_0 { get; set; }
//    }

//    public class Promo_02
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information6
//    {
//        public Policy_06 policy_0 { get; set; }
//        public Policy_16 policy_1 { get; set; }
//    }

//    public class Policy_06
//    {
//        public string title { get; set; }
//        public Paragraph_Data14 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data14
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_16
//    {
//        public string title { get; set; }
//        public Paragraph_Data15 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data15
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_11
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary7 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details7 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data3 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information7 important_information { get; set; }
//    }

//    public class Details_Summary7
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details7
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data7 night_price_data { get; set; }
//    }

//    public class Night_Price_Data7
//    {
//        public Night_Price_07 night_price_0 { get; set; }
//        public Night_Price_17 night_price_1 { get; set; }
//        public Night_Price_27 night_price_2 { get; set; }
//        public Night_Price_37 night_price_3 { get; set; }
//        public Night_Price_47 night_price_4 { get; set; }
//    }

//    public class Night_Price_07
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_17
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_27
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_37
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_47
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data3
//    {
//        public Promo_03 promo_0 { get; set; }
//    }

//    public class Promo_03
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information7
//    {
//        public Policy_07 policy_0 { get; set; }
//        public Policy_17 policy_1 { get; set; }
//    }

//    public class Policy_07
//    {
//        public string title { get; set; }
//        public Paragraph_Data16 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data16
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_17
//    {
//        public string title { get; set; }
//        public Paragraph_Data17 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data17
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_21
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary8 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details8 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data4 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information8 important_information { get; set; }
//    }

//    public class Details_Summary8
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details8
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data8 night_price_data { get; set; }
//    }

//    public class Night_Price_Data8
//    {
//        public Night_Price_08 night_price_0 { get; set; }
//        public Night_Price_18 night_price_1 { get; set; }
//        public Night_Price_28 night_price_2 { get; set; }
//        public Night_Price_38 night_price_3 { get; set; }
//        public Night_Price_48 night_price_4 { get; set; }
//    }

//    public class Night_Price_08
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_18
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_28
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_38
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_48
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data4
//    {
//        public Promo_04 promo_0 { get; set; }
//    }

//    public class Promo_04
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information8
//    {
//        public Policy_08 policy_0 { get; set; }
//        public Policy_18 policy_1 { get; set; }
//    }

//    public class Policy_08
//    {
//        public string title { get; set; }
//        public Paragraph_Data18 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data18
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_18
//    {
//        public string title { get; set; }
//        public Paragraph_Data19 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data19
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_31
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary9 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details9 price_details { get; set; }
//        public Plugin_Data2 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information9 important_information { get; set; }
//    }

//    public class Details_Summary9
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details9
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data9 night_price_data { get; set; }
//    }

//    public class Night_Price_Data9
//    {
//        public Night_Price_09 night_price_0 { get; set; }
//        public Night_Price_19 night_price_1 { get; set; }
//        public Night_Price_29 night_price_2 { get; set; }
//        public Night_Price_39 night_price_3 { get; set; }
//        public Night_Price_49 night_price_4 { get; set; }
//    }

//    public class Night_Price_09
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_19
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_29
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_39
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_49
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data2
//    {
//        public Aaa2 aaa { get; set; }
//    }

//    public class Aaa2
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information9
//    {
//        public Policy_09 policy_0 { get; set; }
//        public Policy_19 policy_1 { get; set; }
//        public Policy_22 policy_2 { get; set; }
//    }

//    public class Policy_09
//    {
//        public string title { get; set; }
//        public Paragraph_Data20 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data20
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_19
//    {
//        public string title { get; set; }
//        public Paragraph_Data21 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data21
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_22
//    {
//        public string title { get; set; }
//        public Paragraph_Data22 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data22
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_41
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary10 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details10 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data5 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information10 important_information { get; set; }
//    }

//    public class Details_Summary10
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details10
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public int source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public int display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data10 night_price_data { get; set; }
//    }

//    public class Night_Price_Data10
//    {
//        public Night_Price_010 night_price_0 { get; set; }
//        public Night_Price_110 night_price_1 { get; set; }
//        public Night_Price_210 night_price_2 { get; set; }
//        public Night_Price_310 night_price_3 { get; set; }
//        public Night_Price_410 night_price_4 { get; set; }
//    }

//    public class Night_Price_010
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_110
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_210
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_310
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_410
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data5
//    {
//        public Promo_05 promo_0 { get; set; }
//    }

//    public class Promo_05
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information10
//    {
//        public Policy_010 policy_0 { get; set; }
//        public Policy_110 policy_1 { get; set; }
//    }

//    public class Policy_010
//    {
//        public string title { get; set; }
//        public Paragraph_Data23 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data23
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_110
//    {
//        public string title { get; set; }
//        public Paragraph_Data24 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data24
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_51
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary11 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details11 price_details { get; set; }
//        public Plugin_Data3 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information11 important_information { get; set; }
//    }

//    public class Details_Summary11
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details11
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data11 night_price_data { get; set; }
//    }

//    public class Night_Price_Data11
//    {
//        public Night_Price_011 night_price_0 { get; set; }
//        public Night_Price_111 night_price_1 { get; set; }
//        public Night_Price_211 night_price_2 { get; set; }
//        public Night_Price_311 night_price_3 { get; set; }
//        public Night_Price_411 night_price_4 { get; set; }
//    }

//    public class Night_Price_011
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_111
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_211
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_311
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_411
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data3
//    {
//        public Aaa3 aaa { get; set; }
//    }

//    public class Aaa3
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information11
//    {
//        public Policy_011 policy_0 { get; set; }
//        public Policy_111 policy_1 { get; set; }
//        public Policy_23 policy_2 { get; set; }
//    }

//    public class Policy_011
//    {
//        public string title { get; set; }
//        public Paragraph_Data25 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data25
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_111
//    {
//        public string title { get; set; }
//        public Paragraph_Data26 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data26
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_23
//    {
//        public string title { get; set; }
//        public Paragraph_Data27 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data27
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_6
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary12 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details12 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data6 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information12 important_information { get; set; }
//    }

//    public class Details_Summary12
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details12
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data12 night_price_data { get; set; }
//    }

//    public class Night_Price_Data12
//    {
//        public Night_Price_012 night_price_0 { get; set; }
//        public Night_Price_112 night_price_1 { get; set; }
//        public Night_Price_212 night_price_2 { get; set; }
//        public Night_Price_312 night_price_3 { get; set; }
//        public Night_Price_412 night_price_4 { get; set; }
//    }

//    public class Night_Price_012
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_112
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_212
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_312
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_412
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data6
//    {
//        public Promo_06 promo_0 { get; set; }
//    }

//    public class Promo_06
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information12
//    {
//        public Policy_012 policy_0 { get; set; }
//        public Policy_112 policy_1 { get; set; }
//    }

//    public class Policy_012
//    {
//        public string title { get; set; }
//        public Paragraph_Data28 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data28
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_112
//    {
//        public string title { get; set; }
//        public Paragraph_Data29 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data29
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_7
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary13 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details13 price_details { get; set; }
//        public Plugin_Data4 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information13 important_information { get; set; }
//    }

//    public class Details_Summary13
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details13
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data13 night_price_data { get; set; }
//    }

//    public class Night_Price_Data13
//    {
//        public Night_Price_013 night_price_0 { get; set; }
//        public Night_Price_113 night_price_1 { get; set; }
//        public Night_Price_213 night_price_2 { get; set; }
//        public Night_Price_313 night_price_3 { get; set; }
//        public Night_Price_413 night_price_4 { get; set; }
//    }

//    public class Night_Price_013
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_113
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_213
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_313
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_413
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data4
//    {
//        public Aaa4 aaa { get; set; }
//    }

//    public class Aaa4
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information13
//    {
//        public Policy_013 policy_0 { get; set; }
//        public Policy_113 policy_1 { get; set; }
//        public Policy_24 policy_2 { get; set; }
//    }

//    public class Policy_013
//    {
//        public string title { get; set; }
//        public Paragraph_Data30 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data30
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_113
//    {
//        public string title { get; set; }
//        public Paragraph_Data31 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data31
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_24
//    {
//        public string title { get; set; }
//        public Paragraph_Data32 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data32
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_8
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary14 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details14 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data7 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information14 important_information { get; set; }
//    }

//    public class Details_Summary14
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details14
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public int source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public int display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data14 night_price_data { get; set; }
//    }

//    public class Night_Price_Data14
//    {
//        public Night_Price_014 night_price_0 { get; set; }
//        public Night_Price_114 night_price_1 { get; set; }
//        public Night_Price_214 night_price_2 { get; set; }
//        public Night_Price_314 night_price_3 { get; set; }
//        public Night_Price_414 night_price_4 { get; set; }
//    }

//    public class Night_Price_014
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_114
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_214
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_314
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_414
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data7
//    {
//        public Promo_07 promo_0 { get; set; }
//    }

//    public class Promo_07
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information14
//    {
//        public Policy_014 policy_0 { get; set; }
//        public Policy_114 policy_1 { get; set; }
//    }

//    public class Policy_014
//    {
//        public string title { get; set; }
//        public Paragraph_Data33 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data33
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_114
//    {
//        public string title { get; set; }
//        public Paragraph_Data34 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data34
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_9
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary15 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details15 price_details { get; set; }
//        public Plugin_Data5 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information15 important_information { get; set; }
//    }

//    public class Details_Summary15
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details15
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data15 night_price_data { get; set; }
//    }

//    public class Night_Price_Data15
//    {
//        public Night_Price_015 night_price_0 { get; set; }
//        public Night_Price_115 night_price_1 { get; set; }
//        public Night_Price_215 night_price_2 { get; set; }
//        public Night_Price_315 night_price_3 { get; set; }
//        public Night_Price_415 night_price_4 { get; set; }
//    }

//    public class Night_Price_015
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_115
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_215
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_315
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_415
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data5
//    {
//        public Aaa5 aaa { get; set; }
//    }

//    public class Aaa5
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information15
//    {
//        public Policy_015 policy_0 { get; set; }
//        public Policy_115 policy_1 { get; set; }
//        public Policy_25 policy_2 { get; set; }
//    }

//    public class Policy_015
//    {
//        public string title { get; set; }
//        public Paragraph_Data35 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data35
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_115
//    {
//        public string title { get; set; }
//        public Paragraph_Data36 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data36
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_25
//    {
//        public string title { get; set; }
//        public Paragraph_Data37 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data37
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_10
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary16 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details16 price_details { get; set; }
//        public Plugin_Data6 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information16 important_information { get; set; }
//    }

//    public class Details_Summary16
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details16
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public int source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public int display_total { get; set; }
//        public Night_Price_Data16 night_price_data { get; set; }
//    }

//    public class Night_Price_Data16
//    {
//        public Night_Price_016 night_price_0 { get; set; }
//        public Night_Price_116 night_price_1 { get; set; }
//        public Night_Price_216 night_price_2 { get; set; }
//        public Night_Price_316 night_price_3 { get; set; }
//        public Night_Price_416 night_price_4 { get; set; }
//    }

//    public class Night_Price_016
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_116
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_216
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_316
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_416
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data6
//    {
//        public Aaa6 aaa { get; set; }
//    }

//    public class Aaa6
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information16
//    {
//        public Policy_016 policy_0 { get; set; }
//        public Policy_116 policy_1 { get; set; }
//        public Policy_26 policy_2 { get; set; }
//    }

//    public class Policy_016
//    {
//        public string title { get; set; }
//        public Paragraph_Data38 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data38
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_116
//    {
//        public string title { get; set; }
//        public Paragraph_Data39 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data39
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_26
//    {
//        public string title { get; set; }
//        public Paragraph_Data40 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data40
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_111
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary17 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details17 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information17 important_information { get; set; }
//    }

//    public class Details_Summary17
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details17
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data17 night_price_data { get; set; }
//    }

//    public class Night_Price_Data17
//    {
//        public Night_Price_017 night_price_0 { get; set; }
//        public Night_Price_117 night_price_1 { get; set; }
//        public Night_Price_217 night_price_2 { get; set; }
//        public Night_Price_317 night_price_3 { get; set; }
//        public Night_Price_417 night_price_4 { get; set; }
//    }

//    public class Night_Price_017
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_117
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_217
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_317
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_417
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information17
//    {
//        public Policy_017 policy_0 { get; set; }
//        public Policy_117 policy_1 { get; set; }
//    }

//    public class Policy_017
//    {
//        public string title { get; set; }
//        public Paragraph_Data41 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data41
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_117
//    {
//        public string title { get; set; }
//        public Paragraph_Data42 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data42
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_12
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary18 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details18 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information18 important_information { get; set; }
//    }

//    public class Details_Summary18
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details18
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data18 night_price_data { get; set; }
//    }

//    public class Night_Price_Data18
//    {
//        public Night_Price_018 night_price_0 { get; set; }
//        public Night_Price_118 night_price_1 { get; set; }
//        public Night_Price_218 night_price_2 { get; set; }
//        public Night_Price_318 night_price_3 { get; set; }
//        public Night_Price_418 night_price_4 { get; set; }
//    }

//    public class Night_Price_018
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_118
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_218
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_318
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_418
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information18
//    {
//        public Policy_018 policy_0 { get; set; }
//        public Policy_118 policy_1 { get; set; }
//    }

//    public class Policy_018
//    {
//        public string title { get; set; }
//        public Paragraph_Data43 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data43
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_118
//    {
//        public string title { get; set; }
//        public Paragraph_Data44 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data44
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_13
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary19 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details19 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information19 important_information { get; set; }
//    }

//    public class Details_Summary19
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details19
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public float source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public float display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data19 night_price_data { get; set; }
//    }

//    public class Night_Price_Data19
//    {
//        public Night_Price_019 night_price_0 { get; set; }
//        public Night_Price_119 night_price_1 { get; set; }
//        public Night_Price_219 night_price_2 { get; set; }
//        public Night_Price_319 night_price_3 { get; set; }
//        public Night_Price_419 night_price_4 { get; set; }
//    }

//    public class Night_Price_019
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_119
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_219
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_319
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_419
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information19
//    {
//        public Policy_019 policy_0 { get; set; }
//        public Policy_119 policy_1 { get; set; }
//    }

//    public class Policy_019
//    {
//        public string title { get; set; }
//        public Paragraph_Data45 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data45
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_119
//    {
//        public string title { get; set; }
//        public Paragraph_Data46 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data46
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Hotel_2
//    {
//        public int id { get; set; }
//        public string check_in_time { get; set; }
//        public string check_out_time { get; set; }
//        public Rate_Data2 rate_data { get; set; }
//    }

//    public class Rate_Data2
//    {
//        public Rate_02 rate_0 { get; set; }
//        public Rate_14 rate_1 { get; set; }
//        public Rate_22 rate_2 { get; set; }
//        public Rate_32 rate_3 { get; set; }
//        public Rate_42 rate_4 { get; set; }
//        public Rate_52 rate_5 { get; set; }
//        public Rate_61 rate_6 { get; set; }
//        public Rate_71 rate_7 { get; set; }
//        public Rate_81 rate_8 { get; set; }
//        public Rate_91 rate_9 { get; set; }
//        public Rate_101 rate_10 { get; set; }
//        public Rate_112 rate_11 { get; set; }
//        public Rate_121 rate_12 { get; set; }
//    }

//    public class Rate_02
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary20 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details20 price_details { get; set; }
//        public Plugin_Data7 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information20 important_information { get; set; }
//    }

//    public class Details_Summary20
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details20
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public int source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public int display_total { get; set; }
//        public Night_Price_Data20 night_price_data { get; set; }
//    }

//    public class Night_Price_Data20
//    {
//        public Night_Price_020 night_price_0 { get; set; }
//        public Night_Price_120 night_price_1 { get; set; }
//        public Night_Price_220 night_price_2 { get; set; }
//        public Night_Price_320 night_price_3 { get; set; }
//        public Night_Price_420 night_price_4 { get; set; }
//    }

//    public class Night_Price_020
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_120
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_220
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_320
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_420
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data7
//    {
//        public Aaa7 aaa { get; set; }
//    }

//    public class Aaa7
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information20
//    {
//        public Policy_020 policy_0 { get; set; }
//        public Policy_120 policy_1 { get; set; }
//        public Policy_27 policy_2 { get; set; }
//    }

//    public class Policy_020
//    {
//        public string title { get; set; }
//        public Paragraph_Data47 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data47
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_120
//    {
//        public string title { get; set; }
//        public Paragraph_Data48 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data48
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_27
//    {
//        public string title { get; set; }
//        public Paragraph_Data49 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data49
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_14
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary21 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details21 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data8 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information21 important_information { get; set; }
//    }

//    public class Details_Summary21
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details21
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data21 night_price_data { get; set; }
//    }

//    public class Night_Price_Data21
//    {
//        public Night_Price_021 night_price_0 { get; set; }
//        public Night_Price_121 night_price_1 { get; set; }
//        public Night_Price_221 night_price_2 { get; set; }
//        public Night_Price_321 night_price_3 { get; set; }
//        public Night_Price_421 night_price_4 { get; set; }
//    }

//    public class Night_Price_021
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_121
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_221
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_321
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_421
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data8
//    {
//        public Promo_08 promo_0 { get; set; }
//    }

//    public class Promo_08
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information21
//    {
//        public Policy_021 policy_0 { get; set; }
//        public Policy_121 policy_1 { get; set; }
//    }

//    public class Policy_021
//    {
//        public string title { get; set; }
//        public Paragraph_Data50 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data50
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_121
//    {
//        public string title { get; set; }
//        public Paragraph_Data51 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data51
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_22
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary22 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details22 price_details { get; set; }
//        public Plugin_Data8 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information22 important_information { get; set; }
//    }

//    public class Details_Summary22
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details22
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data22 night_price_data { get; set; }
//    }

//    public class Night_Price_Data22
//    {
//        public Night_Price_022 night_price_0 { get; set; }
//        public Night_Price_122 night_price_1 { get; set; }
//        public Night_Price_222 night_price_2 { get; set; }
//        public Night_Price_322 night_price_3 { get; set; }
//        public Night_Price_422 night_price_4 { get; set; }
//    }

//    public class Night_Price_022
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_122
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_222
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_322
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_422
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data8
//    {
//        public Aaa8 aaa { get; set; }
//    }

//    public class Aaa8
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information22
//    {
//        public Policy_022 policy_0 { get; set; }
//        public Policy_122 policy_1 { get; set; }
//        public Policy_28 policy_2 { get; set; }
//    }

//    public class Policy_022
//    {
//        public string title { get; set; }
//        public Paragraph_Data52 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data52
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_122
//    {
//        public string title { get; set; }
//        public Paragraph_Data53 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data53
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_28
//    {
//        public string title { get; set; }
//        public Paragraph_Data54 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data54
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_32
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary23 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details23 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data9 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information23 important_information { get; set; }
//    }

//    public class Details_Summary23
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details23
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data23 night_price_data { get; set; }
//    }

//    public class Night_Price_Data23
//    {
//        public Night_Price_023 night_price_0 { get; set; }
//        public Night_Price_123 night_price_1 { get; set; }
//        public Night_Price_223 night_price_2 { get; set; }
//        public Night_Price_323 night_price_3 { get; set; }
//        public Night_Price_423 night_price_4 { get; set; }
//    }

//    public class Night_Price_023
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_123
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_223
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_323
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_423
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data9
//    {
//        public Promo_09 promo_0 { get; set; }
//    }

//    public class Promo_09
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information23
//    {
//        public Policy_023 policy_0 { get; set; }
//        public Policy_123 policy_1 { get; set; }
//    }

//    public class Policy_023
//    {
//        public string title { get; set; }
//        public Paragraph_Data55 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data55
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_123
//    {
//        public string title { get; set; }
//        public Paragraph_Data56 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data56
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_42
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary24 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details24 price_details { get; set; }
//        public Plugin_Data9 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information24 important_information { get; set; }
//    }

//    public class Details_Summary24
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details24
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data24 night_price_data { get; set; }
//    }

//    public class Night_Price_Data24
//    {
//        public Night_Price_024 night_price_0 { get; set; }
//        public Night_Price_124 night_price_1 { get; set; }
//        public Night_Price_224 night_price_2 { get; set; }
//        public Night_Price_324 night_price_3 { get; set; }
//        public Night_Price_424 night_price_4 { get; set; }
//    }

//    public class Night_Price_024
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_124
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_224
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_324
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_424
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data9
//    {
//        public Aaa9 aaa { get; set; }
//    }

//    public class Aaa9
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information24
//    {
//        public Policy_024 policy_0 { get; set; }
//        public Policy_124 policy_1 { get; set; }
//        public Policy_29 policy_2 { get; set; }
//    }

//    public class Policy_024
//    {
//        public string title { get; set; }
//        public Paragraph_Data57 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data57
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_124
//    {
//        public string title { get; set; }
//        public Paragraph_Data58 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data58
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_29
//    {
//        public string title { get; set; }
//        public Paragraph_Data59 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data59
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_52
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary25 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details25 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information25 important_information { get; set; }
//    }

//    public class Details_Summary25
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details25
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data25 night_price_data { get; set; }
//    }

//    public class Night_Price_Data25
//    {
//        public Night_Price_025 night_price_0 { get; set; }
//        public Night_Price_125 night_price_1 { get; set; }
//        public Night_Price_225 night_price_2 { get; set; }
//        public Night_Price_325 night_price_3 { get; set; }
//        public Night_Price_425 night_price_4 { get; set; }
//    }

//    public class Night_Price_025
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_125
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_225
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_325
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_425
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information25
//    {
//        public Policy_025 policy_0 { get; set; }
//        public Policy_125 policy_1 { get; set; }
//    }

//    public class Policy_025
//    {
//        public string title { get; set; }
//        public Paragraph_Data60 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data60
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_125
//    {
//        public string title { get; set; }
//        public Paragraph_Data61 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data61
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_61
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary26 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details26 price_details { get; set; }
//        public Plugin_Data10 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information26 important_information { get; set; }
//    }

//    public class Details_Summary26
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details26
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data26 night_price_data { get; set; }
//    }

//    public class Night_Price_Data26
//    {
//        public Night_Price_026 night_price_0 { get; set; }
//        public Night_Price_126 night_price_1 { get; set; }
//        public Night_Price_226 night_price_2 { get; set; }
//        public Night_Price_326 night_price_3 { get; set; }
//        public Night_Price_426 night_price_4 { get; set; }
//    }

//    public class Night_Price_026
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_126
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_226
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_326
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_426
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data10
//    {
//        public Aaa10 aaa { get; set; }
//    }

//    public class Aaa10
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information26
//    {
//        public Policy_026 policy_0 { get; set; }
//        public Policy_126 policy_1 { get; set; }
//        public Policy_210 policy_2 { get; set; }
//    }

//    public class Policy_026
//    {
//        public string title { get; set; }
//        public Paragraph_Data62 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data62
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_126
//    {
//        public string title { get; set; }
//        public Paragraph_Data63 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data63
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_210
//    {
//        public string title { get; set; }
//        public Paragraph_Data64 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data64
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_71
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary27 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details27 price_details { get; set; }
//        public Plugin_Data11 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information27 important_information { get; set; }
//    }

//    public class Details_Summary27
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details27
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data27 night_price_data { get; set; }
//    }

//    public class Night_Price_Data27
//    {
//        public Night_Price_027 night_price_0 { get; set; }
//        public Night_Price_127 night_price_1 { get; set; }
//        public Night_Price_227 night_price_2 { get; set; }
//        public Night_Price_327 night_price_3 { get; set; }
//        public Night_Price_427 night_price_4 { get; set; }
//    }

//    public class Night_Price_027
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_127
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_227
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_327
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_427
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data11
//    {
//        public Aaa11 aaa { get; set; }
//    }

//    public class Aaa11
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information27
//    {
//        public Policy_027 policy_0 { get; set; }
//        public Policy_127 policy_1 { get; set; }
//        public Policy_211 policy_2 { get; set; }
//    }

//    public class Policy_027
//    {
//        public string title { get; set; }
//        public Paragraph_Data65 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data65
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_127
//    {
//        public string title { get; set; }
//        public Paragraph_Data66 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data66
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_211
//    {
//        public string title { get; set; }
//        public Paragraph_Data67 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data67
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_81
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary28 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details28 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information28 important_information { get; set; }
//    }

//    public class Details_Summary28
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details28
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data28 night_price_data { get; set; }
//    }

//    public class Night_Price_Data28
//    {
//        public Night_Price_028 night_price_0 { get; set; }
//        public Night_Price_128 night_price_1 { get; set; }
//        public Night_Price_228 night_price_2 { get; set; }
//        public Night_Price_328 night_price_3 { get; set; }
//        public Night_Price_428 night_price_4 { get; set; }
//    }

//    public class Night_Price_028
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_128
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_228
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_328
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_428
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information28
//    {
//        public Policy_028 policy_0 { get; set; }
//        public Policy_128 policy_1 { get; set; }
//    }

//    public class Policy_028
//    {
//        public string title { get; set; }
//        public Paragraph_Data68 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data68
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_128
//    {
//        public string title { get; set; }
//        public Paragraph_Data69 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data69
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_91
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary29 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details29 price_details { get; set; }
//        public Plugin_Data12 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information29 important_information { get; set; }
//    }

//    public class Details_Summary29
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details29
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public int source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public int display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data29 night_price_data { get; set; }
//    }

//    public class Night_Price_Data29
//    {
//        public Night_Price_029 night_price_0 { get; set; }
//        public Night_Price_129 night_price_1 { get; set; }
//        public Night_Price_229 night_price_2 { get; set; }
//        public Night_Price_329 night_price_3 { get; set; }
//        public Night_Price_429 night_price_4 { get; set; }
//    }

//    public class Night_Price_029
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_129
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_229
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_329
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_429
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data12
//    {
//        public Aaa12 aaa { get; set; }
//    }

//    public class Aaa12
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information29
//    {
//        public Policy_029 policy_0 { get; set; }
//        public Policy_129 policy_1 { get; set; }
//        public Policy_212 policy_2 { get; set; }
//    }

//    public class Policy_029
//    {
//        public string title { get; set; }
//        public Paragraph_Data70 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data70
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_129
//    {
//        public string title { get; set; }
//        public Paragraph_Data71 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data71
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_212
//    {
//        public string title { get; set; }
//        public Paragraph_Data72 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data72
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_101
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary30 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details30 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public Promo_Data10 promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information30 important_information { get; set; }
//    }

//    public class Details_Summary30
//    {
//        public string book_policy { get; set; }
//        public string promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details30
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data30 night_price_data { get; set; }
//    }

//    public class Night_Price_Data30
//    {
//        public Night_Price_030 night_price_0 { get; set; }
//        public Night_Price_130 night_price_1 { get; set; }
//        public Night_Price_230 night_price_2 { get; set; }
//        public Night_Price_330 night_price_3 { get; set; }
//        public Night_Price_430 night_price_4 { get; set; }
//    }

//    public class Night_Price_030
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_130
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_230
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_330
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_430
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Promo_Data10
//    {
//        public Promo_010 promo_0 { get; set; }
//    }

//    public class Promo_010
//    {
//        public object id { get; set; }
//        public string title { get; set; }
//        public string description { get; set; }
//        public string type { get; set; }
//        public string terms { get; set; }
//        public string discount_type { get; set; }
//        public int description_required { get; set; }
//        public object discount_merchandising { get; set; }
//        public object advanced_purchase { get; set; }
//        public string source_strikeout_price { get; set; }
//        public string display_strikeout_price { get; set; }
//    }

//    public class Important_Information30
//    {
//        public Policy_030 policy_0 { get; set; }
//        public Policy_130 policy_1 { get; set; }
//    }

//    public class Policy_030
//    {
//        public string title { get; set; }
//        public Paragraph_Data73 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data73
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_130
//    {
//        public string title { get; set; }
//        public Paragraph_Data74 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data74
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_112
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary31 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details31 price_details { get; set; }
//        public Plugin_Data13 plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information31 important_information { get; set; }
//    }

//    public class Details_Summary31
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public object refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details31
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data31 night_price_data { get; set; }
//    }

//    public class Night_Price_Data31
//    {
//        public Night_Price_031 night_price_0 { get; set; }
//        public Night_Price_131 night_price_1 { get; set; }
//        public Night_Price_231 night_price_2 { get; set; }
//        public Night_Price_331 night_price_3 { get; set; }
//        public Night_Price_431 night_price_4 { get; set; }
//    }

//    public class Night_Price_031
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_131
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_231
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_331
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_431
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Plugin_Data13
//    {
//        public Aaa13 aaa { get; set; }
//    }

//    public class Aaa13
//    {
//        public string hot_rate { get; set; }
//    }

//    public class Important_Information31
//    {
//        public Policy_031 policy_0 { get; set; }
//        public Policy_131 policy_1 { get; set; }
//        public Policy_213 policy_2 { get; set; }
//    }

//    public class Policy_031
//    {
//        public string title { get; set; }
//        public Paragraph_Data75 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data75
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_131
//    {
//        public string title { get; set; }
//        public Paragraph_Data76 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data76
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_213
//    {
//        public string title { get; set; }
//        public Paragraph_Data77 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data77
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Rate_121
//    {
//        public string source { get; set; }
//        public string rate_type { get; set; }
//        public string rate_plan_code { get; set; }
//        public object rooms_available { get; set; }
//        public int occupancy_limit { get; set; }
//        public string description { get; set; }
//        public Details_Summary32 details_summary { get; set; }
//        public int pre_paid { get; set; }
//        public int deposit_required { get; set; }
//        public object guarantee_required { get; set; }
//        public string ppn_bundle { get; set; }
//        public string title { get; set; }
//        public Price_Details32 price_details { get; set; }
//        public object plugin_data { get; set; }
//        public object promo_data { get; set; }
//        public string thumbnail { get; set; }
//        public object[] photo_data { get; set; }
//        public object[] facility_data { get; set; }
//        public Important_Information32 important_information { get; set; }
//    }

//    public class Details_Summary32
//    {
//        public string book_policy { get; set; }
//        public object promo { get; set; }
//        public string refund_policy { get; set; }
//        public int is_cancellable { get; set; }
//    }

//    public class Price_Details32
//    {
//        public string source_currency { get; set; }
//        public string source_symbol { get; set; }
//        public float source_price { get; set; }
//        public object source_processing_fee { get; set; }
//        public object source_insurance_fee { get; set; }
//        public object source_property_fee { get; set; }
//        public float source_taxes { get; set; }
//        public float source_sub_total { get; set; }
//        public float source_total { get; set; }
//        public string display_currency { get; set; }
//        public string display_symbol { get; set; }
//        public float display_price { get; set; }
//        public object display_processing_fee { get; set; }
//        public object display_insurance_fee { get; set; }
//        public object display_property_fee { get; set; }
//        public float display_taxes { get; set; }
//        public float display_sub_total { get; set; }
//        public float display_total { get; set; }
//        public Night_Price_Data32 night_price_data { get; set; }
//    }

//    public class Night_Price_Data32
//    {
//        public Night_Price_032 night_price_0 { get; set; }
//        public Night_Price_132 night_price_1 { get; set; }
//        public Night_Price_232 night_price_2 { get; set; }
//        public Night_Price_332 night_price_3 { get; set; }
//        public Night_Price_432 night_price_4 { get; set; }
//    }

//    public class Night_Price_032
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_132
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_232
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_332
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Night_Price_432
//    {
//        public string source_night_price { get; set; }
//        public string display_night_price { get; set; }
//    }

//    public class Important_Information32
//    {
//        public Policy_032 policy_0 { get; set; }
//        public Policy_132 policy_1 { get; set; }
//    }

//    public class Policy_032
//    {
//        public string title { get; set; }
//        public Paragraph_Data78 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data78
//    {
//        public string paragraph_0 { get; set; }
//    }

//    public class Policy_132
//    {
//        public string title { get; set; }
//        public Paragraph_Data79 paragraph_data { get; set; }
//    }

//    public class Paragraph_Data79
//    {
//        public string paragraph_0 { get; set; }
//    }

//}
