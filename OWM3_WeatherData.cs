using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ASCOM.MyCloudPWS
{
    //
    // This is the list of recent measurements
    //
    [DataContract]
    public class WeatherDataOWM3
    {
        [DataMember]
        //[{
        public List<WeatherDataOWM3> observations { get; set; }
        [DataMember]
        //"type":"m",
        public string type { get; set; }
        [DataMember]
        //"date":1629159120,
        public int? date { get; set; }
        [DataMember]
        //"station_id":"611af1b709e7430001b9fa6c",
        public string station_id { get; set; }
        [DataMember]
        //"temp":{"max":34.3,"min":34.3,"average":34.3,"weight":1},
        public TempOWM3 temp { get; set; }
        [DataMember]
        //"humidity":{ "average":45,"weight":1},
        public HumidityOWM3 humidity { get; set; }
        [DataMember]
        //"wind":{ "deg":203,"speed":1},
        public WindOWM3 wind { get; set; }
        [DataMember]
        //"pressure":{ "min":1
        public PressureOWM3 pressure { get; set; }
        [DataMember]
        //"precipitation":{ }}]
        public double precipitation { get; set; }
    }

    //"temp":{"max":34.3,"min":34.3,"average":34.3,"weight":1},
    public class TempOWM3
    {
        // "max":34.3,
        public double? max { get; set; }
        // "min":34.3,
        public double? min { get; set; }
        // "average":34.3,
        public double? average { get; set; }
        // "weight":1
        public int? weight { get; set; }
    }

    //"humidity":{ "average":45,"weight":1},
    public class HumidityOWM3
    {
        // "average":45,
        public double? average { get; set; }
        // "weight":1
        public int? weight { get; set; }
    }

    //"wind":{ "deg":203,"speed":1},
    public class WindOWM3
    {
        // "deg":203,
        public int? deg { get; set; }
        // "speed":1
        public int? speed { get; set; }
    }

    //"pressure":{ "min":1
    public class PressureOWM3
    {
        // "min":34.3,
        public int? min { get; set; }
    }
}