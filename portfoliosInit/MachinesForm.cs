using System;
using System.Windows.Forms;

namespace portfoliosInit
{
    class MachinesForm
    {
        private Label statusLabel;
        private TextBox amountTextBox;
        private CheckBox deleteCheckBox;
        private TextBox depthTextBox;

        public MachinesForm(int index) : this(null, null, null, index)
        {      
        }

        public MachinesForm(String depth, String amount, String status, Int32 index)
        {
            statusLabel = new Label();
            amountTextBox = new TextBox();
            deleteCheckBox = new CheckBox();
            depthTextBox = new TextBox();

            init(depth, amount, status, index);
        }

        private void init(String depth, String amount, String status, Int32 index)
        {
            int y = 40*index + 51;

            // 
            // depthTextBox
            // 
            depthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            depthTextBox.Location = new System.Drawing.Point(29, y);
            depthTextBox.Name = "depthTextBox";
            depthTextBox.Size = new System.Drawing.Size(53, 26);

            if (depth != null)
                depthTextBox.Text = depth;

            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            statusLabel.Location = new System.Drawing.Point(222, y);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(163, 20);

            if (status != null)
                statusLabel.Text = status;

            // 
            // amountTextBox
            // 
            amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            amountTextBox.Location = new System.Drawing.Point(125, y);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new System.Drawing.Size(61, 26);

            if (amount != null)
                amountTextBox.Text = amount;

            // 
            // deleteCheckBox
            // 
            deleteCheckBox.AutoSize = true;
            deleteCheckBox.Location = new System.Drawing.Point(436, y);
            deleteCheckBox.Name = "deleteCheckBox";
            deleteCheckBox.Size = new System.Drawing.Size(15, 14);
            deleteCheckBox.UseVisualStyleBackColor = true;
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
    }
}
