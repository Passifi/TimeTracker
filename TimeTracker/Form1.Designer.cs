namespace TimeTracker
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Duration_txtbox = new System.Windows.Forms.TextBox();
            this.category_txtbox = new System.Windows.Forms.TextBox();
            this.tableSelection_dropdown = new System.Windows.Forms.ComboBox();
            this.duration_lbl = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.skillselect_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.insertdata_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Duration_txtbox
            // 
            this.Duration_txtbox.Location = new System.Drawing.Point(61, 26);
            this.Duration_txtbox.Name = "Duration_txtbox";
            this.Duration_txtbox.Size = new System.Drawing.Size(56, 20);
            this.Duration_txtbox.TabIndex = 0;
            // 
            // category_txtbox
            // 
            this.category_txtbox.Location = new System.Drawing.Point(61, 52);
            this.category_txtbox.Name = "category_txtbox";
            this.category_txtbox.Size = new System.Drawing.Size(56, 20);
            this.category_txtbox.TabIndex = 1;
            // 
            // tableSelection_dropdown
            // 
            this.tableSelection_dropdown.FormattingEnabled = true;
            this.tableSelection_dropdown.Location = new System.Drawing.Point(123, 26);
            this.tableSelection_dropdown.Name = "tableSelection_dropdown";
            this.tableSelection_dropdown.Size = new System.Drawing.Size(121, 21);
            this.tableSelection_dropdown.TabIndex = 2;
            // 
            // duration_lbl
            // 
            this.duration_lbl.AutoSize = true;
            this.duration_lbl.Location = new System.Drawing.Point(8, 26);
            this.duration_lbl.Name = "duration_lbl";
            this.duration_lbl.Size = new System.Drawing.Size(47, 13);
            this.duration_lbl.TabIndex = 3;
            this.duration_lbl.Text = "Duration";
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.Location = new System.Drawing.Point(6, 55);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(49, 13);
            this.category_lbl.TabIndex = 4;
            this.category_lbl.Text = "Category";
            // 
            // skillselect_lbl
            // 
            this.skillselect_lbl.AutoSize = true;
            this.skillselect_lbl.Location = new System.Drawing.Point(120, 10);
            this.skillselect_lbl.Name = "skillselect_lbl";
            this.skillselect_lbl.Size = new System.Drawing.Size(73, 13);
            this.skillselect_lbl.TabIndex = 5;
            this.skillselect_lbl.Text = "Skill Selection";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.insertdata_btn);
            this.panel1.Controls.Add(this.skillselect_lbl);
            this.panel1.Controls.Add(this.Duration_txtbox);
            this.panel1.Controls.Add(this.category_lbl);
            this.panel1.Controls.Add(this.category_txtbox);
            this.panel1.Controls.Add(this.duration_lbl);
            this.panel1.Controls.Add(this.tableSelection_dropdown);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 162);
            this.panel1.TabIndex = 6;
            // 
            // insertdata_btn
            // 
            this.insertdata_btn.Location = new System.Drawing.Point(169, 124);
            this.insertdata_btn.Name = "insertdata_btn";
            this.insertdata_btn.Size = new System.Drawing.Size(75, 23);
            this.insertdata_btn.TabIndex = 6;
            this.insertdata_btn.Text = "Save";
            this.insertdata_btn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 327);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "TimeTracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Duration_txtbox;
        private System.Windows.Forms.TextBox category_txtbox;
        private System.Windows.Forms.ComboBox tableSelection_dropdown;
        private System.Windows.Forms.Label duration_lbl;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.Label skillselect_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button insertdata_btn;
    }
}

