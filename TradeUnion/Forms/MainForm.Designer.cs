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
            System.Windows.Forms.ToolStripMenuItem addEmployee;
            this.editEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.createEvent = new System.Windows.Forms.Button();
            this.empListBox = new System.Windows.Forms.ListBox();
            this.empGroupBox = new System.Windows.Forms.GroupBox();
            this.empSearchTextBox = new System.Windows.Forms.TextBox();
            this.empSearchBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            addEmployee = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            this.empGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            addEmployee,
            this.editEmployee,
            this.deleteEmployee});
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new System.Drawing.Size(148, 76);
            // 
            // addEmployee
            // 
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new System.Drawing.Size(147, 24);
            addEmployee.Text = "Добавить";
            addEmployee.Click += new System.EventHandler(this.OnCreateEmployee);
            // 
            // editEmployee
            // 
            this.editEmployee.Enabled = false;
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(147, 24);
            this.editEmployee.Text = "Изменить";
            this.editEmployee.Click += new System.EventHandler(this.OnEditEmployee);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Enabled = false;
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(147, 24);
            this.deleteEmployee.Text = "Удалить";
            // 
            // createEvent
            // 
            this.createEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createEvent.Enabled = false;
            this.createEvent.Location = new System.Drawing.Point(12, 380);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(141, 33);
            this.createEvent.TabIndex = 0;
            this.createEvent.Text = "Оказать помощь";
            this.createEvent.UseVisualStyleBackColor = true;
            this.createEvent.Click += new System.EventHandler(this.OnCreateEvent);
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
            this.empListBox.Size = new System.Drawing.Size(682, 356);
            this.empListBox.TabIndex = 1;
            this.empListBox.SelectedIndexChanged += new System.EventHandler(this.OnEmployeeSelectionChanged);
            this.empListBox.DoubleClick += new System.EventHandler(this.OnEditEmployee);
            // 
            // empGroupBox
            // 
            this.empGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empGroupBox.Controls.Add(this.empSearchTextBox);
            this.empGroupBox.Controls.Add(this.empSearchBtn);
            this.empGroupBox.Controls.Add(this.empListBox);
            this.empGroupBox.Controls.Add(this.createEvent);
            this.empGroupBox.Location = new System.Drawing.Point(0, 27);
            this.empGroupBox.Name = "empGroupBox";
            this.empGroupBox.Size = new System.Drawing.Size(682, 426);
            this.empGroupBox.TabIndex = 2;
            this.empGroupBox.TabStop = false;
            // 
            // empSearchTextBox
            // 
            this.empSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.empSearchTextBox.Location = new System.Drawing.Point(159, 382);
            this.empSearchTextBox.Name = "empSearchTextBox";
            this.empSearchTextBox.Size = new System.Drawing.Size(418, 29);
            this.empSearchTextBox.TabIndex = 5;
            this.empSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSerchEmployeeKetEnter);
            // 
            // empSearchBtn
            // 
            this.empSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchBtn.Location = new System.Drawing.Point(583, 380);
            this.empSearchBtn.Name = "empSearchBtn";
            this.empSearchBtn.Size = new System.Drawing.Size(92, 33);
            this.empSearchBtn.TabIndex = 4;
            this.empSearchBtn.Text = "Найти";
            this.empSearchBtn.UseVisualStyleBackColor = true;
            this.empSearchBtn.Click += new System.EventHandler(this.OnSearchEmployee);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(682, 28);
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
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDown = contextMenuStrip;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.employeeToolStripMenuItem.Text = "Сотрудники";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.OnShowEmployee);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.empGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Main";
            this.Text = "TradeUnion";
            contextMenuStrip.ResumeLayout(false);
            this.empGroupBox.ResumeLayout(false);
            this.empGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createEvent;
        private System.Windows.Forms.ListBox empListBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.GroupBox empGroupBox;
        private System.Windows.Forms.TextBox empSearchTextBox;
        private System.Windows.Forms.Button empSearchBtn;
        private System.Windows.Forms.ToolStripMenuItem editEmployee;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
    }
}

