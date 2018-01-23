/*
 David Wilkins
 CIS 229 C# II
 Assignment A - Submarine Fleet
 01/15/2018

 this program simulates a submarine fleet, with different headings, speed, location
 , weapons and reactor status. It allows a user to select a sub from a fleet list and 
 perform appropriate actions.

 */

 /*TODO -- 
  * need to fix remove/edit of subs, using List/tied to combo box selected index. 
    add confirmation before deleting a sub, or firing a torpedo. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submarines


{
    public partial class Form1 : Form
    {
        //USES A INCREMENT COUNTER TO UNIQUELY ID THE SUBS AS THEY ARE CREATED.
        public int id = 100;
        public Form1()
        {
            InitializeComponent();
        }
        //FILL THE COMBO BOXES ON LOAD, AND DISABLE THE EDIT CONTROLS UNTIL A SUB IS SELECTED
        private void Form1_Load(object sender, EventArgs e)
        {
            groupControls.Enabled = false;
            cmbHeading.Items.Add("North");
            cmbHeading.Items.Add("South");
            cmbHeading.Items.Add("East");
            cmbHeading.Items.Add("West");


            string fullID = "SSN-" + id;
            id++;

            Submarine sub1 = new Submarine(fullID, "USS Nicholas");
            fullID = "SSN-" + id;
            id++;
            Submarine sub2 = new Submarine(fullID, "USS Bradley");
            fullID = "SSN-" + id;
            id++;
            Submarine sub3 = new Submarine(fullID, "USS Molinda");
            fullID = "SSN-" + id;
            id++;
            /*
            lvFleet.Items.Add(sub1.myString(sub1));
            lvFleet.Items.Add(sub2.myString(sub2));
            lvFleet.Items.Add(sub3.myString(sub3));
            */
            cmbFleet.Items.Add(sub1.myString(sub1));
            cmbFleet.Items.Add(sub2.myString(sub2));
            cmbFleet.Items.Add(sub3.myString(sub3));

            Fleet.subFleet.Add(sub1);
            Fleet.subFleet.Add(sub2);
            Fleet.subFleet.Add(sub3);


            lblOutput.Text = "Initial fleet created";


        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
        //CREATE A NEW SUB OBJECT AND ADD IT TO THE FLEET/CMB
        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                string fullID;
                string userName = "USS " + txtInput.Text;
                fullID = "SSN-" + id;
                id++;
                Submarine sub = new Submarine(fullID, userName);
                lvFleet.Items.Add(sub.myString(sub));
                cmbFleet.Items.Add(sub.myString(sub));
                Fleet.subFleet.Add(sub);
                lblOutput.Text = "New Submarine added to the fleet.";
            }
            else
            {
                lblOutput.Text = "You must name your sub before adding it to the fleet.";
                txtInput.Focus();
            }
        }
        // NOT USED
        private void lvFleet_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        //REMOVE SELECTED SUB FROM THE FLEET LIST AND CMB

        private void btnRemove_Click(object sender, EventArgs e)
        {
          //  lvFleet.Items.Remove(lvFleet.SelectedItems[0]);
            cmbFleet.Items.Remove(cmbFleet.SelectedItem);
            cmbFleet.ResetText();

            Fleet.subFleet.RemoveAt(cmbFleet.SelectedIndex);
            groupControls.Enabled = false;
        }

        //WHEN SELECTED , TURN THE EDIT CONTROLS ON 

        private void cmbFleet_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupControls.Enabled = true;

            txtOutput.Text = Fleet.subFleet[0].description(Fleet.subFleet[0]);
            


        }

        //TODO : finish allowing edits to the selected sub
        // need to access sub X using the cmb. fleet array

        private void btnChanges_Click(object sender, EventArgs e)
        {
            if (rbOn.Checked == true )
            {

            }
            else
            {

            }

            
        }

        private void groupControls_Enter(object sender, EventArgs e)
        {

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            //are you sure you want to fire ...
        }
    }
}
