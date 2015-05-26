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

namespace userlogintest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.database1DataSet.Players);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::userlogintest.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO Players(Player_Id,Player_Name) values("+txtID.Text+",'N"+txtName.Text+"')";
                SqlCommand exesql = new SqlCommand(sql,cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("You've login!", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.playersTableAdapter.Fill(this.database1DataSet.Players);
            }
            catch(Exception ex)
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
