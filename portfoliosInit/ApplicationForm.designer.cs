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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.delStrategyButton = new System.Windows.Forms.Button();
            this.editStrategyButton = new System.Windows.Forms.Button();
            this.addStrategyButton = new System.Windows.Forms.Button();
            this.unblockAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.strategyComboBox = new portfoliosInit.ComboBoxWithPrevious();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.delStrategyButton);
            this.splitContainer.Panel1.Controls.Add(this.editStrategyButton);
            this.splitContainer.Panel1.Controls.Add(this.addStrategyButton);
            this.splitContainer.Panel1.Controls.Add(this.unblockAllButton);
            this.splitContainer.Panel1.Controls.Add(this.saveButton);
            this.splitContainer.Panel1.Controls.Add(this.strategyComboBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.addButton);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Size = new System.Drawing.Size(561, 507);
            this.splitContainer.SplitterDistance = 79;
            this.splitContainer.TabIndex = 0;
            // 
            // delStrategyButton
            // 
            this.delStrategyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delStrategyButton.Location = new System.Drawing.Point(446, 48);
            this.delStrategyButton.Name = "delStrategyButton";
            this.delStrategyButton.Size = new System.Drawing.Size(103, 28);
            this.delStrategyButton.TabIndex = 5;
            this.delStrategyButton.Text = "Del";
            this.delStrategyButton.UseVisualStyleBackColor = true;
            this.delStrategyButton.Click += new System.EventHandler(this.delStrategyButton_Click);
            // 
            // editStrategyButton
            // 
            this.editStrategyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editStrategyButton.Location = new System.Drawing.Point(337, 48);
            this.editStrategyButton.Name = "editStrategyButton";
            this.editStrategyButton.Size = new System.Drawing.Size(103, 28);
            this.editStrategyButton.TabIndex = 4;
            this.editStrategyButton.Text = "Edit";
            this.editStrategyButton.UseVisualStyleBackColor = true;
            this.editStrategyButton.Click += new System.EventHandler(this.editStrategyButtonClicked);
            // 
            // addStrategyButton
            // 
            this.addStrategyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStrategyButton.Location = new System.Drawing.Point(228, 48);
            this.addStrategyButton.Name = "addStrategyButton";
            this.addStrategyButton.Size = new System.Drawing.Size(103, 28);
            this.addStrategyButton.TabIndex = 3;
            this.addStrategyButton.Text = "Add";
            this.addStrategyButton.UseVisualStyleBackColor = true;
            this.addStrategyButton.Click += new System.EventHandler(this.addStrategyButtonClicked);
            // 
            // unblockAllButton
            // 
            this.unblockAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unblockAllButton.Location = new System.Drawing.Point(10, 47);
            this.unblockAllButton.Name = "unblockAllButton";
            this.unblockAllButton.Size = new System.Drawing.Size(103, 29);
            this.unblockAllButton.TabIndex = 2;
            this.unblockAllButton.TabStop = false;
            this.unblockAllButton.Text = "Unblock All";
            this.unblockAllButton.UseVisualStyleBackColor = true;
            this.unblockAllButton.Click += new System.EventHandler(this.unblockButtonClicked);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(119, 48);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClicked);
            // 
            // strategyComboBox
            // 
            this.strategyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.strategyComboBox.FormattingEnabled = true;
            this.strategyComboBox.Location = new System.Drawing.Point(12, 12);
            this.strategyComboBox.Name = "strategyComboBox";
            this.strategyComboBox.Size = new System.Drawing.Size(537, 26);
            this.strategyComboBox.TabIndex = 0;
            this.strategyComboBox.SelectedIndexChanged += new System.EventHandler(this.strategyComboBoxSelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 28);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(222, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(121, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(418, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete";
            // 
            // ApplicationForm
            // 
            this.ClientSize = new System.Drawing.Size(561, 507);
            this.Controls.Add(this.splitContainer);
            this.Name = "ApplicationForm";
            this.Text = "Portolios initialization";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private Button unblockAllButton;
        private Button saveButton;
        private ComboBoxWithPrevious strategyComboBox;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button addButton;
        private Button delStrategyButton;
        private Button editStrategyButton;
        private Button addStrategyButton;
    }
}

