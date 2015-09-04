using System;
using System.Collections.Generic;
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

            strategyComboBox.SelectedIndex = 0;
        }

        private void addButtonClicked(object sender, EventArgs e)
        {
            MachinesForm machineForm = new MachinesForm(machineForms.Count);
            addMachineForms(new List<MachinesForm>(){machineForm});
        }

        private void applyButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void strategyComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            applyChangesToPreviousSelectedPortfolio();

            List<MachinesForm> forms = MachinesFormBuilder.build(portfolios[strategyComboBox.SelectedIndex]);
            clearMachineForms();
            addMachineForms(forms);
        }

        private void applyChangesToPreviousSelectedPortfolio()
        {
            // TODO not working
            int k =strategyComboBox.previousIndex;
        }

        private void clearMachineForms()
        {
            foreach (var form in machineForms)
                form.removeFrom(splitContainer.Panel2.Controls);

            machineForms.Clear();
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
