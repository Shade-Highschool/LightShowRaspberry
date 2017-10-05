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
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Connect(); //předělat na async
            if (connection.IsConnected)
            {
                UpdateList();
                trackBar1.Value = connection.GetVolume();
            }
            else
                MessageBox.Show("Connection could not be estabilished");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog1.FileNames;
                    connection.Upload(files);

                    foreach (var file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file));
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
                 }
                else
                    MessageBox.Show("Connection could not be estabilished");
            }
            MessageBox.Show("Song is not selected");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(connection.IsConnected)
            {
                connection.Exit();
            }
            else
                MessageBox.Show("Connection could not be estabilished");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (connection.IsConnected)
                connection.Stop();
        }
    }
}
