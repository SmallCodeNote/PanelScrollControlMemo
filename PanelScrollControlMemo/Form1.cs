using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PanelScroll;

namespace PanelScrollControlMemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PanelScrollControl panelScroll;
        private void Form1_Load(object sender, EventArgs e)
        {
            panelScroll = new PanelScrollControl(panel_Frame,panel_Contents,vScrollBar1,hScrollBar1,label_vValue,label_hValue);

            panel_Contents.Width = 1000;
            panel_Contents.Height = 1000;

        }
    }
}
