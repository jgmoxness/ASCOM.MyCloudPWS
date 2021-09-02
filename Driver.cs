//tabs=4
// --------------------------------------------------------------------------------
// TODO fill in this information for your driver, then remove this line!
//
// ASCOM ObservingConditions driver for MyCloudPWS
//
// Description:	ASCOM ObservingConditions driver for the online WeatherChannel web site.
//              Weather Underground now uses WeatherChannels IBM Cloud to support user access.
//              The user must get an API code from Weather Underground -> WeatherChannel.
//              AcuRite Personal Weather Stations (PWSs) have built-in support for Weather Underground services.
//              I have added capability to refernce other web/cloud weather services as well (e.g. OpenWeatherMap)
//
// Implements:	ASCOM ObservingConditions interface version: 6.5
// Author:		(JGM) J Gregory Moxness <jgmoxness@TheoryOfEverything.org>
//
// Edit Log:
//
// Date			Who	Vers	Description
// -----------	---	-----	-------------------------------------------------------
// 23-Aug-2021	JGM	6.0.0	Initial edit, created from ASCOM driver template - WeatherChannel API uses PWS data from Wunderground
// --------------------------------------------------------------------------------
//
// This is used to define code in the template that is specific to one class implementation
// unused code can be deleted and this definition removed.
#define ObservingConditions

using ASCOM;
using ASCOM.Astrometry;
using ASCOM.Astrometry.AstroUtils;
using ASCOM.DeviceInterface;
using ASCOM.Utilities;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

//Manually added from C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Web.Extensions.dll
using System.Runtime.Serialization;
//Manually added from C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Runtime.Serialization.dll
using System.Runtime.Serialization.Json;
//Manually added from C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\Facades\System.Runtime.Serialization.Json.dll

namespace ASCOM.MyCloudPWS
{
    //
    // Your driver's DeviceID is ASCOM.MyCloudPWS.ObservingConditions
    //
    // The Guid attribute sets the CLSID for ASCOM.MyCloudPWS.ObservingConditions
    // The ClassInterface/None attribute prevents an empty interface called
    // _MyCloudPWS from being created and used as the [default] interface
    //
    // TODO Replace the not implemented exceptions with code to implement the function or
    // throw the appropriate ASCOM exception.
    //

    /// <summary>
    /// ASCOM ObservingConditions Driver for MyCloudPWS.
    /// </summary>
    [Guid("eee5f9d8-1d86-4604-a18a-c98a12555395")]
    [ClassInterface(ClassInterfaceType.None)]
    public class ObservingConditions : IObservingConditions
    {
        /// <summary>
        /// ASCOM DeviceID (COM ProgID) for this driver.
        /// The DeviceID is used by ASCOM applications to load the driver at runtime.
        /// </summary>
        internal static string driverID = "ASCOM.MyCloudPWS.ObservingConditions";
        /// <summary>
        /// Driver description that displays in the ASCOM Chooser.
        /// </summary>
        /// 

        private static string driverDescription = "ASCOM ObservingConditions Driver for MyCloudPWS.";

        internal static string comPortProfileName = "COM Port"; // Constants used for Profile persistence
        internal static string comPortDefault = "COM1";
        internal static string comPort; // Variables to hold the current device configuration
                                        // internal static string driverID = "ASCOM.MyCloudPWS.ObservingConditions";
        internal static string traceStateProfileName = "Trace Level";
        internal static string traceStateDefault = "False";
        internal static string traceState;

        internal static string myLocationType; 
        internal static string LocationTypeDefault = "stationIdWCWU"; // "0"

        internal static string stationIdWCWU { get; set; }
        internal static string stationIdOWM3 { get; set; }
        internal static string stationIdWLL { get; set; }
        internal static string ZipCode { get; set; }
        internal static string CityName { get; set; }
        internal static string CityId { get; set; }

        internal static string SiteLongitude { get; set; }
        internal static string SiteLatitude { get; set; }
        internal static string SiteElevation { get; set; }

        //internal static string units { get; set; }
        internal static string units = "m";
        //internal static string format { get; set; }
        internal static string format = "json";
        //internal static string numericPrecision { get; set; }
        internal static string numericPrecision = "decimal";
        //internal static string type { get; set; } // OWM3 time increments d, h, m
        internal static string type = "m";
        //internal static string limit { get; set; } // OWM3 record limit
        internal static string limit = "1";
        internal static string interval { get; set; } // minutes between updates and averaging
        //internal static string interval = "6"; 

        //internal static string apiUrlWCWU { get; set; }
        internal static string apiUrlWCWU = "https://api.weather.com/v2/pws/observations/current";
        internal static string apiKeyWCWU { get; set; }

        //internal static string apiUrlOWM { get; set; }
        internal static string apiUrlOWM = "https://api.openweathermap.org/data/2.5/weather";
        internal static string apiKeyOWM { get; set; }

        //internal static string apiUrlOWM3 { get; set; }
        internal static string apiUrlOWM3 = "https://api.openweathermap.org/data/3.0/measurements";

        //internal static string apiUrlWLL { get; set; }
        internal static string apiUrlWLL = "https://api.weatherlink.com/v2/current";
        internal static string apiKeyWLL { get; set; }
        internal static string apiSecretWLL { get; set; }

