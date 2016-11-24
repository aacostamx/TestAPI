using FileHelpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TestAPI.Models;
using Microsoft.VisualBasic.FileIO;
using CsvHelper;
using LumenWorks.Framework.IO.Csv;
using System.Linq;

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
            var url = string.Empty;
            var action = string.Empty;
            var restClient = new RestClient();
            var request = new RestRequest();
            var csvList = new List<string[]>();
            ItineraryUploadVO input = new ItineraryUploadVO();

            //if (string.IsNullOrEmpty(txtApiUrl.Text) ||
            //    string.IsNullOrEmpty(txtFileUrl.Text) ||
            //    string.IsNullOrEmpty(txtActionApi.Text))
            //{
            //    MessageBox.Show(@"All fields are required!");
            //}
            //else
            //{
            using (var csv = new CachedCsvReader(new StreamReader("\\10.10.32.131\\ItinerariosSISA\\SISACReport.csv", Encoding.Default), true))
            {
                csvList = csv.ToList();
            }

            if (csvList != null && csvList.Count > 0)
            {
                for (int i = 0; i < csvList.Count; i++)
                {
                    var Jeppesen = new ItineraryFile();
                    Jeppesen.Line = i + 2;
                    Jeppesen.AirlineCode = csvList[i][0];
                    Jeppesen.FLTNUM = csvList[i][1];
                    Jeppesen.ACREGNUMBER = csvList[i][2];
                    Jeppesen.FLTORGDATELT = csvList[i][3];
                    Jeppesen.DEP = csvList[i][4];
                    Jeppesen.DST = csvList[i][10];
                    Jeppesen.SKDDST = csvList[i][9];
                    Jeppesen.STDLT = csvList[i][32];
                    Jeppesen.STALT = csvList[i][46];
                    Jeppesen.FLTTYPE = csvList[i][44];
                    setDates(Jeppesen);
                    input.itineraries.Add(Jeppesen);
                }
            }

            input.StartDate = DateTime.Now.Date;
            input.EndDate = DateTime.Now.Date;
            input.readServerFile = false;
            input.email = true;
            input.inputDates = true;
            url = "";
            action = "";
            restClient = new RestClient(url);
            request = new RestRequest(action, Method.POST);
            request.AddJsonBody(input);
            var response = restClient.Execute(request);

            var sucess = response != null && response.StatusCode.ToString() == "OK" ? true : false;
            if (!sucess)
            {

            }
            else
            {

            }


            //}
        }

        private void setDates(ItineraryFile jeppesen)
        {
            throw new NotImplementedException();
        }
    }
}
