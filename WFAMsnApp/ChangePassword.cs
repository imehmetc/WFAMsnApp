using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMsnApp
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtPassword2.UseSystemPasswordChar = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string eMail = txtEmailAdress.Text;
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;

            if (password != password2)
            {
                MessageBox.Show("Şifreler eşleşmiyor!.");
            }
            else
            {
                PasswordChange(eMail, password);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword2.UseSystemPasswordChar = false;
                chkShowPassword.Text = "Hide Passwords";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword2.UseSystemPasswordChar = true;
                chkShowPassword.Text = "Show Passwords";

            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=IMEHMETC;Initial Catalog=MsnApp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        void PasswordChange(string eMail, string password)
        {
            try
            {
                con.Open();
                string query = "UPDATE Users SET password = '" + password + "' WHERE email = '" + eMail + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                int rowsAffected = cmd.ExecuteNonQuery(); // Eğer bir INSERT, UPDATE ya da DELETE gibi veritabanı üzerinde kayıt ekleyen, güncelleyen veya silen bir komut çalıştırılmışsa, ExecuteNonQuery() bu işlemin sonucunda etkilenen satır sayısını döndürür. Yani, bu satırı kullanarak kaç satırın değiştirildiğini öğrenebilirsiniz.

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şifreniz başarıyla değiştirildi! ");
                }
                else
                {
                    MessageBox.Show("Email hatalı..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void lblLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WFAMsnApp.Login loginForm = new WFAMsnApp.Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
