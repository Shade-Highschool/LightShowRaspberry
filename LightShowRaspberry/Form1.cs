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

            ftpClient = new SftpClient(RaspberryIp, loginName, loginPassword);
            sshClient = new SshClient(RaspberryIp, loginName, loginPassword);
        }

        string RaspberryIp = "192.168.0.105";

        string workingDirectory = "/home/pi/Music/";
        string loginName = "pi";
        string loginPassword = "raspberry";

        SftpClient ftpClient;
        SshClient sshClient;

        private void GetMusicVolume()
        {
            if (TryConnect(sshClient))
            {
                var response = sshClient.RunCommand("awk -F\"[][]\" '/dB/ { print $2 }' <(amixer sget PCM)");
                string result = response.Result;
                result = result.Remove(result.Length - 2);

                int value = Convert.ToInt32(result);
                trackBar1.Value = value;

                sshClient.Disconnect();
            }
        }


        private void GetMusic()
        {
            if (TryConnect(ftpClient))
            {
                var fileList = ftpClient.ListDirectory(ftpClient.WorkingDirectory).Where(x => x.Name != ".." && x.Name != ".").Select(s => s.Name);

                listBox1.Items.Clear();
                foreach (var item in fileList)
                {
                    listBox1.Items.Add(item);
                }
                label1.Text = "Connection succesful.";
                ftpClient.Disconnect();
            }
            else
                MessageBox.Show("Cannot connect");
        }

        private bool TryConnect(SftpClient ftpClient)
        {
            try
            {
                ftpClient.Connect();
                ftpClient.ChangeDirectory(workingDirectory);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool TryConnect(SshClient sshClient)
        {
            try
            {
                sshClient.Connect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetMusic();
            GetMusicVolume();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string uploadFile = "";
            string uploadFileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadFile = openFileDialog1.FileName;
                uploadFileName = Path.GetFileName(uploadFile);
            }
            else
                return;

            if (TryConnect(ftpClient))
            {
                if (!ftpClient.Exists(uploadFileName))
                {
                    using (var fileStream = new FileStream(uploadFile, FileMode.Open))
                    {
                        ftpClient.BufferSize = 4 * 1024; // bypass Payload error large files
                        ftpClient.UploadFile(fileStream, uploadFileName);
                    }

                    listBox1.Items.Add(uploadFileName);
                }
                else
                    MessageBox.Show("Song is already there");

                ftpClient.Disconnect();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TryConnect(ftpClient))
            {
                string listboxSong = listBox1.SelectedItem.ToString();
                ftpClient.DeleteFile(listboxSong);
                listBox1.Items.Remove(listboxSong);
                ftpClient.Disconnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (TryConnect(sshClient))
                {

                    ShellStream shellStream = sshClient.CreateShellStream("Tail", 80, 24, 800, 600, 1024);
                    shellStream.WriteLine("sudo amixer set PCM " + trackBar1.Value + "%");
                    shellStream.WriteLine("sudo python /home/pi/lightshow/py/synchronized_lights.py --file=/home/pi/Music/\"" + listBox1.SelectedItem.ToString() + "\"");
                    MessageBox.Show("Song is playing. To stop, close this dialog");
                    shellStream.Write("\x003");
                    shellStream.Close();
                    // var terminal = sshClient.RunCommand("sudo python /home/pi/lightshow/py/synchronized_lights.py --file=/home/pi/Music/" + listBox1.SelectedItem.ToString());
                    // MessageBox.Show(terminal.Result);

                    sshClient.Disconnect();
                }
            }
            else
                MessageBox.Show("Song isnt selected");
        }
    }
}
