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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

            txtEmailAdress.MaxLength = 50;
            txtPassword.MaxLength = 50;
            txtAge.MaxLength = 3;
            txtGender.MaxLength = 15;

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                string eMailAdress = txtEmailAdress.Text.ToLower();
                string password = txtPassword.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string gender = txtGender.Text.ToLower();

                int etIsareti = eMailAdress.IndexOf("@");
                string kullaniciAdi = eMailAdress.Substring(0, etIsareti); // @ işaretinden önceki kısım
                string noktaVarMi = eMailAdress.Substring(etIsareti, eMailAdress.Length - kullaniciAdi.Length); // @ işaretindens sonraki kısım

                if (!noktaVarMi.Contains(".")) // @ işaretinden sonra '.' karakteri yoksa
                {
                    throw new ArgumentNullException();
                }
                else if (age < 0 || age > 150)
                {
                    throw new OverflowException();
                }
                else if (gender != "erkek"  && gender != "kadın")
                {
                    MessageBox.Show("Lütfen geçerli bir cinsiyet girin. ");
                }
                else
                {
                    UserRegister(eMailAdress, password, age, gender);
                }

                

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen geçerli bir Email adresi girin.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Email adresinde '@' olmak zorunda.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lütfen geçerli bir yaş girin.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir yaş girin.");
            }
        }

        private void lblLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WFAMsnApp.Login loginForm = new WFAMsnApp.Login();
            loginForm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                chkShowPassword.Text = "Hide Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                chkShowPassword.Text = "Show Password";
            }

        }

        SqlConnection con = new SqlConnection(@"Data Source=IMEHMETC;Initial Catalog=MsnApp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        void UserRegister(string eMailAdress, string password, int age, string gender)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Users (email, password, age, gender) VALUES ('" + eMailAdress + "', '" + password + "', '" + age.ToString() + "', '" + gender + "')";
                SqlCommand cmd = new SqlCommand(query, con); // Veritabanına veri göndermek, silmek, güncellemek için kullanılır.

                int rowsAffected = cmd.ExecuteNonQuery(); // Eğer bir INSERT, UPDATE ya da DELETE gibi veritabanı üzerinde kayıt ekleyen, güncelleyen veya silen bir komut çalıştırılmışsa, ExecuteNonQuery() bu işlemin sonucunda etkilenen satır sayısını döndürür. Yani, bu satırı kullanarak kaç satırın değiştirildiğini öğrenebilirsiniz.

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarılı! ");
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız..");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
