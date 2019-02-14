using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Patientenverwaltung
{
    public partial class New_patient : Form
    {
        public New_patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            char geschlecht = ' ';
            if (radioButton_m.Checked)
            {
                geschlecht = 'm';
            }
            else if (radioButton_w.Checked) {
                geschlecht = 'w';
            }

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "db_patienverwaltung";
            if (dbCon.IsConnect())
            {
                try
                {
                    string query = string.Format("INSERT INTO patient ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' ) VALUE '",
                        textBox_name.Text, textBox_vorname.Text, textBox_adresse.Text, textBox_versich.Text, geschlecht, dateTimePicker_geburtstag.Value.Date);
                    var cmd = new MySqlCommand(query, dbCon.Connection);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dbCon.Close();
            }
        }
    }
}
