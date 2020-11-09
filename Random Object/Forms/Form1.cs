using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_ = new Object.Button_();
        }
        Object.Button_ button_;
        private void Form1_Load(object sender, EventArgs e)
        {
            button_.Windows_Height = this.Height;
            button_.Windows_Width = this.Width;
            this.Controls.Add(button_.create_button(new Point(0,0)));
        }
    }
}
