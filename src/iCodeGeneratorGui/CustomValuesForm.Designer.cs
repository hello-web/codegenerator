namespace iCodeGenerator.iCodeGeneratorGui
{
    partial class CustomValuesForm
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
            this.gridCustomValues = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveText = new System.Windows.Forms.Label();
            this.txtRemoveText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomValues)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCustomValues
            // 
            this.gridCustomValues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridCustomValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomValues.Location = new System.Drawing.Point(0, 118);
            this.gridCustomValues.Name = "gridCustomValues";
            this.gridCustomValues.Size = new System.Drawing.Size(284, 144);
            this.gridCustomValues.TabIndex = 0;
            this.gridCustomValues.Leave += new System.EventHandler(this.GridCustomValuesLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRemoveText);
            this.panel1.Controls.Add(this.RemoveText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 112);
            this.panel1.TabIndex = 1;
            // 
            // RemoveText
            // 
            this.RemoveText.AutoSize = true;
            this.RemoveText.Location = new System.Drawing.Point(3, 19);
            this.RemoveText.Name = "RemoveText";
            this.RemoveText.Size = new System.Drawing.Size(79, 13);
            this.RemoveText.TabIndex = 0;
            this.RemoveText.Text = "Removing Text";
            // 
            // txtRemoveText
            // 
            this.txtRemoveText.Location = new System.Drawing.Point(100, 16);
            this.txtRemoveText.Name = "txtRemoveText";
            this.txtRemoveText.Size = new System.Drawing.Size(162, 20);
            this.txtRemoveText.TabIndex = 1;
            // 
            // CustomValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridCustomValues);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomValuesForm";
            this.Text = "CustomValuesForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomValues)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomValues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRemoveText;
        private System.Windows.Forms.Label RemoveText;
    }
}