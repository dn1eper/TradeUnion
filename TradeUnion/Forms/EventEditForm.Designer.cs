namespace TradeUnion.Forms
{
    partial class EventEditForm
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Button cancelEventBtn;
            System.Windows.Forms.Label titleTextBox;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveEventBtn = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cancelEventBtn = new System.Windows.Forms.Button();
            titleTextBox = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label5.Location = new System.Drawing.Point(11, 70);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 32);
            label5.TabIndex = 6;
            label5.Text = "Сумма:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label6.Location = new System.Drawing.Point(11, 102);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 32);
            label6.TabIndex = 7;
            label6.Text = "Дата:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelEventBtn
            // 
            cancelEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelEventBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelEventBtn.Location = new System.Drawing.Point(613, 138);
            cancelEventBtn.Margin = new System.Windows.Forms.Padding(4);
            cancelEventBtn.Name = "cancelEventBtn";
            cancelEventBtn.Size = new System.Drawing.Size(90, 27);
            cancelEventBtn.TabIndex = 6;
            cancelEventBtn.Text = "Отмена";
            cancelEventBtn.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            titleTextBox.AutoSize = true;
            titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            titleTextBox.Location = new System.Drawing.Point(11, 38);
            titleTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(92, 32);
            titleTextBox.TabIndex = 1;
            titleTextBox.Text = "Название:";
            titleTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label3.Location = new System.Drawing.Point(11, 6);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 32);
            label3.TabIndex = 0;
            label3.Text = "ФИО:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.Controls.Add(label3, 0, 0);
            tableLayoutPanel.Controls.Add(titleTextBox, 0, 1);
            tableLayoutPanel.Controls.Add(this.nameTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(this.titleTextBox1, 1, 1);
            tableLayoutPanel.Controls.Add(cancelEventBtn, 2, 4);
            tableLayoutPanel.Controls.Add(label6, 0, 3);
            tableLayoutPanel.Controls.Add(label5, 0, 2);
            tableLayoutPanel.Controls.Add(this.sumTextBox, 1, 2);
            tableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 3);
            tableLayoutPanel.Controls.Add(this.saveEventBtn, 3, 4);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.Size = new System.Drawing.Size(802, 175);
            tableLayoutPanel.TabIndex = 3;
            // 
            // nameTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.nameTextBox, 3);
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(111, 10);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(690, 24);
            this.nameTextBox.TabIndex = 0;
            // 
            // titleTextBox1
            // 
            tableLayoutPanel.SetColumnSpan(this.titleTextBox1, 3);
            this.titleTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.titleTextBox1.Location = new System.Drawing.Point(111, 42);
            this.titleTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(688, 24);
            this.titleTextBox1.TabIndex = 2;
            this.titleTextBox1.TextChanged += new System.EventHandler(this.OnEventChanged);
            // 
            // sumTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.sumTextBox, 3);
            this.sumTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumTextBox.Location = new System.Drawing.Point(110, 73);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(692, 22);
            this.sumTextBox.TabIndex = 3;
            this.sumTextBox.TextChanged += new System.EventHandler(this.OnEventChanged);
            this.sumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnSumKeyPress);
            // 
            // dateTimePicker
            // 
            tableLayoutPanel.SetColumnSpan(this.dateTimePicker, 3);
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Location = new System.Drawing.Point(110, 105);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(692, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // saveEventBtn
            // 
            this.saveEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEventBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEventBtn.Enabled = false;
            this.saveEventBtn.Location = new System.Drawing.Point(711, 138);
            this.saveEventBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveEventBtn.Name = "saveEventBtn";
            this.saveEventBtn.Size = new System.Drawing.Size(90, 27);
            this.saveEventBtn.TabIndex = 5;
            this.saveEventBtn.Text = "Сохранить";
            this.saveEventBtn.UseVisualStyleBackColor = true;
            this.saveEventBtn.Click += new System.EventHandler(this.OnChangesAccepted);
            // 
            // EventEditForm
            // 
            this.AcceptButton = this.saveEventBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelEventBtn;
            this.ClientSize = new System.Drawing.Size(802, 175);
            this.Controls.Add(tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventEditForm";
            this.ShowIcon = false;
            this.Text = "Оказать помощь";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownEventEditForm);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveEventBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.TextBox sumTextBox;
    }
}