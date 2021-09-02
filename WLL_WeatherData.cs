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
    public class WeatherDataWLL
    {
        [DataMember]
        //"station_id": 374964,
        public int? station_id { get; set; }
        [DataMember]
        //"sensors": [...],
        public List<Sensors> sensors { get; set; }
        //"generated_at": 1558741957
        public int? generated_at { get; set; }
    }

    // "sensors":[{
    public class Sensors
    {
        // "lsid": 5271273,
        public int? lsid { get; set; }
        // "sensor_type": 45,
        public int? sensor_type { get; set; }
        // "data_structure_type" :10 (WeatherLink current conditions)
        public int? data_structure_type { get; set; }
        // "data": [
        public List<Data> data { get; set; }
    }

    // "data":[{
    public class Data
    {
        // "ts": 1558741927,
        public int? ts { get; set; }
        // "tx_id": 1,
        public int? tx_id { get; set; }
        // "wind_speed_hi_last_2_min": 5,
        public double? wind_speed_hi_last_2_min { get; set; }
        // "hum": 42.7,
        public double? hum { get; set; }
        // "wind_dir_at_hi_speed_last_10_min": 260,
        public int? wind_dir_at_hi_speed_last_10_min { get; set; }
        // "wind_chill": 73.3,
        public double? wind_chill { get; set; }
        // "rain_rate_hi_last_15_min_clicks": 0,
        public double? rain_rate_hi_last_15_min_clicks { get; set; }
        // "thw_index": 72.2,
        public int? thw_index { get; set; }
        // "wind_dir_scalar_avg_last_10_min": 221,
        public int? wind_dir_scalar_avg_last_10_min { get; set; }
        // "rain_size": 1,
        public double? rain_size { get; set; }
        // "uv_index": 2.3,
        public int? uv_index { get; set; }
        // "wind_speed_last": 4,
        public int? wind_speed_last { get; set; }
        // "rainfall_last_60_min_clicks": 0,
        public double? rainfall_last_60_min_clicks { get; set; }
        // "wet_bulb": 55.8,
        public int? wet_bulb { get; set; }
        // "rainfall_monthly_clicks": 117,
        public double? rainfall_monthly_clicks { get; set; }
        // "wind_speed_avg_last_10_min": 3.56,
        public int? wind_speed_avg_last_10_min { get; set; }
        // "wind_dir_at_hi_speed_last_2_min": 225,
        public int? wind_dir_at_hi_speed_last_2_min { get; set; }
        // "rainfall_daily_in": 0,
        public int? rainfall_daily_in { get; set; }
        // "wind_dir_last": 195,
        public int? wind_dir_last { get; set; }
        // "rainfall_daily_mm": 0,
        public int? rainfall_daily_mm { get; set; }
        // "rain_storm_last_clicks": 22,
        public int? rain_storm_last_clicks { get; set; }
        // "rain_storm_last_start_at": 1558428061,
        public int? rain_storm_last_start_at { get; set; }
        // "rain_rate_hi_clicks": 0,
        public int? rain_rate_hi_clicks { get; set; }
        // "rainfall_last_15_min_in": 0,
        public int? rainfall_last_15_min_in { get; set; }
        // "rainfall_daily_clicks": 0,
        public double? rainfall_daily_clicks { get; set; }
        // "dew_point": 49.3,
        public int? dew_point { get; set; }
        // "rainfall_last_15_min_mm": 0,
        public int? rainfall_last_15_min_mm { get; set; }
        // "rain_rate_hi_in": 0,
        public int? rain_rate_hi_in { get; set; }
        // "rain_storm_clicks": 0,
        public int? rain_storm_clicks { get; set; }
        // "rain_rate_hi_mm": 0,
        public int? rain_rate_hi_mm { get; set; }
        // "rainfall_year_clicks": 117,
        public int? rainfall_year_clicks { get; set; }
        // "rain_storm_in": 0,
        public int? rain_storm_in { get; set; }
        // "rain_storm_last_end_at": 1558576860,
        public int? rain_storm_last_end_at { get; set; }
        // "rain_storm_mm": 0,
        public int? rain_storm_mm { get; set; }
        // "wind_dir_scalar_avg_last_2_min": 222,
        public double? wind_dir_scalar_avg_last_2_min { get; set; }
        // "heat_index": 72.2,
        public int? heat_index { get; set; }
        // "rainfall_last_24_hr_in": 0,
        public int? rainfall_last_24_hr_in { get; set; }
        // "rainfall_last_60_min_mm": 0,
        public int? rainfall_last_60_min_mm { get; set; }
        // "rainfall_last_60_min_in": 0,
        public int? rainfall_last_60_min_in { get; set; }
        // "rain_storm_start_time": null,
        public int? rain_storm_start_time { get; set; }
        // "rainfall_last_24_hr_mm": 0,
        public double? rainfall_last_24_hr_mm { get; set; }
        // "rainfall_year_in": 1.17,
        public int? rainfall_year_in { get; set; }
        // "wind_speed_hi_last_10_min": 6,
        public int? wind_speed_hi_last_10_min { get; set; }
        // "rainfall_last_15_min_clicks": 0,
        public double? rainfall_last_15_min_clicks { get; set; }
        // "rainfall_year_mm": 29.718,
        public int? rainfall_year_mm { get; set; }
        // "wind_dir_scalar_avg_last_1_min": 214,
        public double? wind_dir_scalar_avg_last_1_min { get; set; }
        // "temp": 42.7,
        public double? temp { get; set; }
        // "wind_speed_avg_last_2_min": 3.18,
        public int? wind_speed_avg_last_2_min { get; set; }
        // "solar_rad": 598,
        public double? solar_rad { get; set; }
        // "rainfall_monthly_mm": 29.718,
        public double? rainfall_monthly_mm { get; set; }
        // "rain_storm_last_mm": 5.588,
        public double? rain_storm_last_mm { get; set; }
        // "wind_speed_avg_last_1_min": 3.37,
        public double? wind_speed_avg_last_1_min { get; set; }
        // "thsw_index": 72.6,
        public double? thsw_index { get; set; }
        // "rainfall_monthly_in": 1.17,
        public int? rainfall_monthly_in { get; set; }
        // "rain_rate_last_mm": 0,
        public int? rain_rate_last_mm { get; set; }
        // "rain_rate_last_clicks": 0,
        public int? rain_rate_last_clicks { get; set; }
        // "rainfall_last_24_hr_clicks": 0,
        public double? rainfall_last_24_hr_clicks { get; set; }
        // "rain_storm_last_in": 0.22,
        public int? rain_storm_last_in { get; set; }
        // "rain_rate_last_in": 0,
        public int? rain_rate_last_in { get; set; }
        // "rain_rate_hi_last_15_min_mm": 0,
        public int? rain_rate_hi_last_15_min_mm { get; set; }
        // "rain_rate_hi_last_15_min_in": 0
        public int? rain_rate_hi_last_15_min_in { get; set; }
    }
}