///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using Assignment.ListManager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment {

    /// <summary>
    /// A form that can be used to add either food or staff. Since both food and staff are very similar,
    /// this form handles both of them in a similar manner.
    /// </summary>
    public partial class StaffOrFoodForm : Form {

        public Result result;


        /// <summary>
        /// This class is used to store the result of the form/dialog. Since the result has more than one
        /// variable, we need a class that can represent a complete result in a single object.
        /// </summary>
        public class Result {
            public string name;
            public List<string> stringList = new List<string>();
        }





        /// <summary>
        /// Constructor which takes arguments for the UI components that can vary between differenct implementations.
        /// </summary>
        public StaffOrFoodForm(string title, string groupCaption, string aAddToListboxLabel) {
            InitializeComponent();

            result = new Result();

            Text = title;
            listboxGroup.Text = groupCaption;
            addToListboxLabel.Text = aAddToListboxLabel; 
        }


        /// <summary>
        /// Add a new string to the listbox
        /// </summary>
        private void addButton_Click(object sender, EventArgs e) {
            if (addToListTextbox.Text.Length > 0) {
                listbox.Items.Add(addToListTextbox.Text);
                addToListTextbox.Clear();
            }
        }

        /// <summary>
        /// Changes the currently selected item in the listbox.
        /// </summary>
        private void changeButton_Click(object sender, EventArgs e) {
            if (listbox.SelectedIndex >= 0)
                listbox.Items[listbox.SelectedIndex] = addToListTextbox.Text;
            addToListTextbox.Clear();
        }


        /// <summary>
        /// Update the text in the input field when the user clicks on a list item.
        /// </summary>
        private void ingredientsListbox_SelectedIndexChanged(object sender, EventArgs e) {
            if (listbox.SelectedIndex >= 0)
                addToListTextbox.Text = listbox.Text;
            else
                addToListTextbox.Text = "";
        }


        /// <summary>
        /// Store the information from the form in the result member if there is any information entered.
        /// Otherwise just close the form.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e) {
            if (nameTextbox.Text.Length > 0 && listbox.Items.Count > 0) {
                DialogResult = DialogResult.OK;
                result.name = nameTextbox.Text;
               
                foreach (string s in listbox.Items)
                    result.stringList.Add(s);
            }
            else
                DialogResult = DialogResult.Cancel;

            Close();
        }


        /// <summary>
        /// Delete the currently selected item in the list.
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e) {
            if( listbox.SelectedIndex >= 0 )
            listbox.Items.RemoveAt(listbox.SelectedIndex);
        }
    }
}
