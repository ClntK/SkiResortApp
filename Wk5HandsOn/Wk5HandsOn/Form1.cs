using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Cache;

namespace Wk5HandsOn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skiResortsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.skiResortsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.skiResortDBDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skiResortDBDataSet1.SkiResorts' table. You can move, or remove it, as needed.
            this.skiResortsTableAdapter.Fill(this.skiResortDBDataSet1.SkiResorts);
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ResortIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
            pb_alpental.Visible = false;
            pb_crystal.Visible = false;
            pb_baker.Visible = false;
            pb_stevens.Visible = false;

            string mtnID = resortIDTextBox.Text;

            if (mtnID.Length != 0)
            {
                if (mtnID is "1")
                {
                    pb_home.Visible = false;
                    pb_alpental.Visible = true;
                    pb_crystal.Visible = false;
                    pb_baker.Visible = false;
                    pb_stevens.Visible = false;
                }
                else if (mtnID is "2")
                {
                    pb_home.Visible = false;
                    pb_alpental.Visible = false;
                    pb_crystal.Visible = true;
                    pb_baker.Visible = false;
                    pb_stevens.Visible = false;
                }
                else if (mtnID is "3")
                {
                    pb_home.Visible = false;
                    pb_alpental.Visible = false;
                    pb_crystal.Visible = false;
                    pb_baker.Visible = true;
                    pb_stevens.Visible = false;
                }
                else if (mtnID is "4")
                {
                    pb_home.Visible = false;
                    pb_alpental.Visible = false;
                    pb_crystal.Visible = false;
                    pb_baker.Visible = false;
                    pb_stevens.Visible = true;
                }
                else
                {
                    pb_home.Visible = true;
                }

            }
        }

        private void ResortIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string mtnID = resortIDTextBox.Text;
                string[] ResIDArray = new string[] { "1", "2", "3", "4" };
                
                if (ResIDArray.Contains(mtnID))
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\toyma\\Documents\\02School\\05C#\\Homework\\Wk5\\Wk5HandsOn\\Wk5HandsOn\\SkiResortDB.mdf;Integrated Security=True");

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select ResortName, VerticalRise, TrailNum, LiftNum from SkiResorts where ResortID =" + mtnID + ";", con);
                    cmd.Parameters.AddWithValue(resortIDTextBox.Text, mtnID);
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        resortNameTextBox.Text = data.GetValue(0).ToString();
                        verticalRiseTextBox.Text = data.GetValue(1).ToString();
                        trailNumTextBox.Text = data.GetValue(2).ToString();
                        liftNumTextBox.Text = data.GetValue(3).ToString();
                    }
                    con.Close();

                }
                else if (!ResIDArray.Contains(mtnID))
                {
                    pb_home.Visible = true;
                    pb_alpental.Visible = false;
                    pb_crystal.Visible = false;
                    pb_baker.Visible = false;
                    pb_stevens.Visible = false;

                    resortIDTextBox.Text = "";
                    resortNameTextBox.Text = "Please enter a Resort ID of 1 - 4.";
                    verticalRiseTextBox.Text = "";
                    trailNumTextBox.Text = "";
                    liftNumTextBox.Text = "";
                }
            }
        }
    }
}

