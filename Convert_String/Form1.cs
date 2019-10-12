using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convert_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            try
            {
              string s = "";
              int num = int.Parse(textBox1.Text);
              int temp = num;            // частное от деления

              int position = 0;         // позиция в строке
              int []x =new int[4];      // массив разрядов
              int div = 1000;           // делитель на разряды
             
              int rest;                 // остаток от деления
              for (int i = 0; i < 4; i++)
              {
                rest = temp / div;
                x[i] = rest;
                temp = temp - rest * div;
                div = div / 10;
              }
              // Тысячи
              switch (x[0])
              {
                  case 1: s = "Одна тысяча "; break;
                  case 2: s = "Две тысячи "; break;
                  case 3: s = "Три тысячи "; break;
                  case 4: s = "Четыре тысячи "; break;
                  case 5: s = "Пять тысяч "; break;
                  case 6: s = "Шесть тысяч "; break;
                  case 7: s = "Семь тысяч "; break;
                  case 8: s = "Восемь тысяч "; break;
                  case 9: s = "Девять тысяч "; break;
                  default: break;
              }
              position = s.Length;

              // Сотни
              switch (x[1])
              {
                  case 1: s +=  "сто "; break;
                  case 2: s +=  "двести "; break;
                  case 3: s +=  "триста "; break;
                  case 4: s +=  "четыреста "; break;
                  case 5: s +=  "пятьсот "; break;
                  case 6: s +=  "шестьсот "; break;
                  case 7: s +=  "семьсот "; break;
                  case 8: s +=  "восемьсот "; break;
                  case 9: s +=  "девятьсот "; break;
                  default: break;
              }
              position = s.Length;
              
              // Десятки
              switch (x[2])
              {
                  case 1:
                      // Числа от 10 до 19
                      switch (x[3])
                      {
                          case 0: s +=  "десять "; break;
                          case 1: s +=  "одиннадцать "; break;
                          case 2: s +=  "двенадцать "; break;
                          case 3: s +=  "тринадцать "; break;
                          case 4: s +=  "четырнадцать "; break;
                          case 5: s +=  "пятнадцать "; break;
                          case 6: s +=  "шестнадцать "; break;
                          case 7: s +=  "семнадцать "; break;
                          case 8: s +=  "восемнадцать "; break;
                          case 9: s +=  "девятнадцать "; break;
                      }
                      x[3] = 0;  position = s.Length;     break;
                  case 2: s +=  "двадцать "; break;
                  case 3: s +=  "тридцать "; break;
                  case 4: s +=  "сорок ";    break;
                  case 5: s +=  "пятьдесят "; break;
                  case 6: s +=  "шестьдесят "; break;
                  case 7: s +=  "семьдесят ";  break;
                  case 8: s +=  "восемьдесят "; break;
                  case 9: s +=  "девяносто ";   break;
                  default: break;
              }
              position = s.Length;
              // Единицы
              switch (x[3])
              {
                  case 1: s +=  "один "; break;
                  case 2: s +=  "два "; break;
                  case 3: s +=  "три "; break;
                  case 4: s +=  "четыре "; break;
                  case 5: s +=  "пять "; break;
                  case 6: s +=  "шесть "; break;
                  case 7: s +=  "семь "; break;
                  case 8: s +=  "восемь "; break;
                  case 9: s +=  "девять "; break;
                  default: break;
              }
              position = s.Length;
              label1.Text = s;

            }
            catch { }
        }
    }
}
