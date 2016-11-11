using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TestAPI.Models;

namespace TestAPI
{
    public partial class frmTestAPI : Form
    {
        public frmTestAPI()
        {
            InitializeComponent();
        }

        private void btLauncher_Click(object sender, EventArgs e)
        {
            var file = new ItineraryUploadVO();

            if (string.IsNullOrEmpty(txtApiUrl.Text) ||
                string.IsNullOrEmpty(txtFileUrl.Text) ||
                string.IsNullOrEmpty(txtActionApi.Text))
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                using (StreamReader sr = new StreamReader(txtFileUrl.Text, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        file.lines.Add(sr.ReadLine());
                    }
                }

                file.ProviderFile = ProviderFileVO.Sabre;

                var Url = txtApiUrl.Text;
                var Action = txtActionApi.Text;
                var restClient = new RestClient(Url);
                var request = new RestRequest(Action, Method.POST);
                request.AddJsonBody(file);
                var response = restClient.Execute(request);
            }
        }
    }
}
