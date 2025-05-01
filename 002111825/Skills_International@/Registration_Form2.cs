using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Skills_International_
{
    public partial class Registration_Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\My Campus\\Esoft DITEC\\002111825\\Skills_International@\\Student.mdf\";Integrated Security=True");
        string First_Name, Last_Name, Gender, Address, Email, Parent_Name, NIC;
        int Reg_No, Mobile_Phone, Home_Phone, Contact_No;
        DateTime dob;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DataGridView()
        {
            //con.Open();
            string query = "select * from Registration"; 
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            //sda.Fill(ds);
            
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                string query = "select * from Registration";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
               
                con.Close();
            }

            

            {
                Reg_No = int.Parse(cmbRegNo.Text);
                con.Open();
                string search = "select * from Registration where Reg_No = '" + Reg_No + "'";
                SqlCommand cmd = new SqlCommand(search, con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cmbRegNo.Text = read["Reg_No"].ToString();
                    txtFirstName.Text = read["First_Name"].ToString();
                    txtLastName.Text = read["Last_Name"].ToString();
                    dtpDOB.Text = read["dob"].ToString();
                    if (read["Gender"].ToString() == "male")
                    {
                        rdbMale.Checked = true;
                      
                    }
                    else
                    {
                        rdbFemale.Checked = true;
                       
                    }
                    txtAddress.Text = read["Address"].ToString();
                    txtEmail.Text = read["Email"].ToString();
                    txtMobilePhone.Text = read["Mobile_Phone"].ToString();
                    txtHomePhone.Text = read["Home_Phone"].ToString();
                    txtParentName.Text = read["Parent_Name"].ToString();
                    txtNIC.Text = read["NIC"].ToString();
                    txtContactNo.Text = read["Contact_No"].ToString();
                }
                con.Close();
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblRegNo_Click(object sender, EventArgs e)
        {

        }

        private void grpStudentRegistration_Enter(object sender, EventArgs e)
        {

        }

        private void Registration_Form2_Load(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void cmbReg_No_MouseClick(object sender, EventArgs e)
        {
            Reg_No = int.Parse(cmbRegNo.Text);
            Int32.TryParse(txtMobilePhone.Text, out Mobile_Phone);
            Int32.TryParse(txtHomePhone.Text, out Home_Phone);
            Int32.TryParse(txtContactNo.Text, out Contact_No);
            con.Open();
            string search = "select * from Registration where Reg_No = '" + Reg_No + "'";
            SqlCommand cmd = new SqlCommand(search, con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmbRegNo.Text = read["Reg_No"].ToString();
                txtFirstName.Text = read["First_Name"].ToString();
                txtLastName.Text = read["Last_Name"].ToString();
                dtpDOB.Text = read["Date_Of_Birth"].ToString();
                if (read["Gender"].ToString() == "Male")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }
                txtAddress.Text = read["Address"].ToString();
                txtEmail.Text = read["Email"].ToString();
                txtMobilePhone.Text = read["Mobile_Phone"].ToString();
                txtHomePhone.Text = read["Home_Phone"].ToString();
                txtParentName.Text = read["Parent_Name"].ToString();
                txtNIC.Text = read["NIC"].ToString();
                txtContactNo.Text = read["Contact_No"].ToString();

            }
            con.Close();
        
    }

       
        public Registration_Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LoadElement();
            con.Open();
            string add = "insert into Registration values('" + Reg_No + "','" + First_Name + "','" + Last_Name + "','" + dob + "','" + Gender + "', '" + Address + "','" + Email + "','" + Mobile_Phone + "','" + Home_Phone + "','" + Parent_Name + "','" + NIC + "','" + Contact_No + "')";
            SqlCommand cmd = new SqlCommand(add, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadElement();
            con.Open();
            string update = "update Registration set First_Name = '" + First_Name + "', Last_Name = '" + Last_Name + "', dob = '" + dob + "'" +
          ",Gender = '" + Gender + "', Address = '" + Address + "', Email = '" + Email + "', Mobile_Phone = '" + Mobile_Phone + "'" +
          ", Home_Phone = '" + Home_Phone + "', Parent_Name = '" + Parent_Name + "', NIC = '" + NIC + "', Contact_No = '" + Contact_No + "'" +
                " where Reg_No = '" + Reg_No + "'";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadElement();
                con.Open();
                string delete = "delete from Registration where Reg_No = '" + Reg_No + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Delete Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                cmbRegNo.ResetText();
                txtFirstName.Clear();
                txtLastName.Clear();
                dtpDOB.ResetText();
                rdbMale.Checked = false;
                rdbFemale.Checked = false;
                txtAddress.Clear();
                txtEmail.Clear();
                txtMobilePhone.Clear();
                txtHomePhone.Clear();
                txtParentName.Clear();
                txtNIC.Clear();
                txtContactNo.Clear();
                cmbRegNo.Focus();
            }
            else
            {
                Registration_Form2 Form = new Registration_Form2();
                Form.Focus();
            }


        }

        private void LoadElement()
        {
            Int32.TryParse(cmbRegNo.Text, out Reg_No);
            First_Name = txtFirstName.Text;
            Last_Name = txtLastName.Text;
            dob = dtpDOB.Value.Date;
            if (rdbMale.Checked == true)
            {
                Gender = "male";
            }
            else
            {
                Gender = "female";
            }
            Address = txtAddress.Text;
            Email = txtEmail.Text;
            Int32.TryParse(txtMobilePhone.Text, out Mobile_Phone);
            Int32.TryParse(txtHomePhone.Text, out Home_Phone);
            Parent_Name = txtParentName.Text;
            NIC = txtNIC.Text;
            Int32.TryParse(txtContactNo.Text, out Contact_No);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbRegNo.ResetText();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.ResetText();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            cmbRegNo.Focus();
        }


        private void Clear()
        {
                cmbRegNo.ResetText();
                txtFirstName.Clear();
                txtLastName.Clear();
                dtpDOB.ResetText();
                rdbMale.Checked = false;
                rdbFemale.Checked = false;
                txtAddress.Clear();
                txtEmail.Clear();
                txtMobilePhone.Clear();
                txtHomePhone.Clear();
                txtParentName.Clear();
                txtNIC.Clear();
                txtContactNo.Clear();
                cmbRegNo.Focus();         
        }
    }
}
