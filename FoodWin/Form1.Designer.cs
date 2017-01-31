namespace FoodWin
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblFatNorm = new System.Windows.Forms.Label();
            this.lblProtNorm = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProficitVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProficit = new System.Windows.Forms.TrackBar();
            this.btnCalculateMenu = new System.Windows.Forms.Button();
            this.lblTargetCals = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCarbsNorm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProt = new System.Windows.Forms.NumericUpDown();
            this.txtWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProficit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblFatNorm);
            this.splitContainer1.Panel1.Controls.Add(this.lblProtNorm);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.lblProficitVal);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbProficit);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalculateMenu);
            this.splitContainer1.Panel1.Controls.Add(this.lblTargetCals);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.lblCarbsNorm);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtCal);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtFat);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtProt);
            this.splitContainer1.Panel1.Controls.Add(this.txtWeight);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1393, 591);
            this.splitContainer1.SplitterDistance = 1105;
            this.splitContainer1.TabIndex = 22;
            // 
            // lblFatNorm
            // 
            this.lblFatNorm.AutoSize = true;
            this.lblFatNorm.Location = new System.Drawing.Point(261, 172);
            this.lblFatNorm.Name = "lblFatNorm";
            this.lblFatNorm.Size = new System.Drawing.Size(13, 13);
            this.lblFatNorm.TabIndex = 41;
            this.lblFatNorm.Text = "0";
            // 
            // lblProtNorm
            // 
            this.lblProtNorm.AutoSize = true;
            this.lblProtNorm.Location = new System.Drawing.Point(261, 152);
            this.lblProtNorm.Name = "lblProtNorm";
            this.lblProtNorm.Size = new System.Drawing.Size(13, 13);
            this.lblProtNorm.TabIndex = 40;
            this.lblProtNorm.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Норма жиров";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Норма белков";
            // 
            // lblProficitVal
            // 
            this.lblProficitVal.AutoSize = true;
            this.lblProficitVal.Location = new System.Drawing.Point(374, 98);
            this.lblProficitVal.Name = "lblProficitVal";
            this.lblProficitVal.Size = new System.Drawing.Size(21, 13);
            this.lblProficitVal.TabIndex = 37;
            this.lblProficitVal.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Профицит калорий";
            // 
            // tbProficit
            // 
            this.tbProficit.Location = new System.Drawing.Point(263, 90);
            this.tbProficit.Minimum = -10;
            this.tbProficit.Name = "tbProficit";
            this.tbProficit.Size = new System.Drawing.Size(104, 45);
            this.tbProficit.TabIndex = 35;
            // 
            // btnCalculateMenu
            // 
            this.btnCalculateMenu.Location = new System.Drawing.Point(406, 182);
            this.btnCalculateMenu.Name = "btnCalculateMenu";
            this.btnCalculateMenu.Size = new System.Drawing.Size(118, 23);
            this.btnCalculateMenu.TabIndex = 34;
            this.btnCalculateMenu.Text = "Рассчитать меню";
            this.btnCalculateMenu.UseVisualStyleBackColor = true;
            // 
            // lblTargetCals
            // 
            this.lblTargetCals.AutoSize = true;
            this.lblTargetCals.Location = new System.Drawing.Point(261, 135);
            this.lblTargetCals.Name = "lblTargetCals";
            this.lblTargetCals.Size = new System.Drawing.Size(31, 13);
            this.lblTargetCals.TabIndex = 33;
            this.lblTargetCals.Text = "2900";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Целевой калораж";
            // 
            // lblCarbsNorm
            // 
            this.lblCarbsNorm.AutoSize = true;
            this.lblCarbsNorm.Location = new System.Drawing.Point(261, 192);
            this.lblCarbsNorm.Name = "lblCarbsNorm";
            this.lblCarbsNorm.Size = new System.Drawing.Size(13, 13);
            this.lblCarbsNorm.TabIndex = 31;
            this.lblCarbsNorm.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Норма углеводов";
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(263, 64);
            this.txtCal.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.txtCal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(73, 20);
            this.txtCal.TabIndex = 29;
            this.txtCal.Value = new decimal(new int[] {
            2900,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Среднесуточная калорийность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Норма жира";
            // 
            // txtFat
            // 
            this.txtFat.DecimalPlaces = 1;
            this.txtFat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtFat.Location = new System.Drawing.Point(263, 38);
            this.txtFat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.txtFat.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(73, 20);
            this.txtFat.TabIndex = 26;
            this.txtFat.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Норма белка";
            // 
            // txtProt
            // 
            this.txtProt.DecimalPlaces = 1;
            this.txtProt.Location = new System.Drawing.Point(263, 12);
            this.txtProt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.txtProt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtProt.Name = "txtProt";
            this.txtProt.Size = new System.Drawing.Size(73, 20);
            this.txtProt.TabIndex = 24;
            this.txtProt.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(44, 12);
            this.txtWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtWeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(73, 20);
            this.txtWeight.TabIndex = 23;
            this.txtWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Вес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 591);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbProficit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblFatNorm;
        private System.Windows.Forms.Label lblProtNorm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProficitVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbProficit;
        private System.Windows.Forms.Button btnCalculateMenu;
        private System.Windows.Forms.Label lblTargetCals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCarbsNorm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtCal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtFat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtProt;
        private System.Windows.Forms.NumericUpDown txtWeight;
        private System.Windows.Forms.Label label1;
    }
}

