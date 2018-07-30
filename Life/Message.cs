using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Message : Form                                 //создание сохранения
    {
        public static string filename; 
        public Message()
        {
            InitializeComponent();
            textBox1.Text = "";
        }

        private void yes_Click(object sender, EventArgs e)
        {
            filename = Convert.ToString(textBox1.Text);
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
