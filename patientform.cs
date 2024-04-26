using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace hospital_mangment
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PatientClass P1 = new PatientClass(name.Text.ToString(), int.Parse(id.Text.ToString()), int.Parse(date.Text.ToString()), gender.Text.ToString(), int.Parse(number.Text.ToString()), password.Text.ToString(), address.Text.ToString(), sickness.Text.ToString(), history.Text.ToString(), int.Parse(emergency.Text.ToString()), mail.Text.ToString());
            string connstring = "Data Source=LAPTOP-AD5D06OP\\MSSQLSERVER1;Initial Catalog=Person_Database;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into register(name,id,date,gender,number,password,address,sickness,history,emergencyNumber,eMail)" +
                    "values('" + P1.name + "','" + P1.id + "','" + P1.date + "','" + P1.gender + "','" + P1.number + "','" + P1.password + "','" + P1.address + "','" + P1.sickness + "','" + P1.history + "','" + P1.emergencyNumber + "','" + P1.eMail + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Added");
            }

            try
            {
                if (name.Text != "" && id.Text != "" && date.Text != "" && gender.Text != "" && mail.Text != "" && number.Text != "" &&
                    emergency.Text != "" && sickness.Text != "" && history.Text != "" && address.Text != "" && password.Text != "" && verifyPass.Text != "")
                {
                    if (password.Text != verifyPass.Text)
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                }
                else
                    MessageBox.Show("Fill in the blinks!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r1 = new register();
            r1.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
