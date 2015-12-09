using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace portfoliosInit
{
    public partial class ApplicationForm : Form
    {
        private List<Portfolio> portfolios;
        private List<MachineForm> machineForms;

        public ApplicationForm()
        {
            InitializeComponent();

            machineForms = new List<MachineForm>();
            setAddButtonPosition();

            portfolios = InitDataReader.read();
            initCombobox();
        }

        private void initCombobox()
        {
            clearAllData();

            foreach (var portfolio in portfolios)
                strategyComboBox.Items.Add(portfolio.getPortfolioTitle());

            if (portfolios.Count > 0)
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

            initCombobox();

            InitDataReader.write(portfolios);
        }

        private void delStrategyButton_Click(object sender, EventArgs e)
        {
            if (strategyComboBox.SelectedIndex < 0)
                return;

            DialogResult result = MessageBox.Show("Delete " + strategyComboBox.Text, "Confirm delete",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            portfolios.RemoveAt(strategyComboBox.SelectedIndex);

            initCombobox();
        }

        private void clearAllData()
        {
            clearMachineForms();

            strategyComboBox.Items.Clear();
            strategyComboBox.Text = "";
            strategyComboBox.previousIndex = -1;

            setAddButtonPosition();
        }

        private void editStrategyButtonClicked(object sender, EventArgs e)
        {
            if (strategyComboBox.SelectedIndex < 0 || portfolios.Count < 0)
                return;

            AddPortfolioForm form = AddPortfolioForm.edit(portfolios[strategyComboBox.SelectedIndex]);

            process(form);
        }

        private void addStrategyButtonClicked(object sender, EventArgs e)
        {
            AddPortfolioForm form = AddPortfolioForm.add();

            process(form);
        }

        private void process(AddPortfolioForm form)
        {
            form.ShowDialog();

            if (!form.isProcessingSuccess())
                return;

            Portfolio portfolio = form.GetPortfolio();

            if (!portfolios.Contains(portfolio))
                portfolios.Add(portfolio);

            initCombobox();
            strategyComboBox.SelectedIndex = portfolios.IndexOf(portfolio);
        }
    }
}