        internal static string apiKey = apiKeyWCWU;
        //internal static string apiKey = apiKeyOWM;

        /// Private variable to hold the connected state
        /// </summary>
        private bool connectedState;

        /// <summary>
        /// Private variable to hold an ASCOM Utilities object
        /// </summary>
        private Util utilities;

        /// <summary>
        /// Private variable to hold an ASCOM AstroUtilities object to provide the Range method
        /// </summary>
        private AstroUtils astroUtilities;

        /// <summary>
        /// Variable to hold the trace logger object (creates a diagnostic log file with information that you specify)
        /// </summary>
        internal TraceLogger tl;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyCloudPWS"/> class.
        /// Must be public for COM registration.
        /// </summary>
        /// 

        public ObservingConditions()
        {
            tl = new TraceLogger("", "MyCloudPWS");
            ReadProfile(); // Read device configuration from the ASCOM Profile store

            tl.LogMessage("ObservingConditions", "Starting initialisation");

            connectedState = false; // Initialise connected to false
            utilities = new Util(); //Initialise util object
            astroUtilities = new AstroUtils(); // Initialise astro-utilities object
            //TODO: Implement your additional construction here

            tl.LogMessage("ObservingConditions", "Completed initialisation");
        }

        //
        // PUBLIC COM INTERFACE IObservingConditions IMPLEMENTATION
        //

        #region Common properties and methods.

        /// <summary>
        /// Displays the Setup Dialog form.
        /// If the user clicks the OK button to dismiss the form, then
        /// the new settings are saved, otherwise the old values are reloaded.
        /// THIS IS THE ONLY PLACE WHERE SHOWING USER INTERFACE IS ALLOWED!
        /// </summary>

        public void SetupDialog()
        {
            // consider only showing the setup dialog if not connected
            // or call a different dialog if connected
            if (IsConnected)
                System.Windows.Forms.MessageBox.Show("Already connected, just press OK");

            using (SetupDialogForm F = new SetupDialogForm(tl))
            {
                var result = F.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    WriteProfile(); // Persist device configuration values to the ASCOM Profile store
                }
            }
        }

        public ArrayList SupportedActions
        {
            get
            {
                tl.LogMessage("SupportedActions Get", "Returning empty arraylist");
                return new ArrayList();
            }
        }

        public string Action(string actionName, string actionParameters)
        {
            LogMessage("", "Action {0}, parameters {1} not implemented", actionName, actionParameters);
            throw new ASCOM.ActionNotImplementedException("Action " + actionName + " is not implemented by this driver");
        }

        public void CommandBlind(string command, bool raw)
        {
            CheckConnected("CommandBlind");
            // TODO The optional CommandBlind method should either be implemented OR throw a MethodNotImplementedException
            // If implemented, CommandBlind must send the supplied command to the mount and return immediately without waiting for a response

            throw new ASCOM.MethodNotImplementedException("CommandBlind");
        }

        public bool CommandBool(string command, bool raw)
        {
            CheckConnected("CommandBool");
            // TODO The optional CommandBool method should either be implemented OR throw a MethodNotImplementedException
            // If implemented, CommandBool must send the supplied command to the mount, wait for a response and parse this to return a True or False value

            // string retString = CommandString(command, raw); // Send the command and wait for the response
            // bool retBool = XXXXXXXXXXXXX; // Parse the returned string and create a boolean True / False value
            // return retBool; // Return the boolean value to the client

            throw new ASCOM.MethodNotImplementedException("CommandBool");
        }

        public string CommandString(string command, bool raw)
        {
            CheckConnected("CommandString");
            // TODO The optional CommandString method should either be implemented OR throw a MethodNotImplementedException
            // If implemented, CommandString must send the supplied command to the mount and wait for a response before returning this to the client

            throw new ASCOM.MethodNotImplementedException("CommandString");
        }

        public void Dispose()
        {
            // Clean up the trace logger and util objects
            tl.Enabled = false;
            tl.Dispose();
            tl = null;
            utilities.Dispose();
            utilities = null;
            astroUtilities.Dispose();
            astroUtilities = null;
        }

        public string Description
        {
            // TODO customise this device description
            get
            {
                tl.LogMessage("Description Get", driverDescription);
                return driverDescription;
            }
        }

