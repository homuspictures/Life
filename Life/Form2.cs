using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
namespace Life
{
    public partial class Form2 : Form                               //лаборатория
    {
        static string name = Register.name;                         //имя пользователя, передается из формы регистрации
        public static string loadname;                              //имя загружаемого сохранения
        public static bool flag=false;                              //загрузка
        microbs microb = new microbs(name);                         //клетки
        Image jpg;                                                  //иконка сохранения
        string[] fales;                                             //сохранения
        public Form2()
        {
            InitializeComponent();
            fales = Directory.GetFiles(microb.papka, "*.jpg");            
            int d = fales.Length;
            if (d==0)                                               
            {
               label1.Text="У вас пока нет образцов!";
                load.Enabled = false;                                //кнопка загрузки
                del.Enabled = false;                                 //кнопка удаления
            }
            else
            {
                load.Enabled = true;
                del.Enabled = true;
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();             
                FileBox.Columns.Add(Column);
                for (int i = 0; i < fales.Length; i++)
                {
                    FileBox.Rows.Add(fales[i].Remove(0, microb.papka.Length + 1));          
                }
            }
        }
        private void FileBox_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)               //выбор сохранения
        {
                int i = FileBox.SelectedCells[0].RowIndex;                  
                if (i>fales.Length-1)                              
                {
                    MessageBox.Show("Образец пустой!");
                    load.Enabled = false;
                    del.Enabled = false;
                }
                else
                {
                    load.Enabled = true;
                    del.Enabled = true;
                    jpg = Image.FromFile(fales[i]);         
                    pictureBox1.Image = jpg;                   
                }



        }

        private void del_Click(object sender, EventArgs e)                              //удаление
        {
                jpg.Dispose();                                          
                pictureBox1.Image = Properties.Resources.pistbox;           
                string temp;                                    
                int j;                                         
                int i = FileBox.SelectedCells[0].RowIndex;         
                temp = fales[i];                                
                FileBox.Rows.RemoveAt(i);                   
                for (j = i; j < fales.Length - 1; j++)
                {
                    fales[j] = fales[j + 1];                
                }
                fales[j] = null;                            
                Array.Resize(ref fales, fales.Length - 1);      
                microb.Delete_Files(temp);                  
        }

        private void load_Click(object sender, EventArgs e)                      //загрузка сохранения
        {
            flag = true;                                    
            int i = FileBox.SelectedCells[0].RowIndex;          
             loadname = microb.NameTXT(fales[i]);           
             Load_Game(loadname);                           
             this.Close();                                  
        }
        public void Load_Game(string loadname)                                  //загрузка игры
        {
            
            if (loadname != null)           
            {
                StreamReader stream = new StreamReader(loadname);          
                string[] temp;              
                int a = 0, b = 0;           
                temp = stream.ReadToEnd().Split(' ');           
                for (int i = 0; i < temp.Length-1; i++)
                {
                    if (temp[i] == "7CfC00")       
                    {
                        Form1.massBool[a, b] = true;            
                        Form1.btn[a, b].BackColor = Color.FromName("LawnGreen");            
                    }
                    if (temp[i] == "000000")        
                    {
                        Form1.massBool[a, b] = false;
                        Form1.btn[a, b].BackColor = Color.FromName("Black");
                    }
                    if (b == 39)       
                    {
                        a++; b = 0; continue;
                    }
                    b++;
                }
                stream.Close();         
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)         //закрытие лаборатории
        {
            Form forma = Application.OpenForms[0];         
            forma.Show();
        }
        
    }

}
