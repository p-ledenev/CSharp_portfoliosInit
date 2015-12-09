using System;

namespace portfoliosInit
{
    partial class AddPortfolioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.strategyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sieveParamBox = new System.Windows.Forms.TextBox();
            this.securityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fillingGapsNumberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strategy";
            // 
            // strategyComboBox
            // 
            this.strategyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.strategyComboBox.FormattingEnabled = true;
            this.strategyComboBox.Location = new System.Drawing.Point(12, 34);
            this.strategyComboBox.Name = "strategyComboBox";
            this.strategyComboBox.Size = new System.Drawing.Size(299, 26);
            this.strategyComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sieve (%)";
            // 
            // sieveParamBox
            // 
            this.sieveParamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sieveParamBox.Location = new System.Drawing.Point(12, 94);
            this.sieveParamBox.Name = "sieveParamBox";
            this.sieveParamBox.Size = new System.Drawing.Size(88, 24);
            this.sieveParamBox.TabIndex = 3;
            // 
            // securityBox
            // 
            this.securityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.securityBox.Location = new System.Drawing.Point(226, 95);
            this.securityBox.Name = "securityBox";
            this.securityBox.Size = new System.Drawing.Size(85, 24);
            this.securityBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(223, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Security";
            // 
            // fillingGapsNumberBox
            // 
            this.fillingGapsNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fillingGapsNumberBox.Location = new System.Drawing.Point(117, 94);
            this.fillingGapsNumberBox.Name = "fillingGapsNumberBox";
            this.fillingGapsNumberBox.Size = new System.Drawing.Size(85, 24);
            this.fillingGapsNumberBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(114, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gaps (num) ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(335, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonApplyClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(335, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCloseClicked);
            // 
            // AddPortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 131);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fillingGapsNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.securityBox);
            this.Controls.Add(this.sieveParamBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.strategyComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddPortfolioForm";
            this.Text = "AddPortfolio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox strategyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sieveParamBox;
        private System.Windows.Forms.TextBox securityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fillingGapsNumberBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}