using System;
using System.Windows.Forms;

namespace portfoliosInit
{
    public partial class AddPortfolioForm : Form
    {
        private Portfolio portfolio;
        private Boolean successInitialization;
        
        public static AddPortfolioForm add()
        {
            return new AddPortfolioForm();
        }

        public static AddPortfolioForm edit(Portfolio portfolio)
        {
            return new AddPortfolioForm(portfolio);
        }

        private AddPortfolioForm(Portfolio portfolio)
        {
            InitializeComponent();

            this.portfolio = portfolio;
           
            sieveParamBox.Text = portfolio.sieveParam.ToString().Replace(",", ".");
            fillingGapsNumberBox.Text = portfolio.fillingGapsNumber.ToString();
            securityBox.Text = portfolio.security;

            strategyComboBox.Items.AddRange(Enum.GetNames(typeof(Portfolio.Strategy)));
            strategyComboBox.SelectedItem = portfolio.strategy;
        }

        private AddPortfolioForm() : this(new Portfolio())
        {
        }

        private void buttonCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApplyClicked(object sender, EventArgs e)
        {
            String strategy;
            String security;
            double sieveParam;
            int fillingGapsNumber;

            successInitialization = false;
            try
            {
                if (securityBox.Text.Trim().Length == 0)
                    throw new Exception();

                strategy = (String) strategyComboBox.SelectedItem;
                security = securityBox.Text.Trim();
                sieveParam = Double.Parse(sieveParamBox.Text.Replace(".", ","));
                fillingGapsNumber = Int16.Parse(fillingGapsNumberBox.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Not all fields are filled with proper values");
                return;
            }

            portfolio.strategy = strategy;
            portfolio.security = security;
            portfolio.sieveParam = sieveParam;
            portfolio.fillingGapsNumber = fillingGapsNumber;

            successInitialization = true;

            buttonCloseClicked(sender, e);
        }

        public Portfolio GetPortfolio()
        {
            return portfolio;
        }

        public bool isProcessingSuccess()
        {
            return successInitialization;
            ;
        }
    }
}
