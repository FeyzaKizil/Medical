using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using SymptomChecker.Properties;

namespace SymptomChecker
{
    public partial class AddSymptom : Form {
        public string uriParts = "https://sandbox-healthservice.priaid.ch/body/locations";
        private string uriSymptoms = "https://sandbox-healthservice.priaid.ch/symptoms";
        private string token;
        readonly string language = Settings.Default.language;
        private string age = Settings.Default.age;
        public string gender = Settings.Default.gender;

        public AddSymptom() {
            InitializeComponent();
        }

        static bool IsDigitsOnly(string str) {
            foreach (char c in str) {
                if (c < '0' || c > '9') {
                    return false;
                }
            }
            return true;
        }

        public static string Get(string uri) {
            var client = new WebClient();
            var content = client.DownloadData(uri);
            return Encoding.UTF8.GetString(content);
        }

        private void AddSymptom_Load(object sender, EventArgs e) {
            Part_ComboBox.Enabled = false;
            Subpart_ComboBox.Enabled = false;
            Symptom_ComboBox.Enabled = false;
            string uriToken = "https://sandbox-authservice.priaid.ch/login";
            //string api_key = "marjanovicstevan02@gmail.com";
            //string secret_key = "s7GWj38Acz2T5Qyp4";
            string api_key = "sonsuzironiler3@gmail.com";
            string secret_key = "g3P6KdTe75CyQx89G";
            byte[] secretBytes = Encoding.UTF8.GetBytes(secret_key);
            string computedHashString = "";
            using (HMACMD5 hmac = new HMACMD5(secretBytes)) {
                byte[] dataBytes = Encoding.UTF8.GetBytes(uriToken);
                byte[] computedHash = hmac.ComputeHash(dataBytes);
                computedHashString = Convert.ToBase64String(computedHash);
            }

            using (WebClient client = new WebClient()) {
                client.Headers["Authorization"] = string.Concat("Bearer ", api_key, ":", computedHashString);
                string responseToken = client.UploadString(uriToken, "POST", "");
                dynamic json = JObject.Parse(responseToken);
                token = json.Token;
            }

            string responseParts = Get(uriParts + "?token=" + token + "&language=" + language);
            dynamic jsonPartsArray = JArray.Parse(responseParts);

            var dataParts = new List<Part>();
            foreach (dynamic jsonPart in jsonPartsArray) {
                dataParts.Add(new Part { ID = jsonPart.ID, Name = jsonPart.Name });
            }

            Part_ComboBox.DataSource = dataParts;
            Part_ComboBox.DisplayMember = "Name";
            Part_ComboBox.ValueMember = "ID";
            Part_ComboBox.Enabled = true;
            Part_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Part_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (IsDigitsOnly(Part_ComboBox.SelectedValue.ToString())) {
                string responseSubparts = Get(uriParts + "/" + Part_ComboBox.SelectedValue.ToString() + "?token=" + token + "&language=" + language);
                dynamic jsonSubpartsArray = JArray.Parse(responseSubparts);

                var dataSubparts = new List<Part>();
                foreach (dynamic jsonSubpart in jsonSubpartsArray) {
                    dataSubparts.Add(new Part { ID = jsonSubpart.ID, Name = jsonSubpart.Name });
                }

                Subpart_ComboBox.DataSource = dataSubparts;
                Subpart_ComboBox.DisplayMember = "Name";
                Subpart_ComboBox.ValueMember = "ID";
                Subpart_ComboBox.Enabled = true;
                Subpart_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                Symptom_ComboBox.Enabled = false;
            }
        }

        private void Subpart_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (IsDigitsOnly(Subpart_ComboBox.SelectedValue.ToString())) {
                string selectorStatus = "man";
                bool isAdult = DateTime.Now.Year - Int16.Parse(age) > 11;
                if (gender == "male") {
                    selectorStatus = (isAdult) ? "man" : "boy";
                } else {
                    selectorStatus = (isAdult) ? "woman" : "girl";
                }
                string responseSymptoms = Get(uriSymptoms + "/" + Subpart_ComboBox.SelectedValue.ToString() + "/" + selectorStatus + "?token=" + token + "&language=" + language);
                dynamic jsonSymptomsArray = JArray.Parse(responseSymptoms);

                var dataSymptoms = new List<Symptom>();
                foreach (dynamic jsonSymptom in jsonSymptomsArray) {
                    bool HasRedFlag = false;
                    string name = jsonSymptom.Name;
                    if (jsonSymptom.HasRedFlag is JValue jv) {
                        HasRedFlag = (bool)jv.Value;
                    }
                    if (HasRedFlag) {
                        name += " (!)";
                    }
                    dataSymptoms.Add(new Symptom { ID = jsonSymptom.ID, Name = name });
                }

                Symptom_ComboBox.DataSource = dataSymptoms;
                Symptom_ComboBox.DisplayMember = "Name";
                Symptom_ComboBox.ValueMember = "ID";
                Symptom_ComboBox.Enabled = true;
                Symptom_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void Add_btn_Click(object sender, EventArgs e) {
            if (Settings.Default.symptomsIDs == "") {
                Settings.Default.symptomsIDs += Symptom_ComboBox.SelectedValue.ToString();
            } else {
                Settings.Default.symptomsIDs += "," + Symptom_ComboBox.SelectedValue.ToString();
            }

            if (Settings.Default.symptomsNames == "") {
                Settings.Default.symptomsNames += Symptom_ComboBox.Text;
            } else {
                Settings.Default.symptomsNames += ", " + Symptom_ComboBox.Text;
            }

            this.Close();
        }
    }

    public class Part {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class Symptom {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
