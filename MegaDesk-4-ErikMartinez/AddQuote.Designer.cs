﻿namespace MegaDesk_3_ErikMartinez
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.cancelButton = new System.Windows.Forms.Button();
            this.addNewQoute_Button = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surfMatLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.depthNumeric = new System.Windows.Forms.NumericUpDown();
            this.drawersNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(156, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 46);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addNewQoute_Button
            // 
            this.addNewQoute_Button.Location = new System.Drawing.Point(501, 393);
            this.addNewQoute_Button.Name = "addNewQoute_Button";
            this.addNewQoute_Button.Size = new System.Drawing.Size(122, 46);
            this.addNewQoute_Button.TabIndex = 7;
            this.addNewQoute_Button.Text = "Add";
            this.addNewQoute_Button.UseVisualStyleBackColor = true;
            this.addNewQoute_Button.Click += new System.EventHandler(this.addNewQoute_Button_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(152, 43);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(136, 20);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(298, 40);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(226, 27);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(152, 107);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(62, 20);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width: ";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(152, 177);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(59, 20);
            this.depthLabel.TabIndex = 7;
            this.depthLabel.Text = "Depth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "(min of 24\" and max of 96\")";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "(min of 12\" and max of 48\")";
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(370, 102);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(175, 20);
            this.drawerLabel.TabIndex = 12;
            this.drawerLabel.Text = "Number Of Drawers:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "(min of 0 and max of 7)";
            // 
            // surfMatLabel
            // 
            this.surfMatLabel.AutoSize = true;
            this.surfMatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfMatLabel.Location = new System.Drawing.Point(372, 172);
            this.surfMatLabel.Name = "surfMatLabel";
            this.surfMatLabel.Size = new System.Drawing.Size(142, 20);
            this.surfMatLabel.TabIndex = 15;
            this.surfMatLabel.Text = "Surface Material: ";
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(520, 169);
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(108, 28);
            this.surfaceMaterialComboBox.TabIndex = 5;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(372, 231);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(85, 20);
            this.deliveryLabel.TabIndex = 17;
            this.deliveryLabel.Text = "Delivery:  ";
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Items.AddRange(new object[] {
            "Rush 3 Days",
            "Rush 5 Days",
            "Rush 7 Days",
            "No Rush 14 Days"});
            this.deliveryComboBox.Location = new System.Drawing.Point(463, 228);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(165, 28);
            this.deliveryComboBox.TabIndex = 6;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(463, 306);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(61, 20);
            this.totalLabel.TabIndex = 19;
            this.totalLabel.Text = "Total:  ";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(541, 303);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(87, 27);
            this.totalTextBox.TabIndex = 20;
            // 
            // widthNumeric
            // 
            this.widthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthNumeric.Location = new System.Drawing.Point(215, 105);
            this.widthNumeric.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumeric.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(77, 27);
            this.widthNumeric.TabIndex = 2;
            this.widthNumeric.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthNumeric
            // 
            this.depthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthNumeric.Location = new System.Drawing.Point(215, 175);
            this.depthNumeric.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumeric.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumeric.Name = "depthNumeric";
            this.depthNumeric.Size = new System.Drawing.Size(77, 27);
            this.depthNumeric.TabIndex = 3;
            this.depthNumeric.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // drawersNumeric
            // 
            this.drawersNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersNumeric.Location = new System.Drawing.Point(551, 100);
            this.drawersNumeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersNumeric.Name = "drawersNumeric";
            this.drawersNumeric.Size = new System.Drawing.Size(77, 27);
            this.drawersNumeric.TabIndex = 4;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(803, 510);
            this.Controls.Add(this.drawersNumeric);
            this.Controls.Add(this.depthNumeric);
            this.Controls.Add(this.widthNumeric);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.deliveryComboBox);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.surfaceMaterialComboBox);
            this.Controls.Add(this.surfMatLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.addNewQoute_Button);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addNewQoute_Button;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label surfMatLabel;
        private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.ComboBox deliveryComboBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.NumericUpDown widthNumeric;
        private System.Windows.Forms.NumericUpDown depthNumeric;
        private System.Windows.Forms.NumericUpDown drawersNumeric;
    }
}