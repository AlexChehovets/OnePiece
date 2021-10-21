using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    public partial class MainForm : Form
    {
        [Serializable]
        public class Human
        {
            private double rist, vik, masa;
            public Human(double rist, double vik, double masa)
            {
                this.rist = rist;
                this.vik = vik;
                this.masa = masa;
            }
            public double Getrist() { return rist; }
            public double Getvik() { return vik; }
            public double Getmasa() { return masa; }
        }

        Human human = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, human);
            }
        }
    }
}
