using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class MainForm : Form
    {
        public MainForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            controller.SaveNewPerson(new Person("Max", "Muster", true, false));
            controller.SaveNewPerson(new Person("Anna", "Ibadette", false, false));
            GridSearchResults.DataSource = Controller.GetAllPeople();
            searchResult = Controller.GetAllPeople().ToList();
        }

        public Controller Controller { get; }

        private List<Person> searchResult = new List<Person>();
        private Person delete;

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Controller);
            employeeForm.ShowDialog();
            searchResult = Controller.GetAllPeople().ToList();
            GridSearchResults.DataSource = searchResult;
            GridSearchResults.Update();
        }

        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            LblSearch.Visible = textBox.Text.Length == 0;

            searchResult = Controller
                .GetAllPeople()
                .Select(p => new { person = p, searchText = $"{p.Firstname} {p.Lastname} {(p.IsMen ? "männlich" : "weiblich")}".ToLower() })
                .Where(p => p.searchText.Contains(textBox.Text.ToLower()))
                .Select(p => p.person)
                .ToList();
            GridSearchResults.DataSource = searchResult;
            GridSearchResults.Update();
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
            Console.WriteLine("Selected rows: " + GridSearchResults.SelectedRows.Count);
            foreach (DataGridViewRow row in GridSearchResults.SelectedRows)
            {
                Person person = searchResult[row.Index];
                Controller.DeletePerson(person);
                Console.WriteLine("Delete Person: " + person);
            }
            searchResult = Controller.GetAllPeople().ToList();
            GridSearchResults.DataSource = searchResult;
            GridSearchResults.Refresh();
            Console.WriteLine("All done!");
        }
    }
}
