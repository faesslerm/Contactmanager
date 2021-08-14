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

        private void updateGrid(List<Person> data)
        {
            searchResult = data;
            GridSearchResults.DataSource = data;
            GridSearchResults.Update();
        }

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Controller);
            employeeForm.ShowDialog();
            updateGrid(Controller.GetAllPeople().ToList());
        }

        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(Controller);
            customerForm.ShowDialog();
            updateGrid(Controller.GetAllPeople().ToList());
        }

        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            LblSearch.Visible = textBox.Text.Length == 0;

            List<Person> filterData = Controller
                .GetAllPeople()
                .Select(p => new { person = p, searchText = $"{p.Firstname} {p.Lastname} {(p.IsMen ? "männlich" : "weiblich")}".ToLower() })
                .Where(p => p.searchText.Contains(textBox.Text.ToLower()))
                .Select(p => p.person)
                .ToList();
            updateGrid(filterData);
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
            updateGrid(Controller.GetAllPeople().ToList());
            Console.WriteLine("All done!");
        }

        private void CmdEditSelected_Click(object sender, EventArgs e)
        {
            Person person = searchResult[GridSearchResults.SelectedRows[0].Index];
            Controller.PersonToBeUpdated(person);
            if (person is Employee)
            {
                new EmployeeForm(Controller, person as Employee).ShowDialog();
            }
            else if (person is Customer)
            {
                new CustomerForm(Controller, person as Customer).ShowDialog();
            }
            else
            {
                new EmployeeForm(Controller, person).ShowDialog();
            }
            updateGrid(Controller.GetAllPeople().ToList());
        }
    }
}
