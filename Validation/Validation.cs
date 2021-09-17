using System;
using System.Windows.Forms;

namespace Contactmanager
{
    class Validation
    {
        /**************************************************
         * Konstruktor ist privat, weil diese Klasse nur
         * statische Methoden zur Verfügung stellt.
         * ***********************************************/
        private Validation() { }

        /**************************************************
         * Eingabe wird überprüft, ob es ausschliesslich 
         * Buchstaben beinhaltet.
         * ***********************************************/
        public static bool IsText(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /**************************************************
         * Eingabe wird überprüft, ob es ausschlisslich 
         * Zahlen beinhaltet.
         * ***********************************************/
        public static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c) || c == '.')
                {
                    return false;
                }
            }
            return true;
        }

        /***************************************************
         * Eingabe wird überprüft, ob die E-Mail Adresse 
         * grundsätzlich eine gültige Schreibweise erfüllt.
         * ************************************************/
        public static bool IsEmail(string input)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(input);
                return mail.Address == input;
            }
            catch(FormatException)
            {
                return false;
            }
        }

        /*************************************************************************
         * Die Eingabe wird auf Zahlen überpfügt.
         * **********************************************************************/
        public static bool CheckNumber(TextBox text)
        {
            if (!IsNumeric(text.Text))
            {
                MessageBox.Show("Bitte verwende für das Feld " + (text.Name.Substring(3)) + " nur Zahlen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text.Text = string.Empty;
                return false;
            }
            return true;
        }

        /*************************************************************************
         * Die Eingabe wird auf Buchstaben überpfrüft.
         * **********************************************************************/
        public static bool CheckText(TextBox text)
        {
            if (!IsText(text.Text))
            {
                MessageBox.Show("Bitte verwende für das Feld " + (text.Name.Substring(3)) + " nur Buchstaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text.Text = string.Empty;
                return false;
            }
            return true;
        }

        /*************************************************************************
         * Die Eingabe wird auf eine valide Mail-Adresse überpfrüft.
         * **********************************************************************/
        public static bool CheckMail(TextBox text)
        {
            if (!IsEmail(text.Text))
            {
                MessageBox.Show("Bitte verwende eine gültige E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text.Text = string.Empty;
                return false;
            }
            return true;
        }

        /*************************************************************************
         * Die Eingabe wird auf ein valides Geburtsdatum überpfrüft.
         * **********************************************************************/
        public static bool CheckDate(TextBox text)
        {
            try
            {
                DateTime.Parse(text.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte verwende für das Feld " + text.Name.Substring(3) + " eine gültiges Datum-Format.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text.Text = string.Empty;
                return false;
            }
            return true;
        }
    }
}
