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
            System.Windows.Forms.MenuStrip menuStrip;
            System.Windows.Forms.GroupBox groupBox;
            this.editEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empSearchTextBox = new System.Windows.Forms.TextBox();
            this.empSearchBtn = new System.Windows.Forms.Button();
            this.empListBox = new System.Windows.Forms.ListBox();
            this.createEvent = new System.Windows.Forms.Button();
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            addEmployee = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip = new System.Windows.Forms.MenuStrip();
            groupBox = new System.Windows.Forms.GroupBox();
            contextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            groupBox.SuspendLayout();
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
            contextMenuStrip.OwnerItem = this.employeeToolStripMenuItem;
            contextMenuStrip.Size = new System.Drawing.Size(211, 104);
            // 
            // addEmployee
            // 
            addEmployee.Name = "addEmployee";
            addEmployee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            addEmployee.Size = new System.Drawing.Size(210, 24);
            addEmployee.Text = "&Добавить";
            addEmployee.Click += new System.EventHandler(this.OnCreateEmployee);
            // 
            // editEmployee
            // 
            this.editEmployee.Enabled = false;
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(210, 24);
            this.editEmployee.Text = "&Изменить";
            this.editEmployee.Click += new System.EventHandler(this.OnEditEmployee);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Enabled = false;
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(210, 24);
            this.deleteEmployee.Text = "&Удалить";
            this.deleteEmployee.Click += new System.EventHandler(this.OnDeleteEmployee);
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(682, 28);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDown = contextMenuStrip;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.employeeToolStripMenuItem.Text = "&Правка";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.сотрудникиToolStripMenuItem.Text = "Архив помощи";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.OnShowEventTable);
            // 
            // groupBox
            // 
            groupBox.Controls.Add(this.empSearchTextBox);
            groupBox.Controls.Add(this.empSearchBtn);
            groupBox.Controls.Add(this.empListBox);
            groupBox.Controls.Add(this.createEvent);
            groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox.Location = new System.Drawing.Point(0, 28);
            groupBox.Name = "groupBox";
            groupBox.Size = new System.Drawing.Size(682, 425);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            // 
            // empSearchTextBox
            // 
            this.empSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.empSearchTextBox.Location = new System.Drawing.Point(152, 381);
            this.empSearchTextBox.Name = "empSearchTextBox";
            this.empSearchTextBox.Size = new System.Drawing.Size(426, 29);
            this.empSearchTextBox.TabIndex = 5;
            this.empSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSerchEmployeeKeyEnter);
            // 
            // empSearchBtn
            // 
            this.empSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchBtn.Location = new System.Drawing.Point(584, 379);
            this.empSearchBtn.Name = "empSearchBtn";
            this.empSearchBtn.Size = new System.Drawing.Size(90, 33);
            this.empSearchBtn.TabIndex = 4;
            this.empSearchBtn.Text = "Найти";
            this.empSearchBtn.UseVisualStyleBackColor = true;
            this.empSearchBtn.Click += new System.EventHandler(this.OnSearchEmployee);
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
            this.empListBox.Size = new System.Drawing.Size(682, 334);
            this.empListBox.TabIndex = 1;
            this.empListBox.SelectedIndexChanged += new System.EventHandler(this.OnEmployeeSelectionChanged);
            this.empListBox.DoubleClick += new System.EventHandler(this.OnEditEmployee);
            // 
            // createEvent
            // 
            this.createEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createEvent.Enabled = false;
            this.createEvent.Location = new System.Drawing.Point(6, 379);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(140, 33);
            this.createEvent.TabIndex = 0;
            this.createEvent.Text = "Оказать помощь";
            this.createEvent.UseVisualStyleBackColor = true;
            this.createEvent.Click += new System.EventHandler(this.OnCreateEvent);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(groupBox);
            this.Controls.Add(menuStrip);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Main";
            this.Text = "TradeUnion";
            contextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployee;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button createEvent;
        private System.Windows.Forms.ListBox empListBox;
        private System.Windows.Forms.Button empSearchBtn;
        private System.Windows.Forms.TextBox empSearchTextBox;
    }
}

