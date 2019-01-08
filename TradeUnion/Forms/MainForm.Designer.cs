namespace TradeUnion.Forms
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ContextMenuStrip contextMenuStrip;
            System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.empListBox = new System.Windows.Forms.ListBox();
            this.empGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmpBtn = new System.Windows.Forms.Button();
            this.empSearchBtn = new System.Windows.Forms.Button();
            this.empSearchTextBox = new System.Windows.Forms.TextBox();
            this.deleteEmpBtn = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEmpBtn.Location = new System.Drawing.Point(12, 380);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(92, 33);
            this.addEmpBtn.TabIndex = 0;
            this.addEmpBtn.Text = "Добавить";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.OnCreateEmployee);
            // 
            // empListBox
            // 
            this.empListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empListBox.ContextMenuStrip = contextMenuStrip;
            this.empListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.empListBox.FormattingEnabled = true;
            this.empListBox.ItemHeight = 22;
            this.empListBox.Location = new System.Drawing.Point(3, 18);
            this.empListBox.Name = "empListBox";
            this.empListBox.Size = new System.Drawing.Size(693, 356);
            this.empListBox.TabIndex = 1;
            this.empListBox.SelectedIndexChanged += new System.EventHandler(this.OnEmployeeSelectionChanged);
            this.empListBox.DoubleClick += new System.EventHandler(this.OnEditEmployee);
            // 
            // empGroupBox
            // 
            this.empGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empGroupBox.Controls.Add(this.deleteEmpBtn);
            this.empGroupBox.Controls.Add(this.empSearchTextBox);
            this.empGroupBox.Controls.Add(this.empSearchBtn);
            this.empGroupBox.Controls.Add(this.editEmpBtn);
            this.empGroupBox.Controls.Add(this.empListBox);
            this.empGroupBox.Controls.Add(this.addEmpBtn);
            this.empGroupBox.Location = new System.Drawing.Point(0, 27);
            this.empGroupBox.Name = "empGroupBox";
            this.empGroupBox.Size = new System.Drawing.Size(693, 426);
            this.empGroupBox.TabIndex = 2;
            this.empGroupBox.TabStop = false;
            this.empGroupBox.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(693, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.сотрудникиToolStripMenuItem.Text = "Помощь";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.OnShowEvent);
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(103, 24);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem1.Click += new System.EventHandler(this.OnShowEmployee);
            // 
            // editEmpBtn
            // 
            this.editEmpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editEmpBtn.Enabled = false;
            this.editEmpBtn.Location = new System.Drawing.Point(110, 380);
            this.editEmpBtn.Name = "editEmpBtn";
            this.editEmpBtn.Size = new System.Drawing.Size(92, 33);
            this.editEmpBtn.TabIndex = 3;
            this.editEmpBtn.Text = "Изменить";
            this.editEmpBtn.UseVisualStyleBackColor = true;
            this.editEmpBtn.Click += new System.EventHandler(this.OnEditEmployee);
            // 
            // empSearchBtn
            // 
            this.empSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchBtn.Location = new System.Drawing.Point(594, 380);
            this.empSearchBtn.Name = "empSearchBtn";
            this.empSearchBtn.Size = new System.Drawing.Size(92, 33);
            this.empSearchBtn.TabIndex = 4;
            this.empSearchBtn.Text = "Найти";
            this.empSearchBtn.UseVisualStyleBackColor = true;
            this.empSearchBtn.Click += new System.EventHandler(this.OnSearchEmployee);
            // 
            // empSearchTextBox
            // 
            this.empSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.empSearchTextBox.Location = new System.Drawing.Point(306, 382);
            this.empSearchTextBox.Name = "empSearchTextBox";
            this.empSearchTextBox.Size = new System.Drawing.Size(282, 29);
            this.empSearchTextBox.TabIndex = 5;
            this.empSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSerchEmployeeKetEnter);
            // 
            // deleteEmpBtn
            // 
            this.deleteEmpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteEmpBtn.Enabled = false;
            this.deleteEmpBtn.Location = new System.Drawing.Point(208, 380);
            this.deleteEmpBtn.Name = "deleteEmpBtn";
            this.deleteEmpBtn.Size = new System.Drawing.Size(92, 33);
            this.deleteEmpBtn.TabIndex = 7;
            this.deleteEmpBtn.Text = "Удалить";
            this.deleteEmpBtn.UseVisualStyleBackColor = true;
            this.deleteEmpBtn.Click += new System.EventHandler(this.OnDeleteEmployee);
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new System.Drawing.Size(148, 76);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            addToolStripMenuItem.Text = "Добавить";
            addToolStripMenuItem.Click += new System.EventHandler(this.OnCreateEmployee);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Изменить";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.OnEditEmployee);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 453);
            this.Controls.Add(this.empGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Main";
            this.Text = "TradeUnion";
            this.empGroupBox.ResumeLayout(false);
            this.empGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.ListBox empListBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.GroupBox empGroupBox;
        private System.Windows.Forms.Button editEmpBtn;
        private System.Windows.Forms.TextBox empSearchTextBox;
        private System.Windows.Forms.Button empSearchBtn;
        private System.Windows.Forms.Button deleteEmpBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

