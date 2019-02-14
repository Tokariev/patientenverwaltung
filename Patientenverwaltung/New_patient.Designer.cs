namespace Patientenverwaltung
{
    partial class New_patient
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_vorname = new System.Windows.Forms.TextBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.textBox_versich = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_m = new System.Windows.Forms.RadioButton();
            this.radioButton_w = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_geburtstag = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(88, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(249, 26);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vorname.Location = new System.Drawing.Point(88, 60);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(249, 26);
            this.textBox_vorname.TabIndex = 1;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_adresse.Location = new System.Drawing.Point(88, 92);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(249, 26);
            this.textBox_adresse.TabIndex = 2;
            // 
            // textBox_versich
            // 
            this.textBox_versich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_versich.Location = new System.Drawing.Point(88, 124);
            this.textBox_versich.Name = "textBox_versich";
            this.textBox_versich.Size = new System.Drawing.Size(249, 26);
            this.textBox_versich.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_w);
            this.groupBox1.Controls.Add(this.radioButton_m);
            this.groupBox1.Location = new System.Drawing.Point(88, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geschlecht";
            // 
            // radioButton_m
            // 
            this.radioButton_m.AutoSize = true;
            this.radioButton_m.Location = new System.Drawing.Point(6, 19);
            this.radioButton_m.Name = "radioButton_m";
            this.radioButton_m.Size = new System.Drawing.Size(33, 17);
            this.radioButton_m.TabIndex = 0;
            this.radioButton_m.TabStop = true;
            this.radioButton_m.Text = "m";
            this.radioButton_m.UseVisualStyleBackColor = true;
            // 
            // radioButton_w
            // 
            this.radioButton_w.AutoSize = true;
            this.radioButton_w.Location = new System.Drawing.Point(65, 19);
            this.radioButton_w.Name = "radioButton_w";
            this.radioButton_w.Size = new System.Drawing.Size(33, 17);
            this.radioButton_w.TabIndex = 1;
            this.radioButton_w.TabStop = true;
            this.radioButton_w.Text = "w";
            this.radioButton_w.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_geburtstag
            // 
            this.dateTimePicker_geburtstag.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_geburtstag.Location = new System.Drawing.Point(88, 224);
            this.dateTimePicker_geburtstag.Name = "dateTimePicker_geburtstag";
            this.dateTimePicker_geburtstag.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_geburtstag.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_geburtstag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_versich);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.textBox_vorname);
            this.Controls.Add(this.textBox_name);
            this.Name = "New_patient";
            this.Text = "New_patient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_vorname;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.TextBox textBox_versich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_w;
        private System.Windows.Forms.RadioButton radioButton_m;
        private System.Windows.Forms.DateTimePicker dateTimePicker_geburtstag;
        private System.Windows.Forms.Button button1;
    }
}