using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.IO;

namespace LightShowRaspberry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            connection = new SshConnection(RaspberryIp, loginName, loginPassword);
           // connection.LightShowFolder = "/home/pi/lightshow/";
           // connection.MusicFolder = "/home/pi/Music/";
        }

        string RaspberryIp = "192.168.0.104";

        string loginName = "pi";
        string loginPassword = "raspberry";
        SshConnection connection;


        private void UpdateList()
        {
            listBox1.Items.Clear();
            if (connection.IsConnected)
            {
                var songList = connection.GetSongList();
                foreach (var song in songList)
                {
                    listBox1.Items.Add(song);
                }
            }
        }
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await connection.ConnectAsync();
           // connection.Connect();
            if (connection.IsConnected)
            {
                UpdateList();
                trackBar1.Value = connection.GetVolume();
            }
            else
                MessageBox.Show("Connection could not be estabilished");
        }


        private async void btnUpload_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog1.FileNames;
                    //connection.Upload(files);
                    await connection.UploadAsync(files);
                    foreach (var file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        if(!listBox1.Items.Contains(fileName))
                            listBox1.Items.Add(fileName);
                    }
                }
                else
                    return;
            }
            else
                MessageBox.Show("Connection could not be estabilished");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(connection.IsConnected)
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    var items = listBox1.SelectedItems;
                    string[] files = items.OfType<string>().ToArray();
                    connection.Delete(files);

                    for (int i = 0; i < items.Count; i++) //Musím for cyklus.  Foreach je v listboxSelectedItem kolekci zakázanej
                    {
                        listBox1.Items.Remove(items[i]);
                    }
                }

            }
            else
                MessageBox.Show("Connection could not be estabilished");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (connection.IsConnected)
                {
                    connection.Play(listBox1.SelectedItem.ToString(), trackBar1.Value);
                 }
                else
                    MessageBox.Show("Connection could not be estabilished");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(connection.IsConnected)
            {
                connection.Exit();
                listBox1.Items.Clear();
            }
            else
                MessageBox.Show("Connection could not be estabilished");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
                connection.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitlePT02_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
