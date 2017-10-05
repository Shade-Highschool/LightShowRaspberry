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
    public partial class Form1 : Form
    {
        public Form1()
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
            var songList = connection.GetSongList();
            foreach (var song in songList)
            {
                listBox1.Items.Add(song);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Conecting...";
            //connection.Connect();
            await connection.ConnectAsync();
            if (connection.IsConnected)
            {
                UpdateList();
                trackBar1.Value = connection.GetVolume();
                label1.Text = "Connected";
            }
            else
                MessageBox.Show("Connection could not be estabilished");
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "Uploading...";
                    string[] files = openFileDialog1.FileNames;
                    await connection.UploadAsync(files);

                    foreach (var file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        if(!listBox1.Items.Contains(fileName))
                            listBox1.Items.Add(fileName);
                        label1.Text = "Uploaded";
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
                var items = listBox1.SelectedItems;
                string[] files = items.OfType<string>().ToArray();
                connection.Delete(files);

                for (int i = 0; i < items.Count; i++) //Musím for cyklus.  Foreach je v listbox kolekci zakázanej
                {
                    listBox1.Items.Remove(items[i]);
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
                    button2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Connection could not be estabilished");
                    label1.Text = "Disconnected";
                }
            }
            else
                MessageBox.Show("Song is not selected");

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
            {
                connection.Stop();
                button2.Enabled = true;
            }
        }
    }
}
