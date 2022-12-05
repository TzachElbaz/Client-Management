using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_management
{
    public partial class ClientUI : Form
    {
        IClient ClientActions = new ClientEditor();
        List<Client> allClients = new List<Client>();
        string selectedClient;
        string oldValue;
        public ClientUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allClients = ClientActions.getAllClients();
            clientDataGrid.DataSource = allClients;
        }

        // Add new Client
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (fNameTxt.Text == "" || lNameTxt.Text == "" || phoneTxt.Text == "" || emailTxt.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            Client newClient = new Client();
            newClient.firstName = fNameTxt.Text;
            newClient.lastName = lNameTxt.Text;
            newClient.phoneNumber = phoneTxt.Text;
            newClient.emailAddress = emailTxt.Text;
            try
            {
                ClientActions.addClient(newClient);
                refreshPage();
                fNameTxt.Text = "";
                lNameTxt.Text = "";
                phoneTxt.Text = "";
                emailTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Start editing data.
        private void clientDataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Holds the selected client's phone number
            selectedClient = clientDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            //Holds the selected cell's current value
            oldValue = clientDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        //Editing ended, Update data.
        private void clientDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (clientDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                MessageBox.Show("The new value cannot remain empty");
                clientDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;
                return;
            }
            string newValue = clientDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            try
            {
                ClientActions.updateData(selectedClient, e.ColumnIndex, newValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clientDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;

            }
        }

        //Delete client
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (clientDataGrid.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this client?", "Remove Client", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int rowIndex = clientDataGrid.CurrentRow.Index;
                    selectedClient = clientDataGrid.Rows[rowIndex].Cells[2].Value.ToString();
                    ClientActions.deleteClient(selectedClient);
                    refreshPage();
                }
            }
            else
            {
                MessageBox.Show("You must select one row");
            }
        }

        //Read updated data from xml
        private void refreshPage()
        {
            allClients = ClientActions.getAllClients();
            clientDataGrid.DataSource = allClients;
        }
    }
}
