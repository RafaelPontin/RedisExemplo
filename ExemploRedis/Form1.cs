using ExemploRedis.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploRedis
{
    public partial class Form1 : Form
    {
        private RedisUtil redisUtil;
        private string host = "127.0.0.1:6379"; 

        public Form1()
        {
            redisUtil = new RedisUtil(host);
            InitializeComponent();
        }

        private void btSet_Click(object sender, EventArgs e)
        {
            if(!txtChave.Text.Equals("") && !txtValor.Text.Equals(""))
            {
                redisUtil.Set(txtChave.Text, txtValor.Text);
                txtValor.Text = "Sucesso";
            }
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            if(!txtChave.Text.Equals(""))
            {
                string valor = redisUtil.Get(txtChave.Text);
                txtValor.Text = valor;
            }
        }
    }
}
