using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace portfoliosInit
{
    public partial class ApplicationForm : Form
    {
        private List<Portfolio> portfolios;

        public ApplicationForm()
        {
            InitializeComponent();

            portfolios = InitDataReader.read();

            foreach (var portfolio in portfolios)
                strategyComboBox.Items.Add(portfolio.strategy);

            strategyComboBox_SelectedIndexChanged(null, null);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MachinesForm machineForm = new MachinesForm(machineForms.Count);
            addMachineForms(new List<MachinesForm>(){machineForm});
        }

        private void strategyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MachinesForm> forms = MachinesFormBuilder.build(portfolios[strategyComboBox.SelectedIndex]);
            addMachineForms(forms);
        }

        private void addMachineForms(List<MachinesForm> forms)
        {
            machineForms.AddRange(forms);

            foreach (var form in forms)
                form.addTo(splitContainer.Panel2.Controls);

            setAddButtonPosition();
        }

        private void setAddButtonPosition()
        {
            addButton.Location = new Point(29, machineForms.Count * 40 + 60);
        }
    }
}
