using Microsoft.Msagl.GraphViewerGdi;
using System.Media;
using System.Diagnostics;

namespace BingSlamet
{
    public partial class Main : Form
    {
        SoundPlayer errorsound = new SoundPlayer("./Resources/errorParah.wav");
        SoundPlayer warning = new SoundPlayer("./Resources/warning.wav");
        SoundPlayer ketemu = new SoundPlayer("./Resources/suaraKetemu.wav");
        SoundPlayer click = new SoundPlayer("./Resources/click.wav");
        WMPLib.WindowsMediaPlayer startupSound = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer backgroundSong = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer klik = new WMPLib.WindowsMediaPlayer();
        private static List<String> path = new List<String>();
        private static List<Label> links = new List<Label>();
        public GViewer viewer = new GViewer();

        public Main()
        {
            startupSound.URL = @"./Resources/windowsStartup.wav";
            InitializeComponent();
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            comboBox1.SelectedIndex = 0;
            backgroundSong.URL = @"./Resources/newbacksound.wav";
            backgroundSong.settings.volume = 60;
            klik.URL = @"./Resources/click.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextStartingDir.Text.ToString() == "\r\n\r\n")
            {
                klik.controls.play();
                warning.Play();
                Form2 f2 = new Form2();
                f2.StartPosition = FormStartPosition.CenterParent;
                f2.ShowDialog();
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                klik.controls.play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                try
                {
                    Search test = new(dir, filename);
                    test.bfs_search(0);
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    double realTime = test.stopwatch.Elapsed.TotalSeconds - (0.1 * (test.tree.Count()-1));
                    textTimeElapsed.Text = "Time Elapsed: " + realTime;
                    if (path.Count() == 0)
                    {
                        klik.controls.play();
                        warning.Play();
                        Form4 f4 = new Form4();
                        f4.StartPosition = FormStartPosition.CenterParent;
                        f4.ShowDialog();
                    }
                    else
                    {
                        ketemu.Play();
                    }
                }
                catch {
                    errorsound.Play();
                }

            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "DFS")
            {
                klik.controls.play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                try
                {
                    Search test = new(dir, filename);
                    test.dfs_search(0);
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    double realTime = test.stopwatch.Elapsed.TotalSeconds - (0.1 * (test.tree.Count() - 1));
                    textTimeElapsed.Text = "Time Elapsed: " + realTime;
                    if (path.Count() == 0)
                    {
                        klik.controls.play();
                        warning.Play();
                        Form4 f4 = new Form4();
                        f4.StartPosition = FormStartPosition.CenterParent;
                        f4.ShowDialog();
                    }
                    else
                    {
                        ketemu.Play();
                    }
                }
                catch { errorsound.Play(); }
            }
            else
            {
                klik.controls.play();
                warning.Play();
                Form3 f3 = new Form3();
                f3.StartPosition = FormStartPosition.CenterParent;
                f3.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ouputPanel.SuspendLayout();
            ouputPanel.Controls.Add(viewer);
            ouputPanel.ResumeLayout();
            ouputPanel.Show();
            if (TextStartingDir.Text.ToString() == "\r\n\r\n")
            {
                klik.controls.play();
                warning.Play();
                Form2 f2 = new Form2();
                f2.StartPosition = FormStartPosition.CenterParent;
                f2.ShowDialog();
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                klik.controls.play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                Search test = new(dir, filename);
                try
                {
                    test.bfs_search(1);
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    double realTime = test.stopwatch.Elapsed.TotalSeconds - (0.1 * (test.tree.Count() - 1));
                    textTimeElapsed.Text = "Time Elapsed: " + realTime;
                    if (path.Count() == 0)
                    {
                        klik.controls.play();
                        warning.Play();
                        Form4 f4 = new Form4();
                        f4.StartPosition = FormStartPosition.CenterParent;
                        f4.ShowDialog();
                    }
                    else
                    {
                        ketemu.Play();
                    }
                }
                catch { errorsound.Play(); }
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "DFS")
            {
                klik.controls.play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                try
                {

                    Search test = new(dir, filename);
                    test.dfs_search(1);
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    double realTime = test.stopwatch.Elapsed.TotalSeconds - (0.1 * (test.tree.Count() - 1));
                    textTimeElapsed.Text = "Time Elapsed: " + realTime;
                    if (path.Count() == 0)
                    {
                        klik.controls.play();
                        warning.Play();
                        Form4 f4 = new Form4();
                        f4.StartPosition = FormStartPosition.CenterParent;
                        f4.ShowDialog();
                    }
                    else
                    {
                        ketemu.Play();
                    }
                }
                catch { errorsound.Play(); }
            }
            else
            {
                klik.controls.play();
                warning.Play();
                Form3 f3 = new Form3();
                f3.StartPosition = FormStartPosition.CenterParent;
                f3.ShowDialog();
            }
        }
        private void makeLinks(List<String> directory)
        {
            linkBox.Items.Clear();
            foreach (String item in path)
            {
                Label link = new Label();
                link.Text = item;
                link.ForeColor = Color.Blue;
                linkBox.Items.Add(item);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() != "--Select--")
                {
                klik.controls.play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            klik.controls.play();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TextStartingDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Type Filename")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Type Filename";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Click_OnMouseDown(object sender, MouseEventArgs e)
        {
            klik.controls.play();
        }

        private void link_Click(object sender, EventArgs e)
        {
            var lb = (ListBox)sender;
            var dir = (String)lb.SelectedItem;
            string path = dir.Substring(0, dir.LastIndexOf('\\'));
            Process.Start(new ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            });
        }



        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonbaru_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backgroundSong.controls.pause();
            tombolOffkeren.Visible = true;
            audioOnKeren.Visible = false;
        }

        private void tombolOffkeren_Click(object sender, EventArgs e)
        {
            backgroundSong.controls.play();
            tombolOffkeren.Visible = false;
            audioOnKeren.Visible = true;
        }

        private void browseFolderBaru_Click(object sender, EventArgs e)
        {

        }
    }
}