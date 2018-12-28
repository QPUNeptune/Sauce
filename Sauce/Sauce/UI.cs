using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sauce
{

    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        private void InitializeMyControl()
        {
            // Put some text into the control first.  
            textBox2.Text = "This is a TextBox control.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox2.Text;
            MessageBox.Show(var);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string var;
            var = textBox2.Text;
  
                System.Diagnostics.Process.Start("https://nhentai.net/g/" + var);
            
            
            
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}
