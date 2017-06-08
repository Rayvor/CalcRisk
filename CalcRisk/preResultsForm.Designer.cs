namespace CalcRisk
{
    partial class preResultsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMoneyFlows = new System.Windows.Forms.TabPage();
            this.tabRandomValues = new System.Windows.Forms.TabPage();
            this.tabMatrixCov = new System.Windows.Forms.TabPage();
            this.dataGridMoneyFlows = new System.Windows.Forms.DataGridView();
            this.dataGridRandomValues = new System.Windows.Forms.DataGridView();
            this.dataGridMatrixCov = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabMoneyFlows.SuspendLayout();
            this.tabRandomValues.SuspendLayout();
            this.tabMatrixCov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoneyFlows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRandomValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixCov)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMoneyFlows);
            this.tabControl.Controls.Add(this.tabRandomValues);
            this.tabControl.Controls.Add(this.tabMatrixCov);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(710, 476);
            this.tabControl.TabIndex = 0;
            // 
            // tabMoneyFlows
            // 
            this.tabMoneyFlows.Controls.Add(this.dataGridMoneyFlows);
            this.tabMoneyFlows.Location = new System.Drawing.Point(4, 28);
            this.tabMoneyFlows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMoneyFlows.Name = "tabMoneyFlows";
            this.tabMoneyFlows.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMoneyFlows.Size = new System.Drawing.Size(702, 444);
            this.tabMoneyFlows.TabIndex = 0;
            this.tabMoneyFlows.Text = "Денежные потоки";
            this.tabMoneyFlows.UseVisualStyleBackColor = true;
            // 
            // tabRandomValues
            // 
            this.tabRandomValues.Controls.Add(this.dataGridRandomValues);
            this.tabRandomValues.Location = new System.Drawing.Point(4, 28);
            this.tabRandomValues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRandomValues.Name = "tabRandomValues";
            this.tabRandomValues.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRandomValues.Size = new System.Drawing.Size(702, 444);
            this.tabRandomValues.TabIndex = 1;
            this.tabRandomValues.Text = "Сгенерированные случайные велечины";
            this.tabRandomValues.UseVisualStyleBackColor = true;
            // 
            // tabMatrixCov
            // 
            this.tabMatrixCov.Controls.Add(this.dataGridMatrixCov);
            this.tabMatrixCov.Location = new System.Drawing.Point(4, 28);
            this.tabMatrixCov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMatrixCov.Name = "tabMatrixCov";
            this.tabMatrixCov.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMatrixCov.Size = new System.Drawing.Size(702, 444);
            this.tabMatrixCov.TabIndex = 2;
            this.tabMatrixCov.Text = "Матрица ковариаций";
            this.tabMatrixCov.UseVisualStyleBackColor = true;
            // 
            // dataGridMoneyFlows
            // 
            this.dataGridMoneyFlows.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMoneyFlows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMoneyFlows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMoneyFlows.Location = new System.Drawing.Point(3, 4);
            this.dataGridMoneyFlows.Name = "dataGridMoneyFlows";
            this.dataGridMoneyFlows.Size = new System.Drawing.Size(696, 436);
            this.dataGridMoneyFlows.TabIndex = 0;
            // 
            // dataGridRandomValues
            // 
            this.dataGridRandomValues.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRandomValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRandomValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRandomValues.Location = new System.Drawing.Point(3, 4);
            this.dataGridRandomValues.Name = "dataGridRandomValues";
            this.dataGridRandomValues.Size = new System.Drawing.Size(696, 436);
            this.dataGridRandomValues.TabIndex = 1;
            // 
            // dataGridMatrixCov
            // 
            this.dataGridMatrixCov.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMatrixCov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrixCov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMatrixCov.Location = new System.Drawing.Point(3, 4);
            this.dataGridMatrixCov.Name = "dataGridMatrixCov";
            this.dataGridMatrixCov.Size = new System.Drawing.Size(696, 436);
            this.dataGridMatrixCov.TabIndex = 2;
            // 
            // preResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 476);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Akrobat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "preResultsForm";
            this.Text = "Результат расчетов";
            this.tabControl.ResumeLayout(false);
            this.tabMoneyFlows.ResumeLayout(false);
            this.tabRandomValues.ResumeLayout(false);
            this.tabMatrixCov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoneyFlows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRandomValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixCov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMoneyFlows;
        private System.Windows.Forms.TabPage tabRandomValues;
        private System.Windows.Forms.TabPage tabMatrixCov;
        private System.Windows.Forms.DataGridView dataGridMoneyFlows;
        private System.Windows.Forms.DataGridView dataGridRandomValues;
        private System.Windows.Forms.DataGridView dataGridMatrixCov;
    }
}