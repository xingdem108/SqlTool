using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SqlTool
{
    public partial class SqlTool : Form
    {
        public SqlTool()
        {
            InitializeComponent();
            InitConfig();
        }

        private void SqlTool_Load(object sender, EventArgs e)
        {

        }

        public void InitConfig()
        {
            textServer.Text = ConfigurationManager.AppSettings["Server"].ToString();
            textUser.Text = ConfigurationManager.AppSettings["User"].ToString();
            textPassword.Text = ConfigurationManager.AppSettings["Password"].ToString();
        }

        private void texServer_Leave(object sender, EventArgs e)
        {
            CommonHelper.ChangeConfiguration("Server", textServer.Text);
        }
    }
}
