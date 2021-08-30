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
            Controller.SaveNewPerson(new Person("Max", "Muster", true, false, new Address("Musterstrasse", 1, 9000, "St.Gallen", "Schweiz")));
            Controller.SaveNewPerson(new Person("Anna", "Ibadette", false, false, new Address("Gopfweg", 3, 9052, "Niederteufen", "Schweiz")));
            UpdateGrid(Controller.GetAllPeople().ToList());
        }

        public Controller Controller { get; }

        private List<Person> searchResult = new List<Person>();

        private void UpdateGrid(List<Person> data)
        {
            searchResult = data;
            GridSearchResults.Rows.Clear();
            foreach (Person person in data)
            {
                GridSearchResults.Rows.Add(person.getGridRow());
            }
            GridSearchResults.Update();
        }

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Controller);
            employeeForm.LblTitleEmployee.Text = "Mitarbeiter erfassen";
            employeeForm.ShowDialog();
            UpdateGrid(Controller.GetAllPeople().ToList());
            employeeForm.LblTitleEmployee.Text = "Mitarbeiter erfassen";
        }

        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(Controller);
            customerForm.LblTitleCustomer.Text = "Kunde erfassen";
            customerForm.ShowDialog();
            UpdateGrid(Controller.GetAllPeople().ToList());
            customerForm.LblTitleCustomer.Text = "Kunde erfassen";
        }

        /*************************************
         * Das ist ein Kommentar
         * **********************************/
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
            UpdateGrid(filterData);
        }

        /*************************************
         * Das ist ein Kommentar
         * **********************************/
        private void CmdDeleteSelected_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Selected rows: " + GridSearchResults.SelectedRows.Count);
            foreach (DataGridViewRow row in GridSearchResults.SelectedRows)
            {
                Person person = searchResult[row.Index];
                Controller.DeletePerson(person);
                Console.WriteLine("Delete Person: " + person);
            }
            UpdateGrid(Controller.GetAllPeople().ToList());
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
                EmployeeForm employeeForm = new EmployeeForm(Controller, person);
                employeeForm.LblTitleEmployee.Text = "Mitarbeiter bearbeiten";
                employeeForm.ShowDialog();
            }
            UpdateGrid(Controller.GetAllPeople().ToList());
        }

        private void GridSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ImgHistory.Visible = true;
            ImgEdit.Visible = true;
            ImgDelete.Visible = true;
        }

        private void CmdHistorySelected_Click(object sender, EventArgs e)
        {
            Person person = searchResult[GridSearchResults.SelectedRows[0].Index];
            if (person.Histories != null && person.Histories.Count > 0)
            {
                HistoryForm historyForm = new HistoryForm(person.Histories);
                historyForm.ShowDialog();
            }
        }
    }
}
