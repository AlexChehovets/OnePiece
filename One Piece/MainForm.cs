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
        double vaga, idealmasa = 0, zhurnist = 0, schilnist, headp, chestp, handp, legsp, obem, plozhaofbody, g = 9.8, rist = 0, masa = 0, rec;

        private void ClearButton_Click(object sender, EventArgs e)
        {
            VagaTextBox.Text = "";
            IdealmasaTextBox.Text = "";
            ZhurnistTextBox.Text = "";
            SchilnistTextBox.Text = "";
            ObemTextBox.Text = "";
            PloshaTextBox.Text = "";
            GrowTextBox.Text = "";
            AgeTextBox.Text = "";
            WeightTextBox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            MenPictureBox.Visible = false;
            WomenPictureBox.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
        }

        int vik;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                rist = Convert.ToInt32(GrowTextBox.Text);
                vik = Convert.ToInt32(AgeTextBox.Text);
                masa = Convert.ToInt32(WeightTextBox.Text);

                if (rist > 272 || masa > 635 || vik > 122)
                {
                    MessageBox.Show("Ви ввели надто великі показники", "Похибка");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    GrowTextBox.Text = "";
                    AgeTextBox.Text = "";
                    WeightTextBox.Text = "";
                    return;
                }
                else if (rist < 67 || masa < 20 || vik < 6)
                {
                    MessageBox.Show("Ви ввели надто малі показники", "Похибка");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    GrowTextBox.Text = "";
                    AgeTextBox.Text = "";
                    WeightTextBox.Text = "";
                    return;
                }

                vaga = masa * g;

                if (radioButton1.Checked == true)
                {
                    MenPictureBox.Visible = true;
                    idealmasa = (rist * 3 - 450 + vik) * 0.25 + 45;
                    zhurnist = (masa - idealmasa) / masa * 100 + 15;
                    if (masa > idealmasa)
                    {
                        ToolTip t = new ToolTip();
                        t.SetToolTip(MenPictureBox, "Рекомендація:\nВам слід схуднути");
                    }
                    else if (masa == idealmasa)
                    {
                        ToolTip t = new ToolTip();
                        t.SetToolTip(MenPictureBox, "Рекомендація:\nВи у формі так держати");
                    }
                    else
                    {
                        ToolTip t = new ToolTip();
                        t.SetToolTip(MenPictureBox, "Рекомендація:\nВам слід набрати вагу");
                    }
                }
                else
                {
                    WomenPictureBox.Visible = true;
                    idealmasa = (rist * 3 - 450 + vik) * 0.225 + 40.4;
                    zhurnist = (masa - idealmasa) / masa * 100 + 22;
                    if (masa > idealmasa)
                    {
                        ToolTip t = new ToolTip();
                        t.SetToolTip(WomenPictureBox, "Рекомендація:\nВам слід схуднути");
                    }
                    else if (masa == idealmasa)
                    {
                        ToolTip t = new ToolTip();
                        t.SetToolTip(WomenPictureBox, "Рекомендація:\nВи у формі так держати");
                    }
                    else
                    {
                        ToolTip t = new ToolTip();
                        t.SetToolTip(WomenPictureBox, "Рекомендація:\nВам слід набрати вагу");
                    }
                }

                schilnist = 8.90 * zhurnist + 11 * (100 - zhurnist);

                obem = masa / schilnist;

                plozhaofbody = Math.Pow(masa * 1000, (Math.Log(1 / masa) + 35.75) / 53.2) * Math.Pow(rist, 0.3) / 3118.2;

                headp = plozhaofbody * 0.09;
                chestp = plozhaofbody * 0.19;
                handp = plozhaofbody * 0.29;
                legsp = plozhaofbody * 0.43;

                VagaTextBox.Text = vaga.ToString();
                IdealmasaTextBox.Text = idealmasa.ToString();
                ZhurnistTextBox.Text = zhurnist.ToString();
                SchilnistTextBox.Text = schilnist.ToString();
                ObemTextBox.Text = obem.ToString();
                PloshaTextBox.Text = plozhaofbody.ToString();
                label18.Text = chestp.ToString();
                label19.Text = handp.ToString();
                label22.Text = headp.ToString();
                label23.Text = legsp.ToString();

                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;

                human = new Human(rist, vik, masa);
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, human);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
