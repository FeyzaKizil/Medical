using Newtonsoft.Json;
using RestSharp;
using SymptomChecker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymptomChecker
{
    public partial class ShowPharmacies : Form
    {
        public ShowPharmacies()
        {
            InitializeComponent();
        }
        

        public List<string> GetCities()
        {
            var client = new RestClient("https://api.collectapi.com/health/districtList");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 7iEjjaEu1T2zekKkyI2shj:0BW4cNSzHhw2PxaFXmzXqI");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            CitiesJson data = JsonConvert.DeserializeObject<CitiesJson>(response.Content);
            return data.result;
        }

        public string GetCity(int index)
        {
            if(index < 0)
                index = 0;
            List<string> cities = GetCities();
            return cities[index];
        }
        public string GetDistrict(int index)
        {
            if (index < 0)
                index = 0;
            List<District> districts = GetDistricts(GetCity(city_comboBox.SelectedIndex));
            return districts[index].text;
        }

        public List<District> GetDistricts(string city)
        {
            var client = new RestClient("https://api.collectapi.com/health/districtList?il="+city);
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 7iEjjaEu1T2zekKkyI2shj:0BW4cNSzHhw2PxaFXmzXqI");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            DistrictsJson data = JsonConvert.DeserializeObject<DistrictsJson>(response.Content);
            return data.result;

        }

        public List<Pharmacy> dutyPharmacy(string city, string district)
        {
            //var client = new RestClient("https://api.collectapi.com/health/dutyPharmacy?ilce=%C3%87ankaya&il=Ankara");
            var client = new RestClient("https://api.collectapi.com/health/dutyPharmacy?ilce="+district+"&il="+city);
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 7iEjjaEu1T2zekKkyI2shj:0BW4cNSzHhw2PxaFXmzXqI");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            PharmacyJson data = JsonConvert.DeserializeObject<PharmacyJson>(response.Content);
            return data.result;
        }

        public DataTable showPharmacies(List<Pharmacy> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("District", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Location", typeof(string));

            for(int i = 0; i < list.Count; i++)
            {
                dt.Rows.Add(list[i].name,list[i].dist, list[i].address, list[i].phone, list[i].loc);
            }

            return dt;
        }


        private void SelectLocationForPharmacies_Load(object sender, EventArgs e)
        {
            city_comboBox.DataSource = GetCities();
            city_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            district_comboBox.Enabled = false;
            pharmacies_dataGridView.Visible = false;
            
           
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            pharmacies_dataGridView.Visible=true;
            pharmacies_dataGridView.DataSource = showPharmacies(dutyPharmacy(GetCity((city_comboBox.SelectedIndex)), GetDistrict(district_comboBox.SelectedIndex)));
        }

        private void city_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            district_comboBox.DataSource = GetDistricts(GetCity(city_comboBox.SelectedIndex));
            district_comboBox.Enabled = true;
            district_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }

  
}
