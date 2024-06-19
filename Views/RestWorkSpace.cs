using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBB.Models;
using BBB.Helpers;
using System.Diagnostics;
using BBB.DAL;
using BBB.ClientRESTHelpers;

namespace BBB.Views
{
    public partial class RestWorkSpace : Form
    {
        BBBPing ping;
        BBBPing ping2;
        string jsonString;
        public RestWorkSpace()
        {
            InitializeComponent();
            ping = new BBBPing(0, DateTime.Now, DateTime.MinValue, "test data");
            Default();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string updateJSON;
            updateJSON = jsonTextBox.Text;
            ping2.SetAsJSON(updateJSON);
            send2TextBox.Text = ping2.clientTime.ToString();
            return2TextBox.Text = ping2.serverTime.ToString();
            testData2TextBox.Text = ping2.testData.ToString();

        }

        private void Default()
        {
            sendTextBox.Text = ping.clientTime.ToString();
            returnTextBox.Text = ping.serverTime.ToString();
            testDataTextBox.Text = ping.testData.ToString();
            jsonString = ping.ToJSON();
            jsonTextBox.Text = jsonString;

            ping2 = new BBBPing();
            ping2.SetAsJSON(jsonString);

            send2TextBox.Text = ping2.clientTime.ToString();
            return2TextBox.Text = ping2.serverTime.ToString();
            testData2TextBox.Text = ping2.testData.ToString();

        }

        private void getButton_Click(object sender, EventArgs e)
        {
            BBBpingDAL pingDAL = new BBBpingDAL();

            BBBPing ping2 = pingDAL.GetBBBPing("/ping");
 
            send2TextBox.Text = ping2.clientTime.ToString();
            return2TextBox.Text = ping2.serverTime.ToString();
            testData2TextBox.Text = ping2.testData.ToString();


        }

        private void putButton_Click(object sender, EventArgs e)
        {
            BBBpingDAL pingDAL = new BBBpingDAL();

            BBBPing ping2 = pingDAL.PutBBBPing("/ping", ping);

            send2TextBox.Text = ping2.clientTime.ToString();
            return2TextBox.Text = ping2.serverTime.ToString();
            testData2TextBox.Text = ping2.testData.ToString();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            BBBpingDAL pingDAL = new BBBpingDAL();

            BBBPing ping2 = pingDAL.PostBBBPing("/ping", ping);

            send2TextBox.Text = ping2.clientTime.ToString();
            return2TextBox.Text = ping2.serverTime.ToString();
            testData2TextBox.Text = ping2.testData.ToString();

            BBBPing ping4 = pingDAL.DeleteBBBPing("/ping");

            SettingsDAL sdal = new SettingsDAL();
            Settings settings = sdal.GetSettings();
            Debug.WriteLine($"Got {settings.starturl} as startup page");


        }
    }

}
