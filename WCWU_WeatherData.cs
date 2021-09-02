using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

//
// Data Structure
//

namespace ASCOM.MyCloudPWS
{
    [DataContract]
    public class WeatherDataWCWU
    {
        [DataMember]
        //  "observations":[{
        public List<Observations> observations { get; set; }
    }
    public class Observations
    {
        //[DataMember]
        //      "stationID": "KAZTUCSO2296",
        public string stationID { get; set; }
        //      "obsTimeUtc": "2021-08-21T01:39:39Z",
        public string obsTimeUtc { get; set; }
        //      "obsTimeLocal": "2021-08-20 18:39:39",
        public string obsTimeLocal { get; set; }
        //      "neighborhood": "Catalina Foothills",
        public string neighborhood { get; set; }
        //      "softwareType": "myAcuRite",
        public string softwareType { get; set; }
        //      "country": "US",
        public string country { get; set; }
        //      "solarRadiation": null,
        public bool? solarRadiation { get; set; }
        //      "lon": -110.854523,
        public double? lon { get; set; }
        //      "realtimeFrequency": null,
        public bool? realtimeFrequency { get; set; }
        //      "epoch": 1629509979,
        public int? epoch { get; set; }
        //      "lat": 32.28858,
        public double? lat { get; set; }
        //      "uv": null,
        public bool? uv { get; set; }
        //      "windDir": 225,
        public int? windDir { get; set; }
        //      "humidity": 35.0,
        public double? humidity { get; set; }
        //      "qcStatus": 1,
        public int? qcStatus { get; set; }

        //"imperial" or "metric": {
       //       public Measures imperial { get; set; }
        public Measures metric { get; set; }
    }
        public class Measures
    {
        //        "temp":282.53,
        public double? temp { get; set; }
        //        "heatIndex": 94.3,
        public double? heatIndex { get; set; }
        //       "dewPt": 61.0,
        public double? dewPt { get; set; }
        //        "windChill": 93.6,
        public double? windChill { get; set; }
        //        "windSpeed": 0.0,
        public double? windSpeed { get; set; }
        //        "windGust": 5.0,
        public double? windGust { get; set; }
        //        "pressure":996,
        public double? pressure { get; set; }
        //        "precipRate": 0.00,
        public double precipRate { get; set; }
        //        "precipTotal": 0.00,
        public double? precipTotal { get; set; }
        //        "elev": 2690.0
        public double? elev { get; set; }
        public int? cod { get; set; }
    }
}