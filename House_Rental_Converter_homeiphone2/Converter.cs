using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rental_Converter_homeiphone2
{
    public partial class Converter : Form
    {

        double prepeyment1, prepeyment2;
        double rent1, rent2;
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rent_to_prepeyment_btn_Click(object sender, EventArgs e)
        {
            rent1 = Convert.ToInt32(rent_num.Value);
            prepeyment1 = rent1 * 100;
            prepeyment1 = prepeyment1 / 3;
            prepayment_lbl.Text = prepeyment1.ToString();
        }

        private void prepeyment_to_rent_btn_Click(object sender, EventArgs e)
        {
            prepeyment2 = Convert.ToDouble(prepeyment_number.Value);
            rent2 = prepeyment2 * 3;
            rent2 = rent2 / 100;
            rent_lbl.Text = rent2.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            i = comboBox1.SelectedIndex;
            //comboBox1.Items.RemoveAt(i);
            if (i == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                rent1 = 0;
                rent2 = 0;
                prepeyment1 = 0;
                prepeyment2 = 0;
                prepayment_lbl.Text = "";
                rent_lbl.Text = "";
                rent_num.Value = 0;
                prepeyment_number.Value = 0;
                total_txt.Text = "جمع";

            }
            else if (i == 1)
            {

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                rent2 = rent2 + rent1;
                total_txt.Text = Convert.ToString(rent2);
                rent1 = 0;
                rent2 = 0;
            }
            else if (i == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                prepeyment2 = prepeyment2 + prepeyment1;
                total_txt.Text = Convert.ToString(prepeyment2);
                prepeyment1 = 0;
                prepeyment2 = 0;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            this.linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the LinkData property of the Link Object.
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("www"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
            Process.Start(new ProcessStartInfo("http://www.homeiphone.ir") { UseShellExecute = true });
        }
    }
}
