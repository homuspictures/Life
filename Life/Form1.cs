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
using System.Media;
namespace Life
{
   
    public partial class Form1 : Form                           //игровое поле
    {
        private bool stopFlag = false;                          //конец игры
        private bool pauseFlag = false;                         //пауза
        public static bool[,] massBool = new bool[40, 40];      //текущее состояние клеток
        private bool[,] massBoolTemp = new bool[40, 40];        //следующее поколение
        private int generation = 0;                             //поколения
        int alive = 0;                                          //кол-во живых
        int x = 250;                                            //координаты для генерации поля 
        int y =100;
        public static Button[,] btn = new Button[40, 40];       //клетки
        const int breakPointGeneration = 1000;                  //предельное количество поколений
        const int maxValue = 40;                                //максимальное количество клеток
        Message Mesage = new Message();                         //сохранение
        string name=Register.name;                              //имя пользователя
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < maxValue; i++)                  //генерация игрового поля
            {
                for (int j = 0; j < maxValue; j++)
                {
                    btn[i, j] = new Button();              
                    btn[i, j].Location = new Point(x, y);            
                    btn[i, j].Size = new Size(10, 10);                
                    btn[i, j].BackColor = SystemColors.ControlText;      
                    btn[i, j].FlatAppearance.BorderSize = 1;       
                    btn[i, j].FlatAppearance.BorderColor = Color.FromName("DarkGreen");      
                    btn[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;     
                    btn[i, j].Tag = new Coords(i, j);
                    btn[i, j].Click += new System.EventHandler(this.Btn_Click);
                    this.Controls.Add(btn[i, j]);                 
                    x += 10;                                
                }
                y += 10;                                     
                x = 250;                                           
            }
            NewLife();                                         
            SoundPlayer sp = new SoundPlayer( "sound.wav");
            sp.PlayLooping();
        }
        private void Btn_Click(object sender, EventArgs e)             //активация клеток 
        {
            Button but = (Button)sender;
            Coords co = (Coords)but.Tag;
            if (((Button)sender).BackColor == Color.FromName("Black"))            
            {
                ((Button)sender).BackColor = Color.FromName("LawnGreen");                
                massBool[co.I, co.J] = true;
            }
            else if (((Button)sender).BackColor == Color.FromName("LawnGreen"))        
            {
                ((Button)sender).BackColor = Color.FromName("Black");
                massBool[co.I, co.J] = false;
            }
        }

