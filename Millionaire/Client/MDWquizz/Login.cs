using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using MDWquizz.ServiceReference1;
using System.Diagnostics;

namespace MDWquizz
{
    public partial class Login : Form,IGameplayCallback
    {
        private ServiceReference1.GameplayClient proxy;

        public Login()
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            proxy = new ServiceReference1.GameplayClient(instanceContext);
        }

        public void ShowNextQuestion()
        {
            throw new NotImplementedException();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            int id;
            string pwd;

            if (tb_id.Text != "" && tb_pwd.Text != "")
            {
                id = Convert.ToInt32(tb_id.Text);
                pwd = tb_pwd.Text;
                if (proxy.CheckPlayer(id, pwd))
                {
                    Game newGame = new Game();
                    newGame.Show();
                    this.Hide();
                }
                else
                {
                    tb_id.Text = "";
                    tb_pwd.Text = "";
                    MessageBox.Show("Id or Password is not correct!");
                }
            }
            else 
            {
                MessageBox.Show("Dont leave it blank!");
            }
            
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }
    }
}
