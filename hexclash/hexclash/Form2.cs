using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hexclash
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public string LabelText
        {
            get
            {
                return this.NumScore.Text;
            }
            set
            {
                this.NumScore.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = 0;
            List<Player> players = new List<Player>();
            

            XmlSerializer XMLSerializer = new XmlSerializer(typeof(List<Player>));
            StreamReader streamReader1 = new StreamReader("Scores.xml");
            players = (List<Player>)XMLSerializer.Deserialize(streamReader1);
            streamReader1.Close();
            players.Add(new Player(textBox1.Text, int.Parse(NumScore.Text)));
            Stream stream = File.OpenWrite("Scores.xml");
            XmlSerializer XML = new XmlSerializer(typeof(List<Player>));
            XML.Serialize(stream, players);
            stream.Close();
            XmlSerializer XMLSer = new XmlSerializer(typeof(List<Player>));
            StreamReader streamReader = new StreamReader("Scores.xml");
            players = (List<Player>)XMLSer.Deserialize(streamReader);
            streamReader.Close();
            int score = int.Parse(NumScore.Text);
            foreach (Player p in players)
            {
                if (p.Score > score)
                {
                    ind++;
                    break;
                }
            }
            if (ind == 0)
            {
                MessageBox.Show("New High Score!!!");
            }
            Environment.Exit(0);
        }
    }
}
