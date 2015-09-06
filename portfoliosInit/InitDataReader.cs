using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace portfoliosInit
{
    class InitDataReader
    {
        public static String fileName = "data/init.dat";

        public static List<Portfolio> read()
        {
            if (!File.Exists(fileName))
                createDefaultInitFile();

            String[] lines = File.ReadAllLines(fileName);

            List<Portfolio> portfolios = new List<Portfolio>();
            Portfolio portfolio = null;
            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line))
                    continue;

                String[] attrs = line.Split(';');

                int value;
                if (!Int32.TryParse(attrs[0], out value))
                {
                    portfolio = new Portfolio(attrs[0], attrs[1], Double.Parse(attrs[2].Replace('.', ',')));
                    portfolios.Add(portfolio);
                    continue;
                }

                portfolio.add(new Machine(value, attrs[1], (Int32.Parse(attrs[2]) == 1)));
            }

            return portfolios;
        }

        public static void write(List<Portfolio> portfolios)
        {
            StreamWriter file = new StreamWriter(fileName);

            foreach (var portfolio in portfolios)
            {
                file.Write(portfolio.print() + "\n");
                foreach (var machine in portfolio.machines)
                    file.Write(machine.print() + "\n");
            }

            file.Close();
        }

        private static void createDefaultInitFile()
        {
            StreamWriter file = new StreamWriter(fileName);

            addPortfolioTo(file, "USD-9.15;AveragingStrategy;0.0145");
            addPortfolioTo(file, "USD-9.15;ApproximationStrategy;0.0145");

            file.Close();
        }

        private static void addPortfolioTo(StreamWriter file, String portfolio)
        {
            file.Write(portfolio + "\n", 0, portfolio + "\n");
            for (int i = 0; i < 5; i++)
                file.Write((50 + 25 * i) + ";N;0\n");
        }
    }
}
