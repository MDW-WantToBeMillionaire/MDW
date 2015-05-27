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

namespace MDWquizz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.database1DataSet.Players);

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::MDWquizz.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO Players(Player_Id,Player_Name) values(" + txtId.Text + ",'" + txtName.Text + "')";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("Register successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.playersTableAdapter.Fill(this.database1DataSet.Players);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::MDWquizz.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "SELECT * FROM Players where Player_Id='" + txtId.Text + "' AND Player_Name='" + txtName.Text + "'";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("Let's start game!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Game g = new Game();
                g.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            this.playersTableAdapter.Fill(this.database1DataSet.Players);
        }
        
    }
}
