using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = " ";
        bool enter_value = false;
        string firstnum, secondnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = " ";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;

            }

            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)

            {
                btnEquals.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = result + "    " + operation;
            }

            else

            {

                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                enter_value = true;
                txtDisplay.Text = " ";
                lblShowOps.Text = result + "    " + operation;
            }

            firstnum = lblShowOps.Text;




        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondnum = txtDisplay.Text;
            lblShowOps.Text = " ";
            switch (operation)
            {

                case " + ":
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;


                case " - ":
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;

                case " * ":
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;

                case " / ":
                    txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;


            }
            result = double.Parse(txtDisplay.Text);
            operation = "";

            //=============================================================================

            btnClearHistory.visible = true;
            rtbDisplayHistory.AppendText(firstnum + "  " + secondnum + " = " + "\n");
            rtbDisplayHistory.AppendText(" \n\t" + TxtDisplay.Text + "\n\n");
            lblHistoryDisplay.Text = "";

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }
        private void btnClearHistory_Click(objectsender, EventArgs e)
        {

            rtbDisplayHistory.Clear();
            if (lblHistoryDisplay.Text == "")
            {

                lblHistoryDIsplay.Text = "There;s no history yet";

            }

            btnClearHistory.Visible = false;
            rtbDisplayHistory.ScrollBars = 0;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void form1_Load(object sender, EventArgs e)
        {
            TreeView1.Visible = false;
        }
        privatevoid label1_Click(object sender, EventArgs e)
        {
            TreeView1.Visible = true;
        }
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node3")
            {
                LblTitle.Text = "Standard";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node39")
            {
                LblTitle.Text = "Scientific";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node5")
            {
                LblTitle.Text = "Programmer";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node11")
            {
                lblTitle.Text = "Currency";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node13")
            {
                LblTitle.Text = "volume";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node15")
            {
                LblTitle.Text = "lenght";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node17")
            {
                LblTitle.Text = "Weight and Mass";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node19")
            {
                LblTitle.Text = "Temprature";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node21")
            {
                LblTitle.Text = "Energy";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node23")
            {
                LblTitle.Text = "Area";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node15")
            {
                LblTitle.Text = "Speed";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node27")
            {
                LblTitle.Text = "Time";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node29")
            {
                LblTitle.Text = "Power";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node31")
            {
                LblTitle.Text = "Presure";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node35")
            {
                LblTitle.Text = "Angle";
                TreeView1.Visible = false;
            }
            if (e.Node.Name == "Node37")
            {
                LblTitle.Text = "About";
                TreeView1.Visible = false;
            }
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text.Lenght > 0)

            {

                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == " ")

            {

                txtDisplay.Text = "0";

            }
        }
    }
}
