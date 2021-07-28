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
    public partial class MainForm : Form
    {
        public MainForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            GridSearchResults.DataSource = Controller.GetAllPeople();
            //searchResult = Controller.GetAllPeople().ToList(); // What is this for?
            controller.SaveNewPerson(new Person("Max", "Muster", true, false));
            controller.SaveNewPerson(new Person("Anna", "Ibadette", false, false));
        }

        public Controller Controller { get; }

        private List<Person> searchResult = new List<Person>();
        private Person delete;

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            // var form = new EmployeeForm(Controller, null);
            // form.Show();
        }

        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            searchResult = Controller
                .GetAllPeople()
                .Select(p => new { person = p, searchText = $"{p.Firstname} {p.Lastname} {(p.IsMen ? "männlich" : "weiblich")}".ToLowerInvariant() })
                .Where(p => p.searchText.Contains(textBox.Text))
                .Select(p => p.person)
                .ToList();
            GridSearchResults.DataSource = searchResult;
        }

        private void CmdOpenSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridSearchResults.SelectedRows)
            {
                var person = searchResult[row.Index];

                // var form = new EmployeeForm(Controller, person);
                // form.Show();
            }
        }

        private void CmdDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridSearchResults.SelectedRows)
            {
                Person person = searchResult[row.Index];
                Controller.DeletePerson(person);
            }

        }

    }
}
