using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class View : Form
    {
        private Controller controller;

        private string[] messages = {
            "Vorname zu kurz!",
            "Nachname zu kurz!",
            "Geschlecht nicht gewählt!",
            "Person schon vorhanden!",
            "Selektierte Person konnte nicht gelöscht werden!",
            "Keine Person in Liste ausgewählt!",
            "Keine Elemente mehr in Liste!",
            "Mutation der Person ist fehlgeschlagen."
        };
        public View(Controller c)
        {
            controller = c;
            InitializeComponent();
            UpdateList();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                string firstname = TxtFirstname.Text;
                string lastname = TxtLastname.Text;
                int age = Convert.ToInt16(NumAge.Value);
                bool sex = RadMale.Checked ? false : true;
                string comment = TxtComment.Text;

                Person p = new Person(firstname, lastname, age, sex);
                p.Comment = comment;
                bool status = controller.SaveNewPerson(p);
                if (status == true)
                {
                    ClearInputFields();
                    UpdateList();
                }
                else
                    ShowMessage(3);
            }
        }

        private void UpdateList()
        {
            LstData.Items.Clear();
            try
            {
                LstData.Items.AddRange(controller.GetAllPeople());
            }
            catch (ArgumentException)
            {
                ShowMessage(6);
            }

        }

        private bool InputValidation()
        {
            if (TxtFirstname.Text.Length <= 2)
            {
                ShowMessage(0);
                return false;
            }

            if (TxtLastname.Text.Length <= 2)
            {
                ShowMessage(1);
                return false;
            }

            if (!RadMale.Checked && !RadFemale.Checked)
            {
                ShowMessage(2);
                return false;
            }
            return true;
        }

        private void ClearInputFields()
        {
            TxtFirstname.Clear();
            TxtLastname.Clear();
            NumAge.Value = 1;
            TxtComment.Clear();
            RadFemale.Checked = false;
            RadMale.Checked = false;
        }

        private void ShowMessage(int status)
        {
            MessageBox.Show(messages[status]);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (LstData.SelectedIndex != -1)
            {
                Person p = (Person)LstData.SelectedItem;
                bool status = controller.DeletePerson(p);
                if (status == true)
                {
                    UpdateList();
                }
                else
                    ShowMessage(4);
            }
            else
                ShowMessage(5);
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            if (LstData.SelectedIndex != -1)
            {
                Person p = (Person)LstData.SelectedItem;
                Person foundPerson = controller.GetPerson(p);
                ShowPersonInForm(foundPerson);
                ToggleButtonAndListWhenUpdate();
                controller.PersonToBeUpdated(p);
            }
            else
                ShowMessage(5);
        }

        private void ToggleButtonAndListWhenUpdate()
        {
            if (CmdSave.Visible == true)
            {
                CmdSave.Visible = false;
                CmdUpdate.Enabled = false;
                CmdDelete.Enabled = false;
                CmdUpdateSave.Visible = true;

                LstData.Enabled = false;
            }
            else
            {
                CmdSave.Visible = true;
                CmdUpdate.Enabled = true;
                CmdDelete.Enabled = true;
                CmdUpdateSave.Visible = false;

                LstData.Enabled = true;
            }
        }

        private void ShowPersonInForm(Person p)
        {
            TxtFirstname.Text = p.Firstname;
            TxtLastname.Text = p.Lastname;
            TxtComment.Text = p.Comment;
            NumAge.Value = p.Age;
            if (p.Sex == true)
                RadFemale.Checked = true;
            else
                RadMale.Checked = true;
        }

        private void CmdUpdateSave_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                string firstname = TxtFirstname.Text;
                string lastname = TxtLastname.Text;
                int age = Convert.ToInt16(NumAge.Value);
                bool sex = RadMale.Checked ? false : true;
                string comment = TxtComment.Text;

                Person p = new Person(firstname, lastname, age, sex);
                p.Comment = comment;
                bool status = controller.UpdatePerson(p);
                if (status == true)
                {
                    ClearInputFields();
                    UpdateList();
                    ToggleButtonAndListWhenUpdate();
                }
                else
                    ShowMessage(3);
            }
        }
    }
}
