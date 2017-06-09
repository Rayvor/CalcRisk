using System.Drawing;
namespace CalcRisk
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрПредварительныхРезультатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPVtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выполнитьРасчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.LabelCoef = new System.Windows.Forms.ToolStripLabel();
            this.txtCoef = new System.Windows.Forms.ToolStripTextBox();
            this.LabelStartInvest = new System.Windows.Forms.ToolStripLabel();
            this.txtStartInvest = new System.Windows.Forms.ToolStripTextBox();
            this.LabelNumPeriods = new System.Windows.Forms.ToolStripLabel();
            this.nudNumPeriods = new CalcRisk.ToolStripNumberControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSourceInvest = new System.Windows.Forms.TabPage();
            this.dataGridBorrow = new System.Windows.Forms.DataGridView();
            this.panelBorrow = new System.Windows.Forms.Panel();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.dataGridEquity = new System.Windows.Forms.DataGridView();
            this.panelEquity = new System.Windows.Forms.Panel();
            this.lblEquity = new System.Windows.Forms.Label();
            this.tabMoneyFlows = new System.Windows.Forms.TabPage();
            this.dataGridDeterComp = new System.Windows.Forms.DataGridView();
            this.panelDeterComp = new System.Windows.Forms.Panel();
            this.labelDeterComp = new System.Windows.Forms.Label();
            this.dataGridRangeComp = new System.Windows.Forms.DataGridView();
            this.panelRangeComp = new System.Windows.Forms.Panel();
            this.labelRangeComp = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSourceInvest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).BeginInit();
            this.panelBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquity)).BeginInit();
            this.panelEquity.SuspendLayout();
            this.tabMoneyFlows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeterComp)).BeginInit();
            this.panelDeterComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRangeComp)).BeginInit();
            this.panelRangeComp.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.расчетToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(856, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // расчетToolStripMenuItem
            // 
            this.расчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрПредварительныхРезультатовToolStripMenuItem,
            this.построитьГрафикToolStripMenuItem,
            this.toolStripSeparator1,
            this.выполнитьРасчетToolStripMenuItem});
            this.расчетToolStripMenuItem.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            this.расчетToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.расчетToolStripMenuItem.Text = "Расчет";
            // 
            // просмотрПредварительныхРезультатовToolStripMenuItem
            // 
            this.просмотрПредварительныхРезультатовToolStripMenuItem.Name = "просмотрПредварительныхРезультатовToolStripMenuItem";
            this.просмотрПредварительныхРезультатовToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.просмотрПредварительныхРезультатовToolStripMenuItem.Text = "Просмотр предварительных результатов";
            this.просмотрПредварительныхРезультатовToolStripMenuItem.Click += new System.EventHandler(this.просмотрПредварительныхРезультатовToolStripMenuItem_Click);
            // 
            // построитьГрафикToolStripMenuItem
            // 
            this.построитьГрафикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctToolStripMenuItem,
            this.nPVtToolStripMenuItem,
            this.vtToolStripMenuItem});
            this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
            this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.построитьГрафикToolStripMenuItem.Text = "Построить график";
            // 
            // ctToolStripMenuItem
            // 
            this.ctToolStripMenuItem.Name = "ctToolStripMenuItem";
            this.ctToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.ctToolStripMenuItem.Text = "Ct";
            this.ctToolStripMenuItem.Click += new System.EventHandler(this.ctToolStripMenuItem_Click);
            // 
            // nPVtToolStripMenuItem
            // 
            this.nPVtToolStripMenuItem.Name = "nPVtToolStripMenuItem";
            this.nPVtToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.nPVtToolStripMenuItem.Text = "NPVt";
            this.nPVtToolStripMenuItem.Click += new System.EventHandler(this.nPVtToolStripMenuItem_Click);
            // 
            // vtToolStripMenuItem
            // 
            this.vtToolStripMenuItem.Name = "vtToolStripMenuItem";
            this.vtToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.vtToolStripMenuItem.Text = "Vt";
            this.vtToolStripMenuItem.Click += new System.EventHandler(this.vtToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // выполнитьРасчетToolStripMenuItem
            // 
            this.выполнитьРасчетToolStripMenuItem.Name = "выполнитьРасчетToolStripMenuItem";
            this.выполнитьРасчетToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.выполнитьРасчетToolStripMenuItem.Text = "Выполнить расчет";
            this.выполнитьРасчетToolStripMenuItem.Click += new System.EventHandler(this.выполнитьРасчетToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelCoef,
            this.txtCoef,
            this.LabelStartInvest,
            this.txtStartInvest,
            this.LabelNumPeriods,
            this.nudNumPeriods});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 27);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(856, 30);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // LabelCoef
            // 
            this.LabelCoef.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelCoef.Margin = new System.Windows.Forms.Padding(35, 1, 0, 2);
            this.LabelCoef.Name = "LabelCoef";
            this.LabelCoef.Size = new System.Drawing.Size(200, 19);
            this.LabelCoef.Text = "Коэффициент дисконтирования";
            // 
            // txtCoef
            // 
            this.txtCoef.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(58, 27);
            this.txtCoef.Text = "1,12";
            this.txtCoef.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStartInvest
            // 
            this.LabelStartInvest.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelStartInvest.Name = "LabelStartInvest";
            this.LabelStartInvest.Size = new System.Drawing.Size(203, 19);
            this.LabelStartInvest.Text = "Первоначальные кап. вложения";
            // 
            // txtStartInvest
            // 
            this.txtStartInvest.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtStartInvest.Name = "txtStartInvest";
            this.txtStartInvest.Size = new System.Drawing.Size(58, 27);
            this.txtStartInvest.Text = "26000";
            this.txtStartInvest.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelNumPeriods
            // 
            this.LabelNumPeriods.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelNumPeriods.Name = "LabelNumPeriods";
            this.LabelNumPeriods.Size = new System.Drawing.Size(74, 19);
            this.LabelNumPeriods.Text = "Число ПУП";
            // 
            // nudNumPeriods
            // 
            this.nudNumPeriods.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.nudNumPeriods.Name = "nudNumPeriods";
            this.nudNumPeriods.Size = new System.Drawing.Size(39, 27);
            this.nudNumPeriods.Text = "12";
            this.nudNumPeriods.ValueChanged += new System.EventHandler(this.numPeriods_ValueChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSourceInvest);
            this.tabControl.Controls.Add(this.tabMoneyFlows);
            this.tabControl.Controls.Add(this.tabResults);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Akrobat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(856, 554);
            this.tabControl.TabIndex = 2;
            // 
            // tabSourceInvest
            // 
            this.tabSourceInvest.Controls.Add(this.dataGridBorrow);
            this.tabSourceInvest.Controls.Add(this.panelBorrow);
            this.tabSourceInvest.Controls.Add(this.dataGridEquity);
            this.tabSourceInvest.Controls.Add(this.panelEquity);
            this.tabSourceInvest.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSourceInvest.Location = new System.Drawing.Point(4, 28);
            this.tabSourceInvest.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabSourceInvest.Name = "tabSourceInvest";
            this.tabSourceInvest.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabSourceInvest.Size = new System.Drawing.Size(848, 522);
            this.tabSourceInvest.TabIndex = 0;
            this.tabSourceInvest.Text = "Источники финансирования";
            this.tabSourceInvest.UseVisualStyleBackColor = true;
            // 
            // dataGridBorrow
            // 
            this.dataGridBorrow.AllowUserToAddRows = false;
            this.dataGridBorrow.AllowUserToDeleteRows = false;
            this.dataGridBorrow.AllowUserToResizeRows = false;
            this.dataGridBorrow.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBorrow.Location = new System.Drawing.Point(2, 278);
            this.dataGridBorrow.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridBorrow.Name = "dataGridBorrow";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridBorrow.RowHeadersVisible = false;
            this.dataGridBorrow.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridBorrow.Size = new System.Drawing.Size(844, 239);
            this.dataGridBorrow.TabIndex = 1;
            // 
            // panelBorrow
            // 
            this.panelBorrow.Controls.Add(this.lblBorrow);
            this.panelBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorrow.Location = new System.Drawing.Point(2, 247);
            this.panelBorrow.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelBorrow.Name = "panelBorrow";
            this.panelBorrow.Size = new System.Drawing.Size(844, 31);
            this.panelBorrow.TabIndex = 5;
            // 
            // lblBorrow
            // 
            this.lblBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBorrow.Font = new System.Drawing.Font("Akrobat Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrow.Location = new System.Drawing.Point(0, 0);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(844, 31);
            this.lblBorrow.TabIndex = 2;
            this.lblBorrow.Text = "Заемный капитал";
            this.lblBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridEquity
            // 
            this.dataGridEquity.AllowUserToAddRows = false;
            this.dataGridEquity.AllowUserToDeleteRows = false;
            this.dataGridEquity.AllowUserToResizeRows = false;
            this.dataGridEquity.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridEquity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquity.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridEquity.Location = new System.Drawing.Point(2, 34);
            this.dataGridEquity.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridEquity.Name = "dataGridEquity";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquity.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridEquity.RowHeadersVisible = false;
            this.dataGridEquity.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridEquity.Size = new System.Drawing.Size(844, 213);
            this.dataGridEquity.TabIndex = 0;
            // 
            // panelEquity
            // 
            this.panelEquity.Controls.Add(this.lblEquity);
            this.panelEquity.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEquity.Location = new System.Drawing.Point(2, 5);
            this.panelEquity.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelEquity.Name = "panelEquity";
            this.panelEquity.Size = new System.Drawing.Size(844, 29);
            this.panelEquity.TabIndex = 4;
            // 
            // lblEquity
            // 
            this.lblEquity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquity.Font = new System.Drawing.Font("Akrobat Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquity.Location = new System.Drawing.Point(0, 0);
            this.lblEquity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquity.Name = "lblEquity";
            this.lblEquity.Size = new System.Drawing.Size(844, 29);
            this.lblEquity.TabIndex = 2;
            this.lblEquity.Text = "Собственный капитал";
            this.lblEquity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMoneyFlows
            // 
            this.tabMoneyFlows.Controls.Add(this.dataGridDeterComp);
            this.tabMoneyFlows.Controls.Add(this.panelDeterComp);
            this.tabMoneyFlows.Controls.Add(this.dataGridRangeComp);
            this.tabMoneyFlows.Controls.Add(this.panelRangeComp);
            this.tabMoneyFlows.Location = new System.Drawing.Point(4, 28);
            this.tabMoneyFlows.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabMoneyFlows.Name = "tabMoneyFlows";
            this.tabMoneyFlows.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabMoneyFlows.Size = new System.Drawing.Size(848, 522);
            this.tabMoneyFlows.TabIndex = 1;
            this.tabMoneyFlows.Text = "Денежные потоки";
            this.tabMoneyFlows.UseVisualStyleBackColor = true;
            // 
            // dataGridDeterComp
            // 
            this.dataGridDeterComp.AllowUserToAddRows = false;
            this.dataGridDeterComp.AllowUserToDeleteRows = false;
            this.dataGridDeterComp.AllowUserToResizeRows = false;
            this.dataGridDeterComp.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDeterComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridDeterComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeterComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dataGridDeterComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDeterComp.Location = new System.Drawing.Point(2, 278);
            this.dataGridDeterComp.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridDeterComp.Name = "dataGridDeterComp";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDeterComp.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridDeterComp.RowHeadersVisible = false;
            this.dataGridDeterComp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridDeterComp.Size = new System.Drawing.Size(844, 239);
            this.dataGridDeterComp.TabIndex = 8;
            // 
            // panelDeterComp
            // 
            this.panelDeterComp.Controls.Add(this.labelDeterComp);
            this.panelDeterComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeterComp.Location = new System.Drawing.Point(2, 247);
            this.panelDeterComp.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelDeterComp.Name = "panelDeterComp";
            this.panelDeterComp.Size = new System.Drawing.Size(844, 31);
            this.panelDeterComp.TabIndex = 7;
            // 
            // labelDeterComp
            // 
            this.labelDeterComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeterComp.Font = new System.Drawing.Font("Akrobat Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeterComp.Location = new System.Drawing.Point(0, 0);
            this.labelDeterComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeterComp.Name = "labelDeterComp";
            this.labelDeterComp.Size = new System.Drawing.Size(844, 31);
            this.labelDeterComp.TabIndex = 2;
            this.labelDeterComp.Text = "Детерминированые составляющие";
            this.labelDeterComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridRangeComp
            // 
            this.dataGridRangeComp.AllowUserToAddRows = false;
            this.dataGridRangeComp.AllowUserToDeleteRows = false;
            this.dataGridRangeComp.AllowUserToResizeRows = false;
            this.dataGridRangeComp.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRangeComp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridRangeComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRangeComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridRangeComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridRangeComp.Location = new System.Drawing.Point(2, 34);
            this.dataGridRangeComp.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridRangeComp.Name = "dataGridRangeComp";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Akrobat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRangeComp.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridRangeComp.RowHeadersVisible = false;
            this.dataGridRangeComp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridRangeComp.Size = new System.Drawing.Size(844, 213);
            this.dataGridRangeComp.TabIndex = 6;
            // 
            // panelRangeComp
            // 
            this.panelRangeComp.Controls.Add(this.labelRangeComp);
            this.panelRangeComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRangeComp.Location = new System.Drawing.Point(2, 5);
            this.panelRangeComp.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelRangeComp.Name = "panelRangeComp";
            this.panelRangeComp.Size = new System.Drawing.Size(844, 29);
            this.panelRangeComp.TabIndex = 5;
            // 
            // labelRangeComp
            // 
            this.labelRangeComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRangeComp.Font = new System.Drawing.Font("Akrobat Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRangeComp.Location = new System.Drawing.Point(0, 0);
            this.labelRangeComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRangeComp.Name = "labelRangeComp";
            this.labelRangeComp.Size = new System.Drawing.Size(844, 29);
            this.labelRangeComp.TabIndex = 2;
            this.labelRangeComp.Text = "Диапазонные составляющие";
            this.labelRangeComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dataGridResults);
            this.tabResults.Location = new System.Drawing.Point(4, 28);
            this.tabResults.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabResults.Size = new System.Drawing.Size(848, 522);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Результаты";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Gainsboro;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle25;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Gainsboro;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle26;
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Gainsboro;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle27;
            this.Column3.HeaderText = "Инт";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Gainsboro;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 20;
            // 
            // Column5
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Gainsboro;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column5.HeaderText = "Название";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.AllowUserToResizeRows = false;
            this.dataGridResults.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(2, 5);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.RowHeadersVisible = false;
            this.dataGridResults.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridResults.Size = new System.Drawing.Size(844, 512);
            this.dataGridResults.TabIndex = 0;
            // 
            // Column6
            // 
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Gainsboro;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle30;
            this.Column6.HeaderText = "Период";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ct";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "NPVt";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Vt";
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Rt";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "SigmaNPV";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 611);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "mainForm";
            this.Text = "Оценка риска инвестиционного проекта";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSourceInvest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).EndInit();
            this.panelBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquity)).EndInit();
            this.panelEquity.ResumeLayout(false);
            this.tabMoneyFlows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeterComp)).EndInit();
            this.panelDeterComp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRangeComp)).EndInit();
            this.panelRangeComp.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрПредварительныхРезультатовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPVtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выполнитьРасчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private ToolStripNumberControl nudNumPeriods;
        private System.Windows.Forms.ToolStripLabel LabelCoef;
        private System.Windows.Forms.ToolStripTextBox txtCoef;
        private System.Windows.Forms.ToolStripLabel LabelStartInvest;
        private System.Windows.Forms.ToolStripTextBox txtStartInvest;
        private System.Windows.Forms.ToolStripLabel LabelNumPeriods;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSourceInvest;
        private System.Windows.Forms.TabPage tabMoneyFlows;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelEquity;
        private System.Windows.Forms.Label lblEquity;
        private System.Windows.Forms.DataGridView dataGridBorrow;
        private System.Windows.Forms.Panel panelBorrow;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.DataGridView dataGridEquity;
        private System.Windows.Forms.DataGridView dataGridDeterComp;
        private System.Windows.Forms.Panel panelDeterComp;
        private System.Windows.Forms.Label labelDeterComp;
        private System.Windows.Forms.DataGridView dataGridRangeComp;
        private System.Windows.Forms.Panel panelRangeComp;
        private System.Windows.Forms.Label labelRangeComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}

