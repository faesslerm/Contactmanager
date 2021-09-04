using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class MainForm : Form
    {
        /*************************************************************************
         * Die ersten 3 Personen werden in der Liste ausgegeben und abgespeichert
         * **********************************************************************/
        public MainForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            Controller.SaveNewPerson(new Person("Markus", "Fässler", true, false, new Address("Bucheggstrasse", 3, 9008, "St.Gallen", "Schweiz"), "756.1234.1234.12"));
            Controller.SaveNewPerson(new Person("Fiona", "Schmidiger", false, false, new Address("Gopfweg", 3, 9052, "Niederteufen", "Schweiz"), "756.1234.1234.12"));
            Controller.SaveNewPerson(new Person("Anina", "Heinze", false, false, new Address("Landsgemeindestrasse", 7, 9200, "Gossau", "Schweiz"), "756.1234.1234.12"));
            UpdateGrid(Controller.GetAllPeople().ToList());
        }

        public Controller Controller { get; }
        /*************************************************************************
         * Alle Personen werden für die Sucher aus der List Person geholt 
         * **********************************************************************/
        private List<Person> searchResult = new List<Person>();

        /*************************************************************************
         * 
         * **********************************************************************/
        private void UpdateGrid(List<Person> data)
        {
            searchResult = data;
            GridSearchResults.Rows.Clear();
            foreach (Person person in data)
            {
                GridSearchResults.Rows.Add(person.GetGridRow());
            }
            GridSearchResults.Update();
        }

        /*************************************************************************
         * Über einen Click auf den Button, kann ein neuer Mitarbeiter angelegt
         * werden. Der Text auf der Form ändert sich und die EmployeeForm wird
         * geöffnet. Dann wird dem Grid eine neue Position hinzugefügt.
         * **********************************************************************/
        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Controller);
            employeeForm.LblTitleEmployee.Text = "Mitarbeiter erfassen";
            employeeForm.ShowDialog();
            UpdateGrid(Controller.GetAllPeople().ToList());
            employeeForm.LblTitleEmployee.Text = "Mitarbeiter erfassen";
        }

        /*************************************************************************
         * Über einen Click auf diesen Button, kann ein neuer Kunde angelegt
         * werden. Der Text auf der Form ändert sich und die CustomerForm wird
         * geöffnet. Dann wird dem Grid eine neue Position hinzugefügt.
         * **********************************************************************/
        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(Controller);
            customerForm.LblTitleCustomer.Text = "Kunde erfassen";
            customerForm.ShowDialog();
            UpdateGrid(Controller.GetAllPeople().ToList());
            customerForm.LblTitleCustomer.Text = "Kunde erfassen";
        }

        /*************************************************************************
         * Wenn sich in der SearchBar der Text ändert, wird über alle Personen 
         * über den Vorname, Nachname und das Geschlecht gesucht.
         * **********************************************************************/
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

        /*************************************************************************
         * Wenn eine Person im Grid ausgewählt und danach auf das Delete
         * Icon geklickt wird, wird der Controller aufgerufen und die Person 
         * gelöscht. Das Grid wird geupdatet und in der Console erscheint eine
         * Mitteilung mit "All done!".
         * **********************************************************************/
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

        /*************************************************************************
         * Wenn eine Person im Grid augewählt und danach auf das Edit Icon 
         * geklickt wird, wird der Controller aufgerufen und mitgeteilt, dass
         * diese Person mit dem entsprechenden Index bearbeitet wird. Es wird
         * zudem überprüft, ob diese Person Employee oder Customer ist, damit die
         * entsprechende Form aufgerufen werden kann.
         * **********************************************************************/
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

        /*************************************************************************
         * Hier wird definiert, dass wenn im Grid eine Zeile augewählt ist, die
         * "Edit-Icons" ersichtlich werden.
         * **********************************************************************/
        private void GridSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ImgHistory.Visible = true;
            ImgEdit.Visible = true;
            ImgDelete.Visible = true;
        }

        /*************************************************************************
         * Wenn eine Person im Grid ausgewählt und danach auf das History Icon
         * geklickt wird, wird die entsprechende HistoryForm aufgerufen.
         * **********************************************************************/
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