        public string DriverInfo
        {
            get
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                // TODO customise this driver description
                string driverInfo = "Information about the driver itself. Version: " + String.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
                tl.LogMessage("DriverInfo Get", driverInfo);
                return driverInfo;
            }
        }

        public string DriverVersion
        {
            get
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                string driverVersion = String.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
                tl.LogMessage("DriverVersion Get", driverVersion);
                return driverVersion;
            }
        }

        public short InterfaceVersion
        {
            // set by the driver wizard
            get
            {
                LogMessage("InterfaceVersion Get", "1");
                return Convert.ToInt16("1");
            }
        }

        public string Name
        {
            get
            {
                string name = "MyCloudPWS Driver";
                tl.LogMessage("Name Get", name);
                return name;
            }
        }

        #endregion

        #region IObservingConditions Implementation

        /// <summary>
        /// Returns true if there is a valid connection to the driver hardware
        /// </summary>
        public bool IsConnected
        {
            get
            {
                // TODO check that the driver hardware connection exists and is connected to the hardware
                return connectedState;
            }
        }

        public bool Connected
        {
            get
            {
                LogMessage("Connected", "Get {0}", connectedState);
                return true; //  connectedState;
            }
            set
            {
                LogMessage("Connected", "Set {0}", value);
                if (value == connectedState)
                    return;

                // check for valid data
                if (string.IsNullOrEmpty(apiKey))
                    throw new DriverException("Cannot connect, no API key has been defined.");
                switch (locationType)
                {
                    case LocationType.stationIdWCWU:
                        if (string.IsNullOrEmpty(stationIdWCWU))
                            throw new DriverException("stationIdWCWU is selected but no stationIdWCWU has been defined");
                        break;
                    case LocationType.stationIdOWM3:
                        if (string.IsNullOrEmpty(stationIdOWM3))
                            throw new DriverException("stationIdOWM3 is selected but no stationIdOWM3 has been defined");
                        break;
                    case LocationType.stationIdWLL:
                        if (string.IsNullOrEmpty(stationIdWLL))
                            throw new DriverException("stationIdWLL is selected but no stationIdWLL has been defined");
                        break;
                    case LocationType.LatLong:
                        if (SiteLatitude == "0" && SiteLongitude == "0")
                            throw new DriverException("Position has been selected but no position has been defined");
                        break;
                    case LocationType.ZipCode:
                        if (string.IsNullOrEmpty(ZipCode))
                            throw new DriverException("ZipCode is selected but no ZipCode has been defined");
                        break;
                    case LocationType.CityName:
                        if (string.IsNullOrEmpty(CityName))
                            throw new DriverException("City name is selected but no city name has been defined");
                        break;
                    case LocationType.CityId:
                        if (string.IsNullOrEmpty(CityId))
                            throw new DriverException("City Id is selected but no city id has been defined");
                        break;
                    default:
                        throw new DriverException("Unspecified Location type is defined");
                }
                //connectedState = value;
                if (value)
                {
                    lastUpdate = DateTime.MinValue;
                }
            }
        }

        private static Util util = new Util();

        private static DateTime lastUpdate = DateTime.MinValue;

        public static WeatherDataWCWU weatherDataWCWU;
        public static WeatherDataOWM  weatherDataOWM;
        public static WeatherDataOWM3 weatherDataOWM3;
        public static WeatherDataWLL weatherDataWLL;

        public static double? humidity; 
        public static int? humidityOWM; // different type
        public static int? windDir;
        public static double? dewPt;
        public static double? pressure;
        public static double? temp;
        public static double? windGust;
        public static double? windSpeed;
        public static double rainRate;
        public static double? cloudCover;

        public static bool UpdateWeather()
        {
            try
            {
                var reply = GetResponseStr();
                //Console.WriteLine("reply  " + reply);
                //LogMessage("UpdateWeather", "reply {0}");
                var jss = new JavaScriptSerializer();
                if (myLocationType == "stationIdWCWU")
                {
                    weatherDataWCWU = (WeatherDataWCWU)jss.Deserialize<WeatherDataWCWU>(reply);
                    temp = weatherDataWCWU.observations[0].metric.temp; // -32)*5/9; or - 273.15
                    humidity = weatherDataWCWU.observations[0].humidity;
                    pressure = weatherDataWCWU.observations[0].metric.pressure; // * 0.02953;
                    dewPt = weatherDataWCWU.observations[0].metric.dewPt; // * 33.863;
                    windDir = weatherDataWCWU.observations[0].windDir;
                    windSpeed = weatherDataWCWU.observations[0].metric.windSpeed * 0.44704;
                    windGust = weatherDataWCWU.observations[0].metric.windGust * 0.44704;
                    rainRate = weatherDataWCWU.observations[0].metric.precipRate;
                    cloudCover = 0;
                }
                else if (myLocationType == "stationIdOWM3")
                {
                    if (reply == "[]")
                    {
                        temp = 0;
                        humidity = 0;
                        pressure = 0;
                        dewPt = 0;
                        windDir = 0;
                        windSpeed = 0;
                        windGust = 0;
                        rainRate = 0;
                        cloudCover = 0;
                    }
                    else
                    {
                        weatherDataOWM3 = (WeatherDataOWM3)jss.Deserialize<WeatherDataOWM3>("{\"observations\":" + reply + "}");
                        temp = weatherDataOWM3.observations[0].temp.average;
                        humidity = weatherDataOWM3.observations[0].humidity.average;
                        pressure = weatherDataOWM3.observations[0].pressure.min;
                        dewPt = util.Humidity2DewPoint((double)humidity, (double)temp);
                        windSpeed = weatherDataOWM3.observations[0].wind.speed;
                        windGust = windSpeed;
                        windDir = weatherDataOWM3.observations[0].wind.deg;
                        rainRate = weatherDataOWM3.observations[0].precipitation;
                        cloudCover = 0;
                    }
                }
                else if (myLocationType == "stationIdWLL")
                {
                    if (reply == "[]")
                    {
                        temp = 0;
                        humidity = 0;
                        pressure = 0;
                        dewPt = 0;
                        windDir = 0;
                        windSpeed = 0;
                        windGust = 0;
                        rainRate = 0;
                        cloudCover = 0;
                    }
                    else
                    {
                        weatherDataWLL = (WeatherDataWLL)jss.Deserialize<WeatherDataWLL>(reply);
                        temp = weatherDataWLL.sensors[0].data[0].temp;
                        humidity = weatherDataWLL.sensors[0].data[0].hum;
                        pressure = 0;
                        dewPt = weatherDataWLL.sensors[0].data[0].dew_point;
                        //dewPt = util.Humidity2DewPoint((double)humidity, (double)temp);
                        windSpeed = weatherDataWLL.sensors[0].data[0].wind_speed_last;
                        windGust = weatherDataWLL.sensors[0].data[0].wind_speed_hi_last_2_min; 
                        windDir = weatherDataWLL.sensors[0].data[0].wind_dir_at_hi_speed_last_10_min;
                        rainRate = (double) weatherDataWLL.sensors[0].data[0].rain_rate_hi_last_15_min_clicks;
                        cloudCover = 0;
                    }
                }
                else
                {
                    weatherDataOWM = (WeatherDataOWM)jss.Deserialize<WeatherDataOWM>(reply);
                    temp = weatherDataOWM.main.temp; //- 273.15;
                    humidityOWM = weatherDataOWM.main.humidity;
                    pressure = weatherDataOWM.main.pressure; 
                    dewPt = util.Humidity2DewPoint((double) humidityOWM, (double) temp);
                    windSpeed = weatherDataOWM.wind.speed;
                    windGust = windSpeed;
                    windDir = weatherDataOWM.wind.deg;

                    // this kludge handles the problem of the rain rate field name being "1h"
                    //reply = reply.Replace("{\"1h\":", "{\"rate1h\":");
                    reply = reply.Replace("{\"3h\":", "{\"rate3h\":");
                    rainRate = weatherDataOWM.rain.rate3h;
                    cloudCover = weatherDataOWM.clouds.all;
                }
                return true;
            }
            catch 
            {
                //LogMessage("UpdateWeather", "error {0}",ex);
                return false;
            }
        }

        
        private static DateTime FromUnix(int dt)
        {
            // Unix timestamp is seconds past epoch
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return dtDateTime.AddSeconds(dt);
        }

        public static string BuildUrl()
        {
            switch (myLocationType)
            {
                case "stationIdWCWU":
                    return (BuildUrlWCWU());
                case "stationIdOWM3":
                    return (BuildUrlOWM3());
                case "stationIdWLL":
                    return (BuildUrlWLL());
                default:
                    return (BuildUrlOWM());
            }
         }
        private static LocationType locationType;

        public static string BuildUrlWCWU()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(apiUrlWCWU);
            sb.AppendFormat("?stationId={0}", stationIdWCWU);
            sb.AppendFormat("&apiKey={0}", apiKeyWCWU);
            sb.AppendFormat("&format=json");
            sb.AppendFormat("&units=m");
            sb.AppendFormat("&numericPrecision=decimal");
            //LogMessage("BuildUrl", sb.ToString());
            return sb.ToString();
        }

        public static string BuildUrlOWM()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(apiUrlOWM);
            switch (locationType)
            {
                case LocationType.LatLong:
                    sb.AppendFormat("?lat={0}&lon={1}", SiteLatitude, SiteLongitude);
                    break;
                case LocationType.ZipCode:
                    sb.AppendFormat("?zip={0}", ZipCode);
                    break;
                case LocationType.CityName:
                    sb.AppendFormat("?q={0}", CityName);
                    break;
                case LocationType.CityId:
                    sb.AppendFormat("?q={0}", CityId);
                    break;
                default:
                    break;
            }
            sb.AppendFormat("&APPID={0}", apiKeyOWM);
            sb.AppendFormat("&format=json");
            sb.AppendFormat("&units=metric");
            sb.AppendFormat("&numericPrecision=decimal");
            //LogMessage("BuildUrl", sb.ToString());
            return sb.ToString();
        }


        public static string BuildUrlOWM3()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(apiUrlOWM3);
            sb.AppendFormat("?station_id={0}", stationIdOWM3);
            sb.AppendFormat("&APPID={0}", apiKeyOWM);
            sb.AppendFormat("&limit={0}", limit);
            sb.AppendFormat("&type={0}", type);
            sb.AppendFormat("&from={0}", (DateTimeOffset.Now.ToUnixTimeSeconds() - Int32.Parse(interval) * 60).ToString()); //JGM added time to test delay in feeds 
            sb.AppendFormat("&to={0}",   (DateTimeOffset.Now.ToUnixTimeSeconds()).ToString());
            //LogMessage("BuildUrl", sb.ToString());
            return sb.ToString();
        }
        public static string BuildUrlWLL()
        {
            //
            // Need to build the parameter string upon which we compute the Hash Signature
            //
            SortedDictionary<string, string> parameters = new SortedDictionary<string, string>();
            parameters.Add("api-key", apiKeyWLL);
            parameters.Add("station-id", stationIdWLL); 
            parameters.Add("t", DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString());

            StringBuilder dataStringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> entry in parameters)
            {
                dataStringBuilder.Append(entry.Key);
                dataStringBuilder.Append(entry.Value);
            }
            string data = dataStringBuilder.ToString();

            string apiSignatureString = null;
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(apiSecretWLL)))
            {
                byte[] apiSignatureBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                apiSignatureString = BitConverter.ToString(apiSignatureBytes).Replace("-", "").ToLower();
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(apiUrlWLL);
            sb.AppendFormat("/{0}", stationIdWLL);
            sb.AppendFormat("&api-key={0}", apiKeyWLL);
            sb.AppendFormat("&api-signature={0}", apiSignatureString);
            sb.AppendFormat("&t={0}", parameters["t"]);
            //LogMessage("BuildUrl", sb.ToString());
            return sb.ToString();
        }

        private static string GetResponseStr()
        {
            using (var wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                var uri = BuildUrl();
                var str = wc.DownloadString(uri);
                return str;
            }
        }

        /// <summary>
        /// Forces the driver to immediatley query its attached hardware to refresh sensor
        /// values
        /// </summary>
        public void Refresh()
        {
            UpdateWeather();
        }

        /// <summary>
        /// Gets and sets the time period over which observations wil be averaged
        /// </summary>
        /// <remarks>
        /// Get must be implemented, if it can't be changed it must return 0
        /// Time period (hours) over which the property values will be averaged 0.0 =
        /// current value, 0.5= average for the last 30 minutes, 1.0 = average for the
        /// last hour
        /// </remarks>
        /// 
        public double AveragePeriod
        {
            get
            {
                LogMessage("AveragePeriod", "get - 0");
                return (double) Int16.Parse("0")/60; // interval in minutes to hours or "0"
            }
            set
            {
                LogMessage("AveragePeriod", "set - {0}", value);
                if (value != 0)
                    throw new InvalidValueException("AveragePeriod", value.ToString(), "0 only");
            }
        }

        private static void GetData(string message)
        {
            try
            {
                if ((DateTime.Now - lastUpdate).TotalMinutes > Int16.Parse(interval))
                {
                    UpdateWeather();
                    lastUpdate = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                //LogMessage("GetData({0})", "error {1}", message, ex);
                throw new DriverException(message, ex);
            }
        }

        public double CloudCover
        {
            get
            {
                try
                {
                    GetData("CloudCover");
                    if (cloudCover.HasValue)
                    {
                       return (double) cloudCover;
                    }
                }
                catch (Exception ex)
                {
                    LogMessage("CloudCover", "error {0}", ex);
                    throw;
                }
                throw new PropertyNotImplementedException("CloudCover");
            }
        }

        public double DewPoint
        {
            get
            {
                try
                {
                    GetData("DewPoint");
                    if (dewPt.HasValue)
                    {
                        return Math.Round(dewPt.Value, 1);
                    }
                }
                catch (Exception ex)
                {
                    LogMessage("DewPoint", "error {0}", ex);
                    throw;
                }
                throw new PropertyNotImplementedException("DewPoint");
            }
        }

        public double Humidity
        {
            get
            {
                try
                {
                    GetData("Humidity");

                    if (myLocationType == "stationIdWCWU")
                    {
                        if (humidity.HasValue)
                            return humidity.Value;
                    }
                    else
                    {
                        if (humidityOWM.HasValue)
                            return humidityOWM.Value;
                    }
                    throw new PropertyNotImplementedException("Humidity");
                }
                catch (Exception ex)
                {
                    LogMessage("Humidity", "error {0}", ex);
                    throw;
                }
                throw new PropertyNotImplementedException("Humidity");
            }
        }

        public double Pressure
        {
            get
            {
                try
                {
                    GetData("Pressure");
                    if (pressure.HasValue)
                    {
                        return Math.Round(pressure.Value, 1);
                    }
                }
                catch (Exception ex)
                {
                    LogMessage("Pressure", "error {0}", ex);
                    throw;
                }
                throw new PropertyNotImplementedException("Pressure");
            }
        }

        public double RainRate
        {
            get
            {
                try
                {
                    GetData("RainRate");
                    return rainRate; 
                }
                 catch (Exception ex)
                {
                    LogMessage("RainRate", "error {0}", ex);
                    throw;
                }
                throw new PropertyNotImplementedException("RainRate");
            }
        }


        /// <summary>
        /// Sky brightness at the observatory
        /// </summary>
        public double SkyBrightness
        {
            get
            {
                LogMessage("SkyBrightness", "get - not implemented");
                throw new PropertyNotImplementedException("SkyBrightness", false);
            }
        }

        /// <summary>
        /// Sky quality at the observatory
        /// </summary>
        public double SkyQuality
        {
            get
            {
                LogMessage("SkyQuality", "get - not implemented");
                throw new PropertyNotImplementedException("SkyQuality", false);
            }
        }

        /// <summary>
        /// Seeing at the observatory
        /// </summary>
        public double StarFWHM
        {
            get
            {
                LogMessage("StarFWHM", "get - not implemented");
                throw new PropertyNotImplementedException("StarFWHM", false);
            }
        }

        /// <summary>
        /// Sky temperature at the observatory in °C
        /// </summary>
        public double SkyTemperature
        {
            get
            {
                LogMessage("SkyTemperature", "get - not implemented");
                throw new PropertyNotImplementedException("SkyTemperature", false);
            }
        }

        public double Temperature
        {
            get
            {
                try
                {
                    GetData("Temperature");
                    if (temp.HasValue)
                    {
                        return Math.Round(temp.Value, 1);
                    }
                }
                catch (Exception ex)
                {
                    LogMessage("Temperature", "error {0}", ex);
                    throw;
                }
                throw new PropertyNotImplementedException("");
            }
        }

        public double WindGust
        {
            get
            {
                GetData("WindGust");
                if (windGust.HasValue)
                    return Math.Round(windGust.Value);
                throw new PropertyNotImplementedException("WindGust");
            }
        }

        public double WindDirection
        {
            get
            {
                GetData("WindDirection");
                if (windSpeed.HasValue)
                {
                    if (windDir.HasValue)
                       return windDir.Value;
                    throw new PropertyNotImplementedException("WindDir");
                }
                else 
                    return 0;
            }
        }

        public double WindSpeed
        {
            get
            {
                GetData("WindSpeed");
                if (windSpeed.HasValue)
                    return Math.Round(windSpeed.Value, 1);
                throw new PropertyNotImplementedException("WindSpeed");
            }
        }

        /// <summary>
        /// Provides a description of the sensor providing the requested property
        /// </summary>
        /// <param name="propertyName">Name of the property whose sensor description is required</param>
        /// <returns>The sensor description string</returns>
        /// <remarks>
        /// PropertyName must be one of the sensor properties, 
        /// properties that are not implemented must throw the MethodNotImplementedException
        /// </remarks>
        public string SensorDescription(string propertyName)
        {
            switch (propertyName.Trim().ToLowerInvariant())
            {
                case "averageperiod":
                    return "Average period in hours, 0.1 or 0=immediate values are only available";
                case "dewpoint":
                    return "Dew Point, °C";
                case "humidity":
                    return "Atmospheric Humidity, %";
                case "pressure":
                    return "Pressure, Relative pressure at the observatory (hPa)";
                case "temperature":
                    return "Temperature,  °C";
                case "winddirection":
                    return "Wind Direction, Deg. from North (clockwise)";
                case "windgust":
                    return "Wind Gust, m/s";
                case "windspeed":
                    return "Wind Speed, m/s";
                case "rainrate":
                    return "Rain Rate, mm/hr";
                case "cloudcover":
                    return "Cloud Cover, %";
                case "skybrightness":
                case "skyquality":
                case "skytemperature":
                case "starfwhm":
                    // Throw an exception on the properties that are not implemented
                    LogMessage("SensorDescription", $"Property {propertyName} is not implemented");
                    throw new MethodNotImplementedException($"SensorDescription - Property {propertyName} is not implemented");
                default:
                    LogMessage("SensorDescription", $"Invalid sensor name: {propertyName}");
                    throw new ASCOM.InvalidValueException($"SensorDescription - Invalid property name: {propertyName}");
            }
        }

        /// <summary>
        /// Provides the time since the sensor value was last updated
        /// </summary>
        /// <param name="propertyName">Name of the property whose time since last update Is required</param>
        /// <returns>Time in seconds since the last sensor update for this property</returns>
        /// <remarks>
        /// PropertyName should be one of the sensor properties Or empty string to get
        /// the last update of any parameter. A negative value indicates no valid value
        /// ever received.
        /// </remarks>
        public double TimeSinceLastUpdate(string propertyName)
        {
            // Test for an empty property name, if found, return the time since the most recent update to any sensor
            if (!string.IsNullOrEmpty(propertyName))
            {
                switch (propertyName.Trim().ToLowerInvariant())
                {
                    // Return the time for properties that are implemented, otherwise fall through to the MethodNotImplementedException
                    case "averageperiod":
                    case "dewpoint":
                    case "humidity":
                    case "pressure":
                    case "temperature":
                    case "winddirection":
                    case "windgust":
                    case "windspeed":
                    case "rainrate":
                    case "cloudcover":
                        return (DateTime.Now - lastUpdate).TotalMinutes;
                    case "skybrightness":
                    case "skyquality":
                    case "skytemperature":
                    case "starfwhm":
                        // Throw an exception on the properties that are not implemented
                        LogMessage("TimeSinceLastUpdate", $"Property {propertyName} is not implemented");
                        throw new MethodNotImplementedException($"TimeSinceLastUpdate - Property {propertyName} is not implemented");
                    default:
                        LogMessage("TimeSinceLastUpdate", $"Invalid sensor name: {propertyName}");
                        throw new InvalidValueException($"TimeSinceLastUpdate - Invalid property name: {propertyName}");
                }
            }
            // Return the time since the most recent update to any sensor
            LogMessage("TimeSinceLastUpdate", $"The time since the most recent sensor update is not implemented");
            throw new MethodNotImplementedException("TimeSinceLastUpdate(" + propertyName + ")");
        }

        enum LocationType
        {
        /// api.weather.com/v2/pws/observations/current?stationIdWCWU={stationIdWCWU}
        stationIdWCWU,
        /// api.openweathermap.org/data/2.5/weather?stationIdOWM3={stationIdOWM3}
        stationIdOWM3,
        /// api.weatherlink.com/v2/current?stationIdWLLU={stationIdWLL}
        stationIdWLL,
        /// api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}
        LatLong,
        /// api.openweathermap.org/data/2.5/weather?zip={zip code},{country code} 
        /// or
        /// api.openweathermap.org/data/2.5/weather?zip={ZipCode}
        ZipCode,
        /// api.openweathermap.org/data/2.5/weather?q={city name}
        /// or
        /// api.openweathermap.org/data/2.5/weather?q={city name},{country code}
        CityName,
        /// api.openweathermap.org/data/2.5/weather?id={city id}
        CityId,
        }
        #endregion

        #region private methods

        #region calculate the gust strength as the largest wind recorded over the last interval (or two minutes)

        // save the time and wind speed values
        private Dictionary<DateTime, double> winds = new Dictionary<DateTime, double>();

        private double gustStrength;

        private void UpdateGusts(double speed)
        {
            Dictionary<DateTime, double> newWinds = new Dictionary<DateTime, double>();
            var last = DateTime.Now - TimeSpan.FromMinutes(Int16.Parse(interval)); // interval or "2";
            winds.Add(DateTime.Now, speed);
            var gust = 0.0;
            foreach (var item in winds)
            {
                if (item.Key > last)
                {
                    newWinds.Add(item.Key, item.Value);
                    if (item.Value > gust)
                        gust = item.Value;
                }
            }
            gustStrength = gust;
            winds = newWinds;
        }

        #endregion

        #endregion

        #region Private properties and methods
        // here are some useful properties and methods that can be used as required
        // to help with driver development

        #region ASCOM Registration

        // Register or unregister driver for ASCOM. This is harmless if already
        // registered or unregistered. 
        //
        /// <summary>
        /// Register or unregister the driver with the ASCOM Platform.
        /// This is harmless if the driver is already registered/unregistered.
        /// </summary>
        /// <param name="bRegister">If <c>true</c>, registers the driver, otherwise unregisters it.</param>
        private static void RegUnregASCOM(bool bRegister)
        {
            using (var P = new ASCOM.Utilities.Profile())
            {
                P.DeviceType = "ObservingConditions";
                if (bRegister)
                {
                    P.Register(driverID, driverDescription);
                }
                else
                {
                    P.Unregister(driverID);
                }
            }
        }

        /// <summary>
        /// This function registers the driver with the ASCOM Chooser and
        /// is called automatically whenever this class is registered for COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is successfully built.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During setup, when the installer registers the assembly for COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually register a driver with ASCOM.
        /// </remarks>
        [ComRegisterFunction]
        public static void RegisterASCOM(Type t)
        {
            RegUnregASCOM(true);
        }

        /// <summary>
        /// This function unregisters the driver from the ASCOM Chooser and
        /// is called automatically whenever this class is unregistered from COM Interop.
        /// </summary>
        /// <param name="t">Type of the class being registered, not used.</param>
        /// <remarks>
        /// This method typically runs in two distinct situations:
        /// <list type="numbered">
        /// <item>
        /// In Visual Studio, when the project is cleaned or prior to rebuilding.
        /// For this to work correctly, the option <c>Register for COM Interop</c>
        /// must be enabled in the project settings.
        /// </item>
        /// <item>During uninstall, when the installer unregisters the assembly from COM Interop.</item>
        /// </list>
        /// This technique should mean that it is never necessary to manually unregister a driver from ASCOM.
        /// </remarks>
        [ComUnregisterFunction]
        public static void UnregisterASCOM(Type t)
        {
            RegUnregASCOM(false);
        }

        #endregion

        /// <summary>
        /// Use this function to throw an exception if we aren't connected to the hardware
        /// </summary>
        /// <param name="message"></param>
        private void CheckConnected(string message)
        {
            if (!IsConnected)
            {
                throw new ASCOM.NotConnectedException(message);
            }
        }

        /// <summary>
        /// Read the device configuration from the ASCOM Profile store
        /// </summary>
        internal void ReadProfile()
        {
            using (Profile driverProfile = new Profile())
            {
                driverProfile.DeviceType = "ObservingConditions";
                traceStateDefault = driverProfile.GetValue(driverID, "traceStateDefault", string.Empty, traceStateDefault);
                tl.Enabled = Convert.ToBoolean(driverProfile.GetValue(driverID, traceStateProfileName, string.Empty, traceStateDefault));
                traceState = tl.Enabled.ToString();
                comPort = driverProfile.GetValue(driverID, comPortProfileName, string.Empty, comPortDefault);

                myLocationType = driverProfile.GetValue(driverID, "LocationType", string.Empty, LocationTypeDefault);
                locationType = (LocationType)Enum.Parse(typeof(LocationType), myLocationType);

                stationIdWCWU = driverProfile.GetValue(driverID, "stationIdWCWU", string.Empty, stationIdWCWU);
                stationIdOWM3 = driverProfile.GetValue(driverID, "stationIdOWM3", string.Empty, stationIdOWM3);
                stationIdWLL = driverProfile.GetValue(driverID, "stationIdWLL", string.Empty, stationIdWLL);

                ZipCode = driverProfile.GetValue(driverID, "ZipCode", string.Empty, ZipCode);
                CityName = driverProfile.GetValue(driverID, "CityName", string.Empty, CityName);
                CityId = driverProfile.GetValue(driverID, "CityId", string.Empty, CityId);

                SiteLatitude = driverProfile.GetValue(driverID, "SiteLatitude", string.Empty, "0");
                SiteLongitude = driverProfile.GetValue(driverID, "SiteLongitude", string.Empty, "0");
                SiteElevation = driverProfile.GetValue(driverID, "SiteElevation", string.Empty, "0");

                units = driverProfile.GetValue(driverID, "units", string.Empty, "m");
                format = driverProfile.GetValue(driverID, "format", string.Empty, "json");
                numericPrecision = driverProfile.GetValue(driverID, "numericPrecision", string.Empty, "numericPrecision");
                type = driverProfile.GetValue(driverID, "type", string.Empty, "m");
                interval = driverProfile.GetValue(driverID, "interval", string.Empty, "6");

                apiKeyWCWU = driverProfile.GetValue(driverID, "apiKeyWCWU");
                apiUrlWCWU = driverProfile.GetValue(driverID, "apiUrlWCWU", string.Empty, apiUrlWCWU);

                apiKeyOWM = driverProfile.GetValue(driverID, "apiKeyOWM");
                apiUrlOWM = driverProfile.GetValue(driverID, "apiUrlOWM", string.Empty, apiUrlOWM);

                apiUrlOWM3 = driverProfile.GetValue(driverID, "apiUrlOWM3", string.Empty, apiUrlOWM3);

                apiKeyWLL = driverProfile.GetValue(driverID, "apiKeyWLL");
                apiUrlWLL = driverProfile.GetValue(driverID, "apiUrlWLL", string.Empty, apiUrlWLL);
                apiSecretWLL = driverProfile.GetValue(driverID, "apiSecretWLL", string.Empty, apiSecretWLL);

                if (myLocationType == "stationIdWCWU")
                    apiKey = apiKeyWCWU;
                else if (myLocationType == "stationIdWLL")
                    apiKey = apiKeyWLL;
                else
                    apiKey = apiKeyOWM;
            }
        }

        /// <summary>
        /// Write the device configuration to the  ASCOM  Profile store
        /// </summary>
        internal void WriteProfile()
        {
            using (Profile driverProfile = new Profile())
            {
                driverProfile.DeviceType = "ObservingConditions";
                driverProfile.WriteValue(driverID, traceStateProfileName, traceState); 
                driverProfile.WriteValue(driverID, "traceStateDefault", traceStateDefault); 
                driverProfile.WriteValue(driverID, "comPortProfileName", comPort);

                driverProfile.WriteValue(driverID, "LocationType", myLocationType);
                driverProfile.WriteValue(driverID, "stationIdWCWU", stationIdWCWU);
                driverProfile.WriteValue(driverID, "stationIdOWM3", stationIdOWM3);
                driverProfile.WriteValue(driverID, "stationIdWLL", stationIdWLL);

                driverProfile.WriteValue(driverID, "ZipCode", ZipCode);
                driverProfile.WriteValue(driverID, "CityName", CityName);
                driverProfile.WriteValue(driverID, "CityId", CityId);

                driverProfile.WriteValue(driverID, "SiteLatitude", SiteLatitude.ToString(CultureInfo.InvariantCulture));
                driverProfile.WriteValue(driverID, "SiteLongitude", SiteLongitude.ToString(CultureInfo.InvariantCulture));
                driverProfile.WriteValue(driverID, "SiteElevation", SiteElevation.ToString(CultureInfo.InvariantCulture));

                driverProfile.WriteValue(driverID, "units", units);
                driverProfile.WriteValue(driverID, "format", format);
                driverProfile.WriteValue(driverID, "numericPrecision", numericPrecision);
                driverProfile.WriteValue(driverID, "type", type);
                driverProfile.WriteValue(driverID, "interval", interval);

                driverProfile.WriteValue(driverID, "apiKeyWCWU", apiKeyWCWU);
                driverProfile.WriteValue(driverID, "apiUrlWCWU", apiUrlWCWU);

                driverProfile.WriteValue(driverID, "apiKeyOWM", apiKeyOWM);
                driverProfile.WriteValue(driverID, "apiUrlOWM", apiUrlOWM);

                driverProfile.WriteValue(driverID, "apiUrlOWM3", apiUrlOWM3); 

                driverProfile.WriteValue(driverID, "apiKeyWLL", apiKeyWLL);
                driverProfile.WriteValue(driverID, "apiUrlWLL", apiUrlWLL);
                driverProfile.WriteValue(driverID, "apiSecretWLL", apiSecretWLL);
            }
        }

        /// <summary>
        /// Log helper function that takes formatted strings and arguments
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        internal void LogMessage(string identifier, string message, params object[] args)
        {
            var msg = string.Format(message, args);
            tl.LogMessage(identifier, msg);
        }
        #endregion
    }
}
