namespace TradeUnion.Forms
{
    partial class EmployeeEditForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button CancelButton;
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.saveEmpBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            CancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label1.Location = new System.Drawing.Point(11, 6);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 34);
            label1.TabIndex = 0;
            label1.Text = "ФИО:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label2.Location = new System.Drawing.Point(11, 40);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 34);
            label2.TabIndex = 1;
            label2.Text = "ИНН:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            CancelButton.Location = new System.Drawing.Point(232, 86);
            CancelButton.Margin = new System.Windows.Forms.Padding(4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(90, 30);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.innTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(CancelButton, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.saveEmpBtn, 3, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(432, 126);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.nameTextBox, 3);
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(71, 10);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(350, 24);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.OnEmployeeChanged);
            // 
            // innTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.innTextBox, 3);
            this.innTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.innTextBox.Location = new System.Drawing.Point(71, 44);
            this.innTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(350, 24);
            this.innTextBox.TabIndex = 2;
            // 
            // saveEmpBtn
            // 
            this.saveEmpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEmpBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEmpBtn.Enabled = false;
            this.saveEmpBtn.Location = new System.Drawing.Point(331, 86);
            this.saveEmpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveEmpBtn.Name = "saveEmpBtn";
            this.saveEmpBtn.Size = new System.Drawing.Size(90, 30);
            this.saveEmpBtn.TabIndex = 4;
            this.saveEmpBtn.Text = "Сохранить";
            this.saveEmpBtn.UseVisualStyleBackColor = true;
            this.saveEmpBtn.Click += new System.EventHandler(this.OnChangesAccepted);
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 126);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeEditForm";
            this.ShowIcon = false;
            this.Text = "Сотрудник";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.Button saveEmpBtn;
    }
}