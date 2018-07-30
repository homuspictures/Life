using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
namespace Life
{
     class microbs                                                      //поьзователи
    {
        public string name;                                             //имя пользователя
        public string papka;                                            //путь к папке пользователя
        public string jpgname;                                          //путь к иконке сохранения
        public string txtname;                                          //путь к сохранению
        const string way=@"users\";                                     //путь по умолчанию
        const string base_way =@"base.txt";                             //путь к базе
 
        public microbs(string name){                
            this.name=name;
            papka=String.Concat(way,name);
        }

        public bool ReadFromFile(string name)                           //поиск пользователя по базе
        {
            string temp = "";               
            StreamReader stream = new StreamReader(base_way);  
            string[] users = (stream.ReadToEnd()).Split('\n');      
            for (int i = 0; i < users.Length; i++)
            {
                temp = users[i];
                if (users[i] == String.Concat(name,"\r"))       
                {
                    return true;
                }
            }
                stream.Close();
            return false;

            }

        public void AddUser(string name)                                            //добавление пользователя
        {
            StreamWriter stream = new StreamWriter(base_way, true);
            stream.WriteLine(name);
            stream.Close();
        }
        public void CreateJPG(Bitmap bmp, string filename)                          //сохранение иконки
        {
            jpgname = String.Concat(papka, @"\", filename, ".jpg");     
            bmp.Save(jpgname, ImageFormat.Bmp);         
        }
        public void CreateTXT(string[] data, string filename)                       //сохранение игрового поля
        {
            txtname = String.Concat(papka, @"\",filename, ".txt");          
            StreamWriter fstream = new StreamWriter(txtname, true, Encoding.UTF8);
            for (int i = 0; i < data.Length; i++)
            {
                    fstream.Write(data[i]+' ');        
            }
            fstream.Close();
        }
        public void Delete_Files(string name)                                       //удаление файлов сохранения
        {
            File.Delete(name);         
            string txt = name.Remove(name.IndexOf('.'));       
            name = String.Concat(txt,".txt");
            File.Delete(name);         

        }
        public string NameTXT(string nameJpg)                                       //преобразования пути к jpg в путь к txt
        {
            string txt = nameJpg.Remove(nameJpg.IndexOf('.'));
            nameJpg = String.Concat(txt, ".txt");
            return nameJpg;
        }
    }
}
