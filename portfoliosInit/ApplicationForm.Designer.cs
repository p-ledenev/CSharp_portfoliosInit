using System.Collections.Generic;
using System.Windows.Forms;

namespace portfoliosInit
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            unblockAllButton = new Button();
            applyButton = new Button();
            strategyComboBox = new ComboBoxWithPrevious();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addButton = new Button();

            machineForms = new List<MachinesForm>();

            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(unblockAllButton);
            splitContainer.Panel1.Controls.Add(applyButton);
            splitContainer.Panel1.Controls.Add(strategyComboBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            splitContainer.Panel2.Controls.Add(addButton);
            splitContainer.Panel2.Controls.Add(label4);
            splitContainer.Panel2.Controls.Add(label3);
            splitContainer.Panel2.Controls.Add(label2);
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Panel2.AutoScroll = true;

            foreach (var item in machineForms)
                item.addTo(splitContainer.Panel2.Controls);

            splitContainer.Size = new System.Drawing.Size(549, 507);
            splitContainer.SplitterDistance = 51;
            splitContainer.TabIndex = 0;
            // 
            // unblockAllButton
            // 
            unblockAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            unblockAllButton.Location = new System.Drawing.Point(389, 12);
            unblockAllButton.Name = "unblockAllButton";
            unblockAllButton.Size = new System.Drawing.Size(148, 29);
            unblockAllButton.TabIndex = 2;
            unblockAllButton.Text = "Unblock All";
            unblockAllButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            applyButton.Location = new System.Drawing.Point(226, 12);
            applyButton.Name = "applyButton";
            applyButton.Size = new System.Drawing.Size(148, 28);
            applyButton.TabIndex = 1;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += new System.EventHandler(applyButtonClicked);
            // 
            // StrategyComboBox
            // 
            strategyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            strategyComboBox.FormattingEnabled = true;
            strategyComboBox.Location = new System.Drawing.Point(12, 12);
            strategyComboBox.Name = "strategyComboBox";
            strategyComboBox.Size = new System.Drawing.Size(201, 28);
            strategyComboBox.TabIndex = 0;
            strategyComboBox.SelectedIndexChanged += new System.EventHandler(strategyComboBoxSelectedIndexChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label4.Location = new System.Drawing.Point(222, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(121, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(29, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Depth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label1.Location = new System.Drawing.Point(418, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Delete";
            // 
            // addButton
            // 
            addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(77, 28);
            addButton.Text = "...";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += new System.EventHandler(addButtonClicked);
            setAddButtonPosition();
            // 
            // ApplicationForm
            // 
            ClientSize = new System.Drawing.Size(549, 507);
            Controls.Add(splitContainer);
            Name = "ApplicationForm";
            Text = "Portolios initialization";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private Button unblockAllButton;
        private Button applyButton;
        private ComboBoxWithPrevious strategyComboBox;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button addButton;

        private List<MachinesForm> machineForms;

    }
}