        private void Start_Click(object sender, EventArgs e)            //запуск игры
        {
            Thread LifeThread = new Thread(GoLife);                 
            LifeThread.Start();                                     
        }
        private void Stop_Click(object sender, EventArgs e)             //пауза
        {
            if (pauseFlag == false)                                
            {
                Start.Enabled = false;
                Stop.Image = Properties.Resources.next;                
                pauseFlag = true;                               
            }
            else
            {
                Start.Enabled = true;
                Stop.Image = Properties.Resources.stop;
                pauseFlag = false;
            }
        }
        private void Clear_Click(object sender, EventArgs e)                //очистка поля
        {
            Start.Enabled = true; stopFlag = false; pauseFlag = false; NewLife();         
        }
        private void NewLife()                                              //начало новой игры
        {
            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < maxValue; j++)
                {
                    massBool[i, j] = false;                 
                    massBoolTemp[i, j] = false;
                    btn[i, j].BackColor = Color.Black;      
                }
            }
            generation = 0;                            
        }

        private void GoLife()                                               //жизненный цикл клеток
        {
            int i = 0;                              
           while (i<breakPointGeneration)           
            {
                if (pauseFlag != false) { continue; }       
                else
                {
                    Thread.Sleep(500);                  
                    NextGeneration();                                   
                    generation++;                       
                }
                if (stopFlag==true) { break; }          
                i++;                                    
            }
            if (stopFlag == true) { stopFlag = false; NewLife(); }              
        }

        public void NextGeneration()                                        //создание следующего поколения
        {
            this.SuspendLayout();

            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < maxValue; j++)              
                {
                    if ((SosediCount(i, j) == 3) && (!massBool[i, j])) { massBoolTemp[i, j] = true; }           
                    if (((SosediCount(i, j) == 3) || (SosediCount(i, j) == 2)) && (massBool[i, j])) { massBoolTemp[i, j] = true; }
                    if ((SosediCount(i, j) < 2) && (massBool[i, j])) { massBoolTemp[i, j] = false; }
                    if ((SosediCount(i, j) > 3) && (massBool[i, j])) { massBoolTemp[i, j] = false; }
                }
            }
            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < maxValue; j++)
                {
                    massBool[i, j] = massBoolTemp[i, j];            
                    if (massBool[i, j]) { btn[i, j].BackColor = Color.LawnGreen; alive++; } else { btn[i, j].BackColor = Color.Black; }    
                }
            }
            if (alive == 0) { stopFlag = true;}         
            alive = 0;                                  
            this.ResumeLayout();
        }
        private int SosediCount(int a, int b)               //нахождение количества соседей для клетки
        {
            int sosedi = 0;                             
            int limit = maxValue - 1;                       
            if (a > 0 && massBool[a - 1, b]) { sosedi++; }
            if (a > 0 && b < limit && massBool[a - 1, b + 1]) { sosedi++; }
            if (b < maxValue - 1 && massBool[a, b + 1]) { sosedi++; };
            if (a < limit && b < limit && massBool[a + 1, b + 1]) { sosedi++; }
            if (a < limit && massBool[a + 1, b]) { sosedi++; }
            if (a < limit && b > 0 && massBool[a + 1, b - 1]) { sosedi++; }
            if (b > 0 && massBool[a, b - 1]) { sosedi++; }
            if (a > 0 && b > 0 && massBool[a - 1, b - 1]) { sosedi++; }
            return sosedi;      
        }

        private string[] Convert_To_String(bool[ , ] data){         //подготовка данных для сохранения
             string[] mass= new string[maxValue*maxValue];          
            int g=0;                                                
            for(int i=0; i< maxValue; i++){                         
                for(int j=0; j< maxValue; j++){
                    if(data[i,j]==true)
                        mass[g] = "7CfC00";                         
                    if (data[i, j] == false)
                     mass[g] = "000000";                            
                    g++;
                }
            }
            return mass;                                             
        }
        private void Save_Click(object sender, EventArgs e)                 //сохранение
        {
            DialogResult dResult = DialogResult.Yes;                
            Mesage.ShowDialog();                                    
            this.Show();                                         
            if(dResult==DialogResult.Yes){                          
                string filename = Message.filename;                 
                microbs microb= new microbs(name);                  
                string[] mass=Convert_To_String(massBool);           
                microb.CreateTXT(mass,filename);                    
                Bitmap bmp=CopyDataToBitmap(mass);                 
                microb.CreateJPG(bmp,filename);                     
            }
            if (dResult == DialogResult.No)                 
            {
                this.Close();                       
            }
        }
           public Bitmap CopyDataToBitmap(string[] data)                //сохранение в картинку
        {
            Bitmap bmp = new Bitmap(40, 40);                        
            byte R, G, B;                                           
            int g = 0;                                              
             Color[,] color = new Color[bmp.Width, bmp.Height];         
            for ( int i = 0 ; i <40 ; i++)
             {

             for ( int j = 0 ; j < 40 ; j++)
             {
                R = byte.Parse ( data [g] . Substring ( 0 , 2 ) ,
                        System.Globalization.NumberStyles.HexNumber );      
                G = byte.Parse ( data [g] . Substring ( 2 , 2 ) ,
                       System.Globalization.NumberStyles.HexNumber);        
                B = byte.Parse(data[g].Substring(4, 2),
                       System.Globalization.NumberStyles.HexNumber);         
                 bmp.SetPixel ( j , i , Color.FromArgb ( R , G , B )) ;        
                 g++;
                 }
             }
            return bmp;             
        }

           private void MyLab_Click(object sender, EventArgs e)                     //переход в личный кабинет
           {
               Form2 lab = new Form2();                 
               this.Hide();                             
               lab.ShowDialog();                        
               if(Form2.flag==false)                    
               this.Show();
           }
           private void Form1_FormClosed(object sender, FormClosedEventArgs e)      //принудительное завершение программы
           {
               stopFlag = true;
               Application.Exit();          
           }

       }

    }

    public class Coords                 //координаты нажатой кнопки
    {
        private int i;                  //х
        private int j;                  //у
        public int I           
        {
            get { return i; }
            set { i = I; }
        }
        public int J                
        {
            get { return j; }
            set { j = J; }
        }
        public Coords(int a, int b)     
        {
            i = a; j = b;
        }

    }
