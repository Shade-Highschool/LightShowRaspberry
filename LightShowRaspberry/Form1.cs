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

        string RaspberryIp = "192.168.0.102";

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
            lblConnected.Text = "Connecting..";
            await connection.ConnectAsync();
            // connection.Connect();
            if (connection.IsConnected)
            {
                lblConnected.Text = "Connected";
                UpdateList();
                trackBar1.Value = connection.GetVolume();
            }
            else
            {
                lblConnected.Text = "Disconnected";
                MessageBox.Show("Connection could not be estabilished");
            }
        }


        private async void btnUpload_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog1.FileNames;
                    //connection.Upload(files);
                    lblConnected.Text = "Uploading..";
                    await connection.UploadAsync(files);
                    foreach (var file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        if(!listBox1.Items.Contains(fileName))
                            listBox1.Items.Add(fileName);
                    }
                    lblConnected.Text = "Files uploaded";
                }
                else
                    return;
            }
            else
                MessageBox.Show("Connection could not be estabilished");



        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if(connection.IsConnected)
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    lblConnected.Text = "Removing files..";
                    var items = listBox1.SelectedItems;
                    string[] files = items.OfType<string>().ToArray();
                    connection.Delete(files);

                    for (int i = 0; i < items.Count; i++) //Musím for cyklus.  Foreach je v listboxSelectedItem kolekci zakázanej
                    {
                        listBox1.Items.Remove(items[i]);
                    }
                    lblConnected.Text = "Files removed";
                }

            }
            else
                MessageBox.Show("Connection could not be estabilished");

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (connection.IsConnected)
                {
                    connection.Play(listBox1.SelectedItem.ToString(), trackBar1.Value);
                    btnPlay.Enabled = false;
                 }
                else
                    MessageBox.Show("Connection could not be estabilished");
            }

        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            if(connection.IsConnected)
            {
                connection.Exit();
                listBox1.Items.Clear();
                lblConnected.Text = "Disconnected";
                btnPlay.Enabled = true;

            }
            else
                MessageBox.Show("Connection could not be estabilished");

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
                connection.Stop();
            btnPlay.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
                connection.Exit();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
