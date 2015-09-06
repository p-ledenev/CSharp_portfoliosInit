using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace portfoliosInit
{
    public partial class ApplicationWindow : Form
    {
        private List<Portfolio> portfolios;

        public ApplicationWindow()
        {
            InitializeComponent();

            portfolios = InitDataReader.read();
            initCombobox();
        }

        private void initCombobox()
        {
            foreach (var portfolio in portfolios)
                strategyComboBox.Items.Add(portfolio.strategy);

            strategyComboBox.SelectedIndex = 0;
        }

        private void addButtonClicked(object sender, EventArgs e)
        {
            MachineForm machineForm = MachineForm.create(machineForms.Count);
            addMachineForms(new List<MachineForm>() { machineForm });
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            int k = strategyComboBox.SelectedIndex;
            portfolios[k].machines = MachinesBuilder.build(machineForms);

            InitDataReader.write(portfolios);
        }

        private void strategyComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            applyChangesToPreviousSelectedPortfolio();

            List<MachineForm> forms = MachineFormsBuilder.build(portfolios[strategyComboBox.SelectedIndex]);
            clearMachineForms();
            addMachineForms(forms);

            strategyComboBox.previousIndex = strategyComboBox.SelectedIndex;
        }

        private void applyChangesToPreviousSelectedPortfolio()
        {
            int k = strategyComboBox.previousIndex;
            if (k < 0)
                return;

            portfolios[k].machines = MachinesBuilder.build(machineForms);
        }

        private void clearMachineForms()
        {
            foreach (var form in machineForms)
                form.removeFrom(splitContainer.Panel2.Controls);

            machineForms.Clear();
        }

        private void addMachineForms(List<MachineForm> forms)
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

        private void unblockButtonClicked(object sender, EventArgs e)
        {
            portfolios = InitDataReader.read();
            foreach (var portfolio in portfolios)
                portfolio.unblockAllMachines();

            strategyComboBox.Items.Clear();
            initCombobox();

            InitDataReader.write(portfolios);
        }
    }
}
