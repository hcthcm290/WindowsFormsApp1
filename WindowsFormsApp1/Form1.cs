using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d;
            int startH, startM;
            int endH, endM;
            int widthT, heightT;
            int offset = 5;
            
            d = (int)day.Value;
            
            startH = (int)startHour.Value;
            startM = (int)startMinute.Value;
            
            endH = (int)endHour.Value;
            endM = (int)endMinute.Value;
            
            widthT = table.Width / table.ColumnCount;
            heightT = table.Height / table.RowCount;
            
            Point position = new Point();
            position.X = d * widthT + offset + table.Location.X;
            position.Y = (int)(heightT * (startH + (float)startM / 60)) + table.Location.Y;

            int positionEnd_Y;
            positionEnd_Y = (int)(heightT * (endH + (float)endM / 60)) + table.Location.Y;

            Panel h = new Panel();
            h.BackColor = Color.FromArgb(100, 255, 0, 0);
            h.Location = position;
            h.Width = widthT - 2 * offset;
            h.Height = positionEnd_Y - position.Y;
            h.Location = position;
            h.Name = "thanh";
            

            
            this.Controls.Add(h);

            h.BringToFront();
            

            //add();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
