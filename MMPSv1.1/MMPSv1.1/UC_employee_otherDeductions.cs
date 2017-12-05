using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPSv1._1
{
    public partial class UC_employee_otherDeductions : UserControl
    {
        OT_phic_contribution phic = new OT_phic_contribution();
        OT_tin tin = new OT_tin();
        OT_vehicle_plan vehicle = new OT_vehicle_plan();
        OT_hmo hmo = new OT_hmo();
        OT_cashadvance ca = new OT_cashadvance();
        OT_uniform uniform = new OT_uniform();
        OT_eggs eggs = new OT_eggs();
        OT_health_card hcard = new OT_health_card();


        public UC_employee_otherDeductions()
        {
            InitializeComponent();

            phic.Name = "PHIC";
            phic.Dock = DockStyle.Fill;

            tin.Name = "TIN";
            tin.Dock = DockStyle.Fill;

            vehicle.Name = "VEHICLE";
            vehicle.Dock = DockStyle.Fill;

            hmo.Name = "HMO";
            hmo.Dock = DockStyle.Fill;

            ca.Name = "CA";
            ca.Dock = DockStyle.Fill;

            uniform.Name = "UNIFORM";
            uniform.Dock = DockStyle.Fill;

            eggs.Name = "EGGS";
            eggs.Dock = DockStyle.Fill;

            hcard.Name = "HCARD";
            hcard.Dock = DockStyle.Fill;


            changing_panel.Controls.Add(phic);
            changing_panel.Controls.Add(tin);
            changing_panel.Controls.Add(vehicle);
            changing_panel.Controls.Add(hmo);
            changing_panel.Controls.Add(ca);
            changing_panel.Controls.Add(uniform);
            changing_panel.Controls.Add(eggs);
            changing_panel.Controls.Add(hcard);

            HandleControl("PHIC");
        }
        void HandleControl(string cntrlName)
        {
            changing_panel.Controls[cntrlName].BringToFront();
        }

        private void pHICContributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("PHIC");
        }

        private void tINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("TIN");
        }

        private void vehiclePlaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("VEHICLE");
        }

        private void hMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("HMO");
        }

        private void cashAdvancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("CA");
        }

        private void uniformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("UNIFORM");
        }

        private void employeeEggsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("EGGS");
        }

        private void healthCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleControl("HCARD");
        }


    }
}
