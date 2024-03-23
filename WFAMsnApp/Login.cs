using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace WFAMsnApp
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }


        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // default olarak '*' alır.

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string eMail = txtEmailAdress.Text;
                string password = txtPassword.Text;

                int etIsareti = eMail.IndexOf("@");
                string kullaniciAdi = eMail.Substring(0, etIsareti); // @ işaretinden önceki kısım
                string noktaVarMi = eMail.Substring(etIsareti, eMail.Length - kullaniciAdi.Length); // @ işaretindens sonraki kısım

                if (!noktaVarMi.Contains(".")) // @ işaretinden sonra '.' karakteri yoksa
                {
                    throw new ArgumentNullException();
                }

                UserLogin(eMail, password, kullaniciAdi);

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir Email adresi girin");
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
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
        void UserLogin(string mail, string password, string kullaniciAdi)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE email = '" + mail + "' AND password = '" + password + "'";


                SqlDataAdapter sda = new SqlDataAdapter(query, con); // sqldataadapter: veritabanından veri almak ve veritabanına veri göndermek için kullanılan bir nesnedir.
                DataTable dtable = new DataTable(); // datatable: bir veri tablosunu temsil eden bir .net framework sınıfıdır. veri tablosu, sorgulardan dönen verilerin saklanması için kullanılır. dönen veriler satırlar halinde tutulur.
                sda.Fill(dtable); // fill(): sqldataadapter tarafından belirtilen sorguya göre veri tablosunu doldurmak için kullanılan bir metoddur.

                if (dtable.Rows.Count > 0) // datatable'dan dönen veri var ise
                {
                    MessageBox.Show($"hoşgeldin {kullaniciAdi} !");

                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre hatalı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
                /* MessageBox.Show("Veritabanı: " + con.State.ToString()); */ // con.State: veri tabanı açık mı kapalı mı
            }
        }

        private void lblLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Register Form'a geçiş
            WFAMsnApp.Register registerForm = new WFAMsnApp.Register();
            registerForm.Show();
            this.Hide(); // şuanki formu gizler
        }

        private void lblLinkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change Password Form'a geçiş
            WFAMsnApp.ChangePassword changePasswordForm = new WFAMsnApp.ChangePassword();
            changePasswordForm.Show();
            this.Hide();
        }
    }
}
