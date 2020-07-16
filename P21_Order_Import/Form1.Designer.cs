namespace P21_Order_Import
{
    partial class ImportForm
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LineGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.OELineNoteTab = new System.Windows.Forms.TabPage();
            this.LineGridNoteView = new System.Windows.Forms.DataGridView();
            this.OEHdrNoteTab = new System.Windows.Forms.TabPage();
            this.HdrNoteGridView = new System.Windows.Forms.DataGridView();
            this.CreditCardTab = new System.Windows.Forms.TabPage();
            this.CreditCardGridView = new System.Windows.Forms.DataGridView();
            this.RemittanceTab = new System.Windows.Forms.TabPage();
            this.RemitGridView = new System.Windows.Forms.DataGridView();
            this.OEHdrTab = new System.Windows.Forms.TabPage();
            this.OEHdrGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.LineGridView)).BeginInit();
            this.OELineNoteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineGridNoteView)).BeginInit();
            this.OEHdrNoteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HdrNoteGridView)).BeginInit();
            this.CreditCardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditCardGridView)).BeginInit();
            this.RemittanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemitGridView)).BeginInit();
            this.OEHdrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OEHdrGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1349, 33);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load File";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1349, 62);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LineGridView
            // 
            this.LineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LineGridView.Location = new System.Drawing.Point(16, 178);
            this.LineGridView.Name = "LineGridView";
            this.LineGridView.Size = new System.Drawing.Size(1304, 350);
            this.LineGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OrderLines";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1349, 91);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OELineNoteTab
            // 
            this.OELineNoteTab.Controls.Add(this.LineGridNoteView);
            this.OELineNoteTab.Location = new System.Drawing.Point(4, 22);
            this.OELineNoteTab.Name = "OELineNoteTab";
            this.OELineNoteTab.Padding = new System.Windows.Forms.Padding(3);
            this.OELineNoteTab.Size = new System.Drawing.Size(1300, 122);
            this.OELineNoteTab.TabIndex = 4;
            this.OELineNoteTab.Text = "OrderLineNotepad";
            this.OELineNoteTab.UseVisualStyleBackColor = true;
            // 
            // LineGridNoteView
            // 
            this.LineGridNoteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LineGridNoteView.Location = new System.Drawing.Point(-2, -2);
            this.LineGridNoteView.Name = "LineGridNoteView";
            this.LineGridNoteView.Size = new System.Drawing.Size(1304, 127);
            this.LineGridNoteView.TabIndex = 1;
            // 
            // OEHdrNoteTab
            // 
            this.OEHdrNoteTab.Controls.Add(this.HdrNoteGridView);
            this.OEHdrNoteTab.Location = new System.Drawing.Point(4, 22);
            this.OEHdrNoteTab.Name = "OEHdrNoteTab";
            this.OEHdrNoteTab.Padding = new System.Windows.Forms.Padding(3);
            this.OEHdrNoteTab.Size = new System.Drawing.Size(1300, 122);
            this.OEHdrNoteTab.TabIndex = 3;
            this.OEHdrNoteTab.Text = "OrderHeaderNotepad";
            this.OEHdrNoteTab.UseVisualStyleBackColor = true;
            // 
            // HdrNoteGridView
            // 
            this.HdrNoteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HdrNoteGridView.Location = new System.Drawing.Point(-2, -2);
            this.HdrNoteGridView.Name = "HdrNoteGridView";
            this.HdrNoteGridView.Size = new System.Drawing.Size(1304, 127);
            this.HdrNoteGridView.TabIndex = 1;
            // 
            // CreditCardTab
            // 
            this.CreditCardTab.Controls.Add(this.CreditCardGridView);
            this.CreditCardTab.Location = new System.Drawing.Point(4, 22);
            this.CreditCardTab.Name = "CreditCardTab";
            this.CreditCardTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreditCardTab.Size = new System.Drawing.Size(1300, 122);
            this.CreditCardTab.TabIndex = 2;
            this.CreditCardTab.Text = "CreditCardHolderAddress";
            this.CreditCardTab.UseVisualStyleBackColor = true;
            // 
            // CreditCardGridView
            // 
            this.CreditCardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreditCardGridView.Location = new System.Drawing.Point(-2, -2);
            this.CreditCardGridView.Name = "CreditCardGridView";
            this.CreditCardGridView.Size = new System.Drawing.Size(1304, 127);
            this.CreditCardGridView.TabIndex = 1;
            // 
            // RemittanceTab
            // 
            this.RemittanceTab.Controls.Add(this.RemitGridView);
            this.RemittanceTab.Location = new System.Drawing.Point(4, 22);
            this.RemittanceTab.Name = "RemittanceTab";
            this.RemittanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemittanceTab.Size = new System.Drawing.Size(1300, 122);
            this.RemittanceTab.TabIndex = 1;
            this.RemittanceTab.Text = "Remittance";
            this.RemittanceTab.UseVisualStyleBackColor = true;
            // 
            // RemitGridView
            // 
            this.RemitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemitGridView.Location = new System.Drawing.Point(-15, -1);
            this.RemitGridView.Name = "RemitGridView";
            this.RemitGridView.Size = new System.Drawing.Size(1331, 127);
            this.RemitGridView.TabIndex = 1;
            // 
            // OEHdrTab
            // 
            this.OEHdrTab.Controls.Add(this.OEHdrGridView);
            this.OEHdrTab.Location = new System.Drawing.Point(4, 22);
            this.OEHdrTab.Name = "OEHdrTab";
            this.OEHdrTab.Padding = new System.Windows.Forms.Padding(3);
            this.OEHdrTab.Size = new System.Drawing.Size(1300, 122);
            this.OEHdrTab.TabIndex = 0;
            this.OEHdrTab.Text = "OrderHeader";
            this.OEHdrTab.UseVisualStyleBackColor = true;
            // 
            // OEHdrGridView
            // 
            this.OEHdrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OEHdrGridView.Location = new System.Drawing.Point(-4, -1);
            this.OEHdrGridView.Name = "OEHdrGridView";
            this.OEHdrGridView.Size = new System.Drawing.Size(1304, 127);
            this.OEHdrGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OEHdrTab);
            this.tabControl1.Controls.Add(this.RemittanceTab);
            this.tabControl1.Controls.Add(this.CreditCardTab);
            this.tabControl1.Controls.Add(this.OEHdrNoteTab);
            this.tabControl1.Controls.Add(this.OELineNoteTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 148);
            this.tabControl1.TabIndex = 3;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 540);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineGridView)).EndInit();
            this.OELineNoteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineGridNoteView)).EndInit();
            this.OEHdrNoteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HdrNoteGridView)).EndInit();
            this.CreditCardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreditCardGridView)).EndInit();
            this.RemittanceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemitGridView)).EndInit();
            this.OEHdrTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OEHdrGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView LineGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabPage OELineNoteTab;
        public System.Windows.Forms.DataGridView LineGridNoteView;
        private System.Windows.Forms.TabPage OEHdrNoteTab;
        public System.Windows.Forms.DataGridView HdrNoteGridView;
        private System.Windows.Forms.TabPage CreditCardTab;
        public System.Windows.Forms.DataGridView CreditCardGridView;
        private System.Windows.Forms.TabPage RemittanceTab;
        private System.Windows.Forms.DataGridView RemitGridView;
        private System.Windows.Forms.TabPage OEHdrTab;
        public System.Windows.Forms.DataGridView OEHdrGridView;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

