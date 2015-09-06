using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Forms;

namespace portfoliosInit
{
    class MachineForm
    {
        private Label statusLabel;
        private TextBox amountTextBox;
        private CheckBox deleteCheckBox;
        private TextBox depthTextBox;

        private MachineAmount buyAmount;
        private MachineAmount sellAmount;
        private MachineAmount neutralAmount;
        private int blockedAmount;

        public static MachineForm createFrom(int depth, int rowIndex, List<Machine> machines)
        {
            MachineForm form = new MachineForm();

            foreach (var machine in machines)
            {
                if (machine.position == Machine.sell)
                    form.incrementSellAmount();

                if (machine.position == Machine.buy)
                    form.incrementBuyAmount();

                if (machine.position == Machine.neutral)
                    form.incrementNeutralAmount();

                if (machine.blocked)
                    form.addBlockedAmount();
            }

            form.init(depth, rowIndex);

            return form;
        }

        public static MachineForm create(int rowIndex)
        {
            MachineForm form = new MachineForm();
            form.init(0, rowIndex);

            return form;
        }

        private MachineForm()
        {
            statusLabel = new Label();
            amountTextBox = new TextBox();
            deleteCheckBox = new CheckBox();
            depthTextBox = new TextBox();

            buyAmount = MachineAmount.buy();
            sellAmount = MachineAmount.sell();
            neutralAmount = MachineAmount.neutral();
            blockedAmount = 0;
        }

        private void init(Int32 depth, Int32 rowIndex)
        {
            int y = 40 * rowIndex + 51;

            // 
            // depthTextBox
            // 
            depthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            depthTextBox.Location = new System.Drawing.Point(29, y);
            depthTextBox.Name = "depthTextBox";
            depthTextBox.Size = new System.Drawing.Size(53, 26);
            depthTextBox.KeyPress += new KeyPressEventHandler(validateDigitKeyPressed);

            if (depth != 0)
                depthTextBox.Text = depth.ToString();

            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            statusLabel.Location = new System.Drawing.Point(222, y);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(163, 20);

            if (getStatus() != null)
                statusLabel.Text = getStatus();

            // 
            // amountTextBox
            // 
            amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            amountTextBox.Location = new System.Drawing.Point(125, y);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new System.Drawing.Size(61, 26);
            amountTextBox.KeyPress += new KeyPressEventHandler(validateDigitKeyPressed);

            if (getAmount() != 0)
                amountTextBox.Text = getAmount().ToString();

            // 
            // deleteCheckBox
            // 
            deleteCheckBox.AutoSize = true;
            deleteCheckBox.Location = new System.Drawing.Point(436, y);
            deleteCheckBox.Name = "deleteCheckBox";
            deleteCheckBox.Size = new System.Drawing.Size(15, 14);
            deleteCheckBox.UseVisualStyleBackColor = true;
        }

        private void validateDigitKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private String getStatus()
        {
            String response = null;

            response += buyAmount.print() + " ";
            response += sellAmount.print() + " ";
            response += neutralAmount.print() + " ";

            if (blockedAmount != 0)
                response += blockedAmount + "Blocked";

            return response;
        }

        public void addTo(Control.ControlCollection controls)
        {
            controls.Add(depthTextBox);
            controls.Add(statusLabel);
            controls.Add(amountTextBox);
            controls.Add(deleteCheckBox);
        }

        public void removeFrom(Control.ControlCollection controls)
        {
            controls.Remove(depthTextBox);
            controls.Remove(statusLabel);
            controls.Remove(amountTextBox);
            controls.Remove(deleteCheckBox);
        }

        public int getDepth()
        {
            return Int32.Parse(depthTextBox.Text);
        }

        private int getAmount()
        {
            return buyAmount.amount + sellAmount.amount + neutralAmount.amount;
        }

        private int getTextBoxAmount()
        {
            return Int32.Parse(amountTextBox.Text);
        }

        public bool isDeleted()
        {
            return deleteCheckBox.Checked;
        }

        public bool isValid()
        {
            return !String.IsNullOrEmpty(depthTextBox.Text) && !String.IsNullOrEmpty(amountTextBox.Text) && !isDeleted();
        }

        public void incrementBuyAmount()
        {
            buyAmount.increment();
        }

        public void incrementSellAmount()
        {
            sellAmount.increment();
        }

        public void incrementNeutralAmount()
        {
            neutralAmount.increment();
        }

        public void addBlockedAmount()
        {
            blockedAmount++;
        }

        public List<Machine> asMachines()
        {
            List<Machine> machines = new List<Machine>();

            machines.AddRange(buyAmount.asMachines(getDepth()));
            machines.AddRange(sellAmount.asMachines(getDepth()));
            machines.AddRange(neutralAmount.asMachines(getDepth()));

            return machines;
        }

        public void applyChanges()
        {
            int newAmount = getTextBoxAmount();
            int amount = getAmount();

            if (amount == getTextBoxAmount())
                return;

            if (newAmount > amount)
            {
                neutralAmount.add(newAmount - amount);
                return;
            }

            int dev = amount - newAmount;

            while (neutralAmount.decrease() && dev > 1)
                dev--;

            while (buyAmount.decrease() && dev > 1)
                dev--;

            while (sellAmount.decrease() && dev > 1)
                dev--;
        }
    }
}
