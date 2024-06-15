using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBB.Models;

namespace BBB.Views
{
    public partial class RestWorkSpace : Form
    {
        BBBPing ping;
        public RestWorkSpace()
        {
            InitializeComponent();
            ping = new BBBPing(DateTime.Now, DateTime.MinValue, "test data");
            sendTextBox.Text = ping.sendTime.ToString();
            returnTextBox.Text = ping.returnTime.ToString(); 
            testDataTextBox.Text = ping.testData.ToString();
            jsonTextBox.Text = ping.ToJSON();
        }
        
    }

}
