using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeGenerator
{
    public partial class Form1 : Form
    {
        private morse_code_translator translator;
        public Form1()
        {
            InitializeComponent();
            translator = new morse_code_translator();
        }

        private void translate_button_Click(object sender, EventArgs e)
        {
            translated_text.Text = Convert.ToString(translator.translate(to_translate.Text));
        }

        private void sound_button_Click(object sender, EventArgs e)
        {
            Graphics grafika = this.CreateGraphics();
            Pen white_pen = new Pen(Color.White, 20);
            Pen black = new Pen(Color.Black, 20);
            if (translated_text.Text != String.Empty)
            {
                foreach (char sign in translated_text.Text)
                {
                    grafika.DrawEllipse(white_pen, 500, 430, 20, 20);
                    System.Threading.Thread.Sleep(100);
                    if (sign == '-')
                    {
                        grafika.DrawEllipse(black, 500, 430, 20, 20);
                        Console.Beep(750, 600);
                    }
                    System.Threading.Thread.Sleep(100);
                    grafika.DrawEllipse(white_pen, 500, 430, 20, 20);
                    if (sign == '.')
                    {
                        grafika.DrawEllipse(black, 500, 430, 20, 20);
                        Console.Beep(750, 200);
                    }
                    System.Threading.Thread.Sleep(100);
                    grafika.DrawEllipse(white_pen, 500, 430, 20, 20);
                }
            }
        }
    }
}
