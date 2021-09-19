using System.Collections.Generic;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class HistoryForm : Form
    {
        /*************************************************************************
         * Hier wird eine Liste der History übergeben und danach in der TextBox
         * mit Hilfe der ToString-Methode ausgegeben.
         * **********************************************************************/
        public HistoryForm(List<History> histories)
        {
            InitializeComponent();
            List<History> sortedHistory = new List<History>(histories);
            sortedHistory.Reverse();
            foreach (History history in sortedHistory)
            {
                TxtHistory.Text += history.ToString();
                TxtHistory.Text += "\r\n";
            }
        }
    }
}
