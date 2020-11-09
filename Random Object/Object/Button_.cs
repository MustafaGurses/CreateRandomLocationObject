using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Random_Game.Object
{
    public class Button_
    {
        public int Windows_Height { get; set; }
        public int Windows_Width { get; set; }
        private static string object_name { get; set; }
        public Button create_button(System.Drawing.Point location)
        {
            Button create_ = new Button();
            create_.Name = "test_" + DateTime.Now.Second;
            create_.Location = location;
            create_.Click += Create__Click;
            create_.Size = new System.Drawing.Size(100, 100);
            create_.Text = "Click me";
            object_name = create_.Name;
            return create_;
        }

        private void Create__Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Controls.Find(object_name, true)[0].Dispose();
            Windows_Height = Application.OpenForms["Form1"].Size.Height;
            Windows_Width = Application.OpenForms["Form1"].Size.Width;
            Application.OpenForms["Form1"].Controls.Add(create_button(create_object_location(Windows_Height,Windows_Width)));
        }
        private System.Drawing.Point create_object_location(int windows_height,int windows_width)
        {
            System.Drawing.Point point = new System.Drawing.Point();
            Random random = new Random();
            point.Y = random.Next(0, windows_height-150);
            point.X = random.Next(0, windows_width-150);
            return point;
        }
    }
}
