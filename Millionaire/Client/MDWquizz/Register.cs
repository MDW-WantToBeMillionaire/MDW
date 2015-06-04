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
    public partial class Register : Form,IGameplayCallback
    {
        private ServiceReference1.GameplayClient proxy;
        public int id;
        public string name;
        public string password;
        public Register()
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            proxy = new ServiceReference1.GameplayClient(instanceContext);
        }



        public void ShowNextQuestion()
        {
            throw new NotImplementedException();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string password = textBox3.Text;
            if (proxy.AddPlayer(id, name, password) > 0)
            {
                MessageBox.Show("Registered sucessfully!");
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Something went wrong!");
            }
            
        }
    }
}
