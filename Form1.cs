using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        Queue<string> q = new Queue<string>();
        string[] Musics = new string[10000];
        int cont;
        string a;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/adith/OneDrive/Documents/music.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cont = 0;
            con.Open();
            string cmd1 = "SELECT * FROM music;";
            
            OleDbCommand cmd = new OleDbCommand(cmd1, con);
            OleDbDataReader read = cmd.ExecuteReader();
            read.Read();
            Musics[cont] = read[2].ToString();
            Ltb_Musics.Items.Add(read[1].ToString());
            cont += 1;
            foreach (var a in read)
            {
                Musics[cont] = read[2].ToString();
                Ltb_Musics.Items.Add(read[1].ToString());
                cont += 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }
          

            catch (System.IndexOutOfRangeException) {

                MessageBox.Show("Select a Song", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();

        }

        private void resumebtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK) 
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (Ltb_Musics.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        var r = open.SafeFileNames.GetValue(i);
                        a = Convert.ToString(r);
                        q.Enqueue(a);
                        Musics[cont] = open.FileNames.GetValue(i).ToString();
                        cont += 1;
                       
                    }
                }
                int contt = cont - 1;
                int flag = 0;
                foreach (string id in q)
                {
                    string cmd1 = "SELECT * FROM music where music_name='"+id+"';";
                    OleDbCommand cmd = new OleDbCommand(cmd1, con);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read.Read();
                    if (read.Read())
                    {
                        flag = 1;
                        MessageBox.Show("Song Already exits", "Congrats");
                    }
                    else
                    {
                        OleDbCommand cm = con.CreateCommand();
                        cm.CommandText = "Insert into music(music_name,path)Values('" + id + "','" + Musics[contt] + "');";
                        contt += 1;
                        cm.Connection = con;
                        cm.ExecuteNonQuery();
                    }
                    //MessageBox.Show("Record Submitted", "Congrats");
                    
                }
                if (flag == 0)
                {
                    foreach (string id in q)
                    {
                        Ltb_Musics.Items.Add(id);

                    }
                    MessageBox.Show("Songs Added Successfully", "Inserted");
                }
            }

          
        }

        private void Ltb_Musics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fastforwardbtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.fastForward();

        }

        private void TimerTick_CheckedChanged(object sender, EventArgs e)
        {

        }

 

        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (Ltb_Musics.SelectedIndex != 0) {

                Ltb_Musics.SetSelected(Ltb_Musics.SelectedIndex - 1, true);
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
            }
            else
            {
                Ltb_Musics.SelectedIndex = Ltb_Musics.Items.Count-1;
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {     
            if (Ltb_Musics.SelectedIndex != Ltb_Musics.Items.Count - 1)
            {
                Ltb_Musics.SetSelected(Ltb_Musics.SelectedIndex + 1, true);
                    Player.URL = Musics[Ltb_Musics.SelectedIndex];
                    timer1.Start();                
            }
            else 
            {
                Ltb_Musics.SelectedIndex = 0;
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }



        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Ltb_Musics.SetSelected(0, true);
            Player.URL = Musics[Ltb_Musics.SelectedIndex];
        }

        private void endbtn_Click(object sender, EventArgs e)
        {
            Ltb_Musics.SetSelected(Ltb_Musics.Items.Count - 1, true);
            Player.URL = Musics[Ltb_Musics.SelectedIndex];
        }

        private void lblduration_Click(object sender, EventArgs e)
        {

        }


        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_duration_Click(object sender, EventArgs e)
        {

        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void shuffle_Click(object sender, EventArgs e)
        {

        }

        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
        }

        
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String[] arr = q.ToArray();
            String search = searchtxt.Text;

            var items = (from a in arr
                         where a.StartsWith(search)
                         select a).ToArray<String>();

            Ltb_Musics.Items.Clear();
            Ltb_Musics.Items.AddRange(items);

       }

        private void Ltb_Musics_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = Musics[Ltb_Musics.SelectedIndex];
            OleDbCommand cm = con.CreateCommand();
            cm.CommandText = "Delete FROM music where path='" + id + "';";
            cm.Connection = con;
            cm.ExecuteNonQuery();
            MessageBox.Show("Song Deleted Successfully", "Congrats");

            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }
    }
}
