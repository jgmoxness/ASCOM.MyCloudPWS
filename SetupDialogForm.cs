using ASCOM.MyCloudPWS;
using ASCOM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;


namespace ASCOM.MyCloudPWS
{
    [ComVisible(false)]					// Form not registered for COM!

    public partial class SetupDialogForm : Form
    {
        private Util util = new Utilities.Util();

        TraceLogger tl; // Holder for a reference to the driver's trace logger

        public SetupDialogForm(TraceLogger tlDriver)
        {
            InitializeComponent();

            // Save the provided trace logger for use within the setup dialogue
            tl = tlDriver;

            // Initialise current values of user settings from the ASCOM Profile
            InitUI();
        }

        private void cmdOK_Click(object sender, EventArgs e) // OK button event handler
        {
            // Place any validation constraint checks here

            // Update the state variables with results from the dialogue
            tl.Enabled = chkTrace.Checked;
            ObservingConditions.traceState = tl.Enabled.ToString();
            ObservingConditions.comPort = (string)comboBoxComPort.SelectedText;

            if (radioButtonStationIdWCWU.Checked)
            {
                ObservingConditions.myLocationType = "stationIdWCWU"; // 0
            }
            else if (radioButtonStationIdOWM3.Checked)
            {
                ObservingConditions.myLocationType = "stationIdOWM3"; // 1
            }
            else if (radioButtonStationIdWLL.Checked)
            {
                ObservingConditions.myLocationType = "stationIdWLL"; // 2
            }
            else if (radioButtonLatLong.Checked)
            { 
                ObservingConditions.myLocationType = "LatLong"; // 3
            }
            else if (radioButtonZipCode.Checked)
            {
                ObservingConditions.myLocationType = "ZipCode"; // 4
            }
            else if (radioButtonCityName.Checked)
            {
                ObservingConditions.myLocationType = "CityName"; // 5
            }
            else if (radioButtonCityId.Checked)
            {
                ObservingConditions.myLocationType = "CityId"; // 6
            }
            ObservingConditions.stationIdWCWU = textBoxStationIdWCWU.Text;
            ObservingConditions.stationIdOWM3 = textBoxStationIdOWM3.Text;
            ObservingConditions.stationIdWLL = textBoxStationIdWLL.Text;

            ObservingConditions.ZipCode = textBoxZipCode.Text;
            ObservingConditions.CityName = textBoxCityName.Text;
            ObservingConditions.CityId = textBoxCityId.Text;

            //ObservingConditions.SiteLatitude = util.DMSToDegrees(textBoxSiteLatitude.Text);
            ObservingConditions.SiteLatitude = textBoxSiteLatitude.Text;
            //ObservingConditions.SiteLongitude = util.DMSToDegrees(textBoxSiteLongitude.Text);
            ObservingConditions.SiteLongitude = textBoxSiteLongitude.Text;
            //ObservingConditions.SiteElevation = double.Parse(textBoxSiteElevation.Text);
            ObservingConditions.SiteElevation = textBoxSiteElevation.Text;

            //ObservingConditions.units = textBoxUnits.Text;  // not updated
            //ObservingConditions.format = textBoxFormat.Text; // not updated
            //ObservingConditions.numericPrecision = textBoxNumericPrecision.Text; // not updated
            ObservingConditions.type = textBoxType.Text;
            ObservingConditions.interval = textBoxInterval.Text;

            ObservingConditions.apiKeyWCWU = textBoxApiKeyWCWU.Text;
            ObservingConditions.apiUrlWCWU = textBoxApiUrlWCWU.Text;

            ObservingConditions.apiKeyOWM = textBoxApiKeyOWM.Text;
            ObservingConditions.apiUrlOWM = textBoxApiUrlOWM.Text;

            ObservingConditions.apiUrlOWM3 = textBoxApiUrlOWM3.Text;

            ObservingConditions.apiKeyWLL = textBoxApiKeyWLL.Text;
            ObservingConditions.apiUrlWLL = textBoxApiUrlWLL.Text;
            ObservingConditions.apiSecretWLL = textBoxApiSecretWLL.Text;
        }

        private void cmdCancel_Click(object sender, EventArgs e) // Cancel button event handler
        {
            Close();
        }

        private void BrowseToAscom(object sender, EventArgs e) // Click on ASCOM logo event handler
        {
            try
            {
                System.Diagnostics.Process.Start("https://ascom-standards.org/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void buttonFindLocations_Click(object sender, EventArgs e)
        {
            var lat = util.DMSToDegrees(textBoxSiteLatitude.Text);
            var lon = util.DMSToDegrees(textBoxSiteLongitude.Text);
            // get up to 8 reports round a location
            var uri = string.Format("http://api.openweathermap.org/data/2.5/find?lat={0}&lon={1}&cnt=8&APPID={2}",
                lat, lon, textBoxApiKeyOWM.Text);
            if (radioButtonCityName.Checked)
                uri = string.Format("http://api.openweathermap.org/data/2.5/find?q={0}&cnt=8&APPID={1}",
                textBoxCityName.Text, textBoxApiKeyOWM.Text);
            //LogMessage("ShowLatLonList", "URI {0}", uri);
            GetResponse(uri);
        }

        private void GetResponse(string uri)
        {
            if (string.IsNullOrEmpty(textBoxApiKeyOWM.Text))
            {
                MessageBox.Show("The API key has not been set", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ret = "";

                using (var wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                    try
                    {
                        ret = wc.DownloadString(uri);
                    }
                    catch (WebException ex)
                    {
                        if (ex.Status == WebExceptionStatus.ProtocolError)
                        {
                            var response = ex.Response as HttpWebResponse;
                            if (response.StatusCode == HttpStatusCode.Unauthorized) MessageBox.Show("The API key was rejected, please check that the key is valid. (Status code: 401)");
                            else MessageBox.Show(string.Format("The GetResponse call was unsuccessul, (Status code: {0}): {1}", (int)response.StatusCode), ex.Message);
                            //LogMessage("GetResponse", "Received {0} error: {1}", ex.Status.ToString(), ex.Message);
                        }
                        else
                        {
                            MessageBox.Show("Received " + ex.Status.ToString() + " error: " + ex.Message);
                            //LogMessage("GetResponse", "Received {0} error: {1}", ex.Status.ToString(), ex.Message);
                        }
                    }
                    //catch (Exception ex)
                    //{
                        //LogMessage("GetResponse", "DownLoadString error {0}", ex.ToString());
                    //}
                }

                //LogMessage("GetResponse", "reply {0}", ret);

                dataGridView.Rows.Clear();
                var jss = new JavaScriptSerializer();
                try
                {
                    var wl = jss.Deserialize<WeatherListOWM>(ret);
                    foreach (var item in wl.list)
                    {
                        dataGridView.Rows.Add(item.name, util.DegreesToDM(item.coord.lat), util.DegreesToDM(item.coord.lon));
                    }
                }
                catch (Exception)
                { }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var cells = dataGridView.CurrentRow.Cells;
            textBoxCityName.Text = (string)cells["colName"].Value;
            textBoxSiteLatitude.Text = (string)cells["colLat"].Value;
            textBoxSiteLongitude.Text = (string)cells["colLon"].Value;
        }

        private void buttonObtainKeyWCWU_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.wunderground.com/signup");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void buttonObtainKeyOWM_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://openweathermap.org/appid");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void buttonObtainKeyWLL_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.weatherlink.com/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void InitUI()
        {
            textBoxDriverId.Text = ObservingConditions.driverID;
            chkTrace.Checked = tl.Enabled;

            //comboBoxComPort.Items.AddRange(ObservingConditions.comPort);
            comboBoxComPort.SelectedText = ObservingConditions.comPort;

            switch (ObservingConditions.myLocationType)
            {
                case "stationIdWCWU": // 0
                    radioButtonStationIdWCWU.Checked = true;
                    break;
                case "stationIdOWM3": // 1
                    radioButtonStationIdOWM3.Checked = true;
                    break;
                case "stationIdWLL": // 2
                    radioButtonStationIdWLL.Checked = true;
                    break;
                case "LatLong": // 3
                    radioButtonLatLong.Checked = true;
                    break;
                case "ZipCode": // 4
                    radioButtonZipCode.Checked = true;
                    break;
                case "CityName": // 5
                    radioButtonCityName.Checked = true;
                    break;
                case "CityId": // 6
                    radioButtonCityId.Checked = true;
                    break;
            }
            textBoxStationIdWCWU.Text = ObservingConditions.stationIdWCWU;
            textBoxStationIdOWM3.Text = ObservingConditions.stationIdOWM3;
            textBoxStationIdWLL.Text = ObservingConditions.stationIdWLL;

            textBoxZipCode.Text = ObservingConditions.ZipCode;
            textBoxCityName.Text = ObservingConditions.CityName;
            textBoxCityId.Text = ObservingConditions.CityId;

            textBoxSiteLatitude.Text = ObservingConditions.SiteLatitude;
            textBoxSiteLongitude.Text = ObservingConditions.SiteLongitude;
            textBoxSiteElevation.Text = ObservingConditions.SiteElevation;

            //textBoxUnits.Text = ObservingConditions.units; // not updated
            //textBoxFormat.Text = ObservingConditions.format; // not updated
            //textBoxNumericPrecision.Text = ObservingConditions.numericPrecision; // not updated
            textBoxType.Text = ObservingConditions.type;
            textBoxInterval.Text = ObservingConditions.interval;

            if (string.IsNullOrWhiteSpace(ObservingConditions.apiKey))
            {
                tabControl.SelectTab(0);
            }
            else
                tabControl.SelectTab(1);

            textBoxApiKeyWCWU.Text = ObservingConditions.apiKeyWCWU;
            textBoxApiUrlWCWU.Text = ObservingConditions.apiUrlWCWU;

            textBoxApiKeyOWM.Text = ObservingConditions.apiKeyOWM;
            textBoxApiUrlOWM.Text = ObservingConditions.apiUrlOWM;

            textBoxApiUrlOWM3.Text = ObservingConditions.apiUrlOWM3;

            textBoxApiKeyWLL.Text = ObservingConditions.apiKeyWLL;
            textBoxApiUrlWLL.Text = ObservingConditions.apiUrlWLL;
            textBoxApiSecretWLL.Text = ObservingConditions.apiSecretWLL;
        }

        private void labelUnitOptions_Click(object sender, EventArgs e)
        {

        }

        private void tabPageApiKey_Click(object sender, EventArgs e)
        {

        }

        private void labelApiUrlOWM_Click(object sender, EventArgs e)
        {

        }

        private void textBoxApiUrlOWM_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelApiKeyWLL_Click(object sender, EventArgs e)
        {

        }

        private void textBoxApiKeyWLL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}