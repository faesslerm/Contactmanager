using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class HistoryForm : Form
    {
        /*************************************************************************
         * 
         * **********************************************************************/
        public HistoryForm(List<History> histories)
        {
            InitializeComponent();
            List<History> sortedHistory = new List<History>(histories);
            sortedHistory.Reverse();
            foreach(History history in sortedHistory)
            {
                TxtHistory.Text += history.ToString();
                TxtHistory.Text += "\r\n";
            }
        }
    }
}
