namespace OpenStation13
{
    partial class AtmosCan
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
            this.label2 = new System.Windows.Forms.Label();
            this.GasAmount = new System.Windows.Forms.NumericUpDown();
            this.GasPanel = new System.Windows.Forms.Panel();
            this.GasPicker = new System.Windows.Forms.ComboBox();
            this.AddGasButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GasDisplay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetupCan = new System.Windows.Forms.Button();
            this.CanisterBreak = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CanisterVolume = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeatValue = new System.Windows.Forms.NumericUpDown();
            this.HeatBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GasAmount)).BeginInit();
            this.GasPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanisterBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanisterVolume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeatValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // GasAmount
            // 
            this.GasAmount.Location = new System.Drawing.Point(134, 32);
            this.GasAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.GasAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.GasAmount.Name = "GasAmount";
            this.GasAmount.Size = new System.Drawing.Size(94, 20);
            this.GasAmount.TabIndex = 3;
            this.GasAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // GasPanel
            // 
            this.GasPanel.Controls.Add(this.GasPicker);
            this.GasPanel.Controls.Add(this.AddGasButton);
            this.GasPanel.Controls.Add(this.GasAmount);
            this.GasPanel.Controls.Add(this.label2);
            this.GasPanel.Location = new System.Drawing.Point(331, 12);
            this.GasPanel.Name = "GasPanel";
            this.GasPanel.Size = new System.Drawing.Size(263, 64);
            this.GasPanel.TabIndex = 4;
            // 
            // GasPicker
            // 
            this.GasPicker.FormattingEnabled = true;
            this.GasPicker.Items.AddRange(new object[] {
            "Oxygen",
            "Hydrogen"});
            this.GasPicker.Location = new System.Drawing.Point(4, 4);
            this.GasPicker.Name = "GasPicker";
            this.GasPicker.Size = new System.Drawing.Size(121, 21);
            this.GasPicker.TabIndex = 5;
            this.GasPicker.Text = "Oxygen";
            // 
            // AddGasButton
            // 
            this.AddGasButton.Location = new System.Drawing.Point(4, 31);
            this.AddGasButton.Name = "AddGasButton";
            this.AddGasButton.Size = new System.Drawing.Size(75, 23);
            this.AddGasButton.TabIndex = 4;
            this.AddGasButton.Text = "Add Gas";
            this.AddGasButton.UseVisualStyleBackColor = true;
            this.AddGasButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GasDisplay);
            this.groupBox1.Location = new System.Drawing.Point(12, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Container";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GasDisplay
            // 
            this.GasDisplay.AutoSize = true;
            this.GasDisplay.Location = new System.Drawing.Point(6, 16);
            this.GasDisplay.Name = "GasDisplay";
            this.GasDisplay.Size = new System.Drawing.Size(35, 13);
            this.GasDisplay.TabIndex = 3;
            this.GasDisplay.Text = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetupCan);
            this.groupBox2.Controls.Add(this.CanisterBreak);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CanisterVolume);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canister Setup";
            // 
            // SetupCan
            // 
            this.SetupCan.Location = new System.Drawing.Point(158, 70);
            this.SetupCan.Name = "SetupCan";
            this.SetupCan.Size = new System.Drawing.Size(75, 23);
            this.SetupCan.TabIndex = 4;
            this.SetupCan.Text = "New Can";
            this.SetupCan.UseVisualStyleBackColor = true;
            this.SetupCan.Click += new System.EventHandler(this.SetupCan_Click);
            // 
            // CanisterBreak
            // 
            this.CanisterBreak.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CanisterBreak.Location = new System.Drawing.Point(158, 44);
            this.CanisterBreak.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.CanisterBreak.Name = "CanisterBreak";
            this.CanisterBreak.Size = new System.Drawing.Size(120, 20);
            this.CanisterBreak.TabIndex = 3;
            this.CanisterBreak.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Breaking Pressure (kPa)";
            // 
            // CanisterVolume
            // 
            this.CanisterVolume.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CanisterVolume.Location = new System.Drawing.Point(158, 18);
            this.CanisterVolume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CanisterVolume.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CanisterVolume.Name = "CanisterVolume";
            this.CanisterVolume.Size = new System.Drawing.Size(120, 20);
            this.CanisterVolume.TabIndex = 2;
            this.CanisterVolume.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Canister Volume";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HeatBtn);
            this.panel1.Controls.Add(this.HeatValue);
            this.panel1.Location = new System.Drawing.Point(331, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 121);
            this.panel1.TabIndex = 8;
            // 
            // HeatValue
            // 
            this.HeatValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeatValue.Location = new System.Drawing.Point(88, 9);
            this.HeatValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeatValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.HeatValue.Name = "HeatValue";
            this.HeatValue.Size = new System.Drawing.Size(120, 20);
            this.HeatValue.TabIndex = 0;
            this.HeatValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // HeatBtn
            // 
            this.HeatBtn.Location = new System.Drawing.Point(4, 6);
            this.HeatBtn.Name = "HeatBtn";
            this.HeatBtn.Size = new System.Drawing.Size(75, 23);
            this.HeatBtn.TabIndex = 1;
            this.HeatBtn.Text = "Heat";
            this.HeatBtn.UseVisualStyleBackColor = true;
            this.HeatBtn.UseWaitCursor = true;
            this.HeatBtn.Click += new System.EventHandler(this.HeatBtn_Click);
            // 
            // AtmosCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GasPanel);
            this.Name = "AtmosCan";
            this.Text = "Canister Testing";
            this.Load += new System.EventHandler(this.AtmosCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GasAmount)).EndInit();
            this.GasPanel.ResumeLayout(false);
            this.GasPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanisterBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanisterVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeatValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GasAmount;
        private System.Windows.Forms.Panel GasPanel;
        private System.Windows.Forms.Button AddGasButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CanisterBreak;
        private System.Windows.Forms.NumericUpDown CanisterVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GasDisplay;
        private System.Windows.Forms.Button SetupCan;
        private System.Windows.Forms.ComboBox GasPicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown HeatValue;
        private System.Windows.Forms.Button HeatBtn;
    }
}