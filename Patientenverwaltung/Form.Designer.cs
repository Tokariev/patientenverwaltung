namespace Patientenverwaltung
{
    partial class Form1
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
            this.btn_db_conn = new System.Windows.Forms.Button();
            this.listBox_sql = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_db_conn
            // 
            this.btn_db_conn.Location = new System.Drawing.Point(681, 415);
            this.btn_db_conn.Name = "btn_db_conn";
            this.btn_db_conn.Size = new System.Drawing.Size(107, 23);
            this.btn_db_conn.TabIndex = 0;
            this.btn_db_conn.Text = "DB Connection";
            this.btn_db_conn.UseVisualStyleBackColor = true;
            this.btn_db_conn.Click += new System.EventHandler(this.btn_db_conn_Click);
            // 
            // listBox_sql
            // 
            this.listBox_sql.FormattingEnabled = true;
            this.listBox_sql.Location = new System.Drawing.Point(21, 12);
            this.listBox_sql.Name = "listBox_sql";
            this.listBox_sql.Size = new System.Drawing.Size(263, 420);
            this.listBox_sql.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_sql);
            this.Controls.Add(this.btn_db_conn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_db_conn;
        private System.Windows.Forms.ListBox listBox_sql;
    }
}

