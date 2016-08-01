using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonVerbalComm
{
    public partial class PopupWindow : Form
    {
        public PopupWindow()
        {
            InitializeComponent();
        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string EnteredText
        {
            get
            {
                return (emailTextBox.Text);
            }
        }
    }
}
