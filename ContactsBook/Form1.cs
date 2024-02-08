using System.Data;

namespace ContactsBook
{
    public partial class PhoneBook : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;   

        public PhoneBook()
        {
            InitializeComponent();
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name"); 
            contacts.Columns.Add("Email");
            contacts.Columns.Add("Phone Number");

            PhoneBookDataGrid.DataSource = contacts;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            LastNameTextBox.Text = contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            EmailTextBox.Text = contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            PhoneNumberTextBox.Text = contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editing) 
            {
                contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex]["First Name"] = FirstNameTextBox.Text;
                contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex]["Last Name"] = LastNameTextBox.Text;
                contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex]["Email"] = EmailTextBox.Text;
                contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex]["Phone Number"] = PhoneNumberTextBox.Text;
            }
            else
            {
                contacts.Rows.Add(FirstNameTextBox.Text,LastNameTextBox.Text,EmailTextBox.Text,PhoneNumberTextBox.Text);
            }
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            editing = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[PhoneBookDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Not Valid RoW");
            }
            
        }

        private void PhoneBookDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}