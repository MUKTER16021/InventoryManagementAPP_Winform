using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementApp.Manager;
using InventoryManagementApp.Model;

namespace InventoryManagementApp
{
    public partial class userTypeForm : Form
    {
        public userTypeForm()
        {
            InitializeComponent();
        }

        UserTypesManager userTypesManager = new UserTypesManager();

        private void userTypeForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxValue();

            LoadAllTypesListView();
        }

        private void LoadComboBoxValue()
        {
            Dictionary<string, string> comboDictionary = new Dictionary<string, string>();
            comboDictionary.Add("1", "Active");
            comboDictionary.Add("2", "Inactive");
            statusComboBox.DataSource = new BindingSource(comboDictionary, null);
            statusComboBox.DisplayMember = "Value";
            statusComboBox.ValueMember = "Key";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addButton.Text == "ADD")
            {
                UserTypes userTypes = GetValueFromTextBoxAndComboBox();
                string message = userTypesManager.AddUserTypes(userTypes);
                MessageBox.Show(message);
            }
            else
            {
                UserTypes userTypes = GetValueFromTextBoxAndComboBox();
                userTypes.Id =Convert.ToInt32(showIdLabel.Text);
                string message = userTypesManager.UpdateUserType(userTypes);
                MessageBox.Show(message);
                addButton.Text = "ADD";
                removeButton.Visible = false;
            }
            LoadAllTypesListView();
            LoadComboBoxValue();
            userTypeTextBox.Clear();

        }

        private UserTypes GetValueFromTextBoxAndComboBox()
        {
            UserTypes userTypes = new UserTypes();
            userTypes.UserType = userTypeTextBox.Text;
            userTypes.Status = ((KeyValuePair<string, string>) statusComboBox.SelectedItem).Value;
            return userTypes;
        }

        private void LoadAllTypesListView()
        {
            showUserTypeListView.Items.Clear();
            List<UserTypes> userTypes = userTypesManager.GetAllUserTypeses();

            foreach (UserTypes types in userTypes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = types.UserType;
                item.SubItems.Add(types.Status);
                item.Tag = types;

                showUserTypeListView.Items.Add(item);
            }
        }

        private void showUserTypeListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectecdItem = showUserTypeListView.SelectedItems[0];
            UserTypes types = selectecdItem.Tag as UserTypes;
            userTypeTextBox.Text = types.UserType;
            showIdLabel.Text = types.Id.ToString();
            Dictionary<string, string> comboDictionary = new Dictionary<string, string>();
            comboDictionary.Add("1", types.Status);
            if (types.Status == "Active")
            {
                comboDictionary.Add("2", "Inactive");
            }
            if (types.Status == "Inactive")
            {
                comboDictionary.Add("2", "Active");
            }
            
            statusComboBox.DataSource = new BindingSource(comboDictionary, null);
            statusComboBox.DisplayMember = "Value";
            statusComboBox.ValueMember = "Key";

            addButton.Text = "Update";
            removeButton.Visible = true;
                    }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(showIdLabel.Text);
            DialogResult result = MessageBox.Show("Are you sure delete this person", "Delete Person",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = userTypesManager.DeleteTypes(id);
                MessageBox.Show(message);
                LoadAllTypesListView();
                addButton.Text = "ADD";
                removeButton.Visible = false;
                userTypeTextBox.Clear();

            }
        }
    }
}
