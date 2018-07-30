using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Life
{ 
    public partial class Register : Form                                    //вход
    {
        public static string name;                                          //имя пользователя
        string papka;                                                       //новая папка
        public Register()
        {
            InitializeComponent();
            
        }

        private void Start_Click(object sender, EventArgs e)                //начало игры
        {
            name = Convert.ToString(textBox1.Text); 
            microbs microb = new microbs(name);
            if (microb.ReadFromFile(name) == false)        
            {
                papka =microb.papka;
                System.IO.Directory.CreateDirectory(papka);         
                microb.AddUser(name);                   
            }
            this.Close();
        }

    }

}
