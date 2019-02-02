namespace MegaDesk_3_ErikMartinez
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.cancelButton = new System.Windows.Forms.Button();
            this.ViewQuotesGrid = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterialComboBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryChoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(324, 446);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(306, 37);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ViewQuotesGrid
            // 
            this.ViewQuotesGrid.AllowUserToDeleteRows = false;
            this.ViewQuotesGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.ViewQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewQuotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.CustomerName,
            this.Width,
            this.Depth,
            this.Drawers,
            this.surfaceMaterialComboBox,
            this.DeliveryChoice,
            this.quote});
            this.ViewQuotesGrid.Enabled = false;
            this.ViewQuotesGrid.Location = new System.Drawing.Point(2, 1);
            this.ViewQuotesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ViewQuotesGrid.Name = "ViewQuotesGrid";
            this.ViewQuotesGrid.RowHeadersVisible = false;
            this.ViewQuotesGrid.Size = new System.Drawing.Size(799, 423);
            this.ViewQuotesGrid.TabIndex = 3;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Frozen = true;
            this.TimeStamp.HeaderText = "Date";
            this.TimeStamp.Name = "TimeStamp";
            // 
            // CustomerName
            // 
            this.CustomerName.Frozen = true;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // Width
            // 
            this.Width.Frozen = true;
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Depth
            // 
            this.Depth.Frozen = true;
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            // 
            // Drawers
            // 
            this.Drawers.Frozen = true;
            this.Drawers.HeaderText = "Number of Drawers";
            this.Drawers.Name = "Drawers";
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.Frozen = true;
            this.surfaceMaterialComboBox.HeaderText = "Surface Material";
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            // 
            // DeliveryChoice
            // 
            this.DeliveryChoice.Frozen = true;
            this.DeliveryChoice.HeaderText = "Delivery";
            this.DeliveryChoice.Name = "DeliveryChoice";
            // 
            // quote
            // 
            this.quote.HeaderText = "Total";
            this.quote.Name = "quote";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 510);
            this.Controls.Add(this.ViewQuotesGrid);
            this.Controls.Add(this.cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewQuotesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView ViewQuotesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterialComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quote;
    }
}