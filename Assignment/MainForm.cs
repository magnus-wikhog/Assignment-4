﻿///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using Assignment.Animals;
using Assignment.Recipe;
using Assignment.Staff;
using Assignment.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{



    /// <summary>
    /// The main form for this application.
    /// </summary>
    public partial class MainForm : Form{
        private AnimalManager mAnimalManager;
        private RecipeManager mRecipeManager;
        private StaffManager mStaffManager;
        private Dictionary<string, CategoryConfiguration> mCategoriesConfigurations;
        private Dictionary<string, SpeciesConfiguration> mSpeciesConfigurations;

        /// <summary>
        /// This constructor creates and initilaizes the necessary data structures for the main form
        /// of the application.
        /// </summary>
        public MainForm(){
            InitializeComponent();

            // Configrure categories
            mCategoriesConfigurations = new Dictionary<string, CategoryConfiguration> {
                { "Mammal", new CategoryConfiguration("Mammal", mammalInput) },
                { "Bird",   new CategoryConfiguration("Bird",   birdInput) }
            };

            // Configure species
            mSpeciesConfigurations = new Dictionary<string, SpeciesConfiguration> {
                { "Cat",   new SpeciesConfiguration("Cat",  catInput, mCategoriesConfigurations["Mammal"] ) },
                { "Dog",   new SpeciesConfiguration("Dog",  dogInput, mCategoriesConfigurations["Mammal"] ) },
                { "Swan",  new SpeciesConfiguration("Swan", swanInput, mCategoriesConfigurations["Bird"]   ) },
                { "Crow",  new SpeciesConfiguration("Crow", crowInput, mCategoriesConfigurations["Bird"]   ) }
            };

            foreach(string category in mCategoriesConfigurations.Keys){
                categoryListbox.Items.Add(category);
            }
            categoryListbox.SelectedIndex = 0;
            animalGenderListView.SelectedIndex = 0;

            Initialize();
        }


        /// <summary>
        /// Initializes / resets the applications data structures and updates the UI accordingly.
        /// </summary>
        void Initialize() {
            // Initialize list managers
            mAnimalManager = new AnimalManager();
            mRecipeManager = new RecipeManager();
            mStaffManager = new StaffManager();

            DisplayAnimals();
            DisplayRecipes();
            DisplayStaff();
        }


        /// <summary>
        /// Updates the UI in response to a selected category
        /// </summary>
        void OnCategorySelected(string category) {
            speciesListbox.Items.Clear();

            // category can be null if showAllCategoriesCheckbox is checked
            foreach (SpeciesConfiguration species in mSpeciesConfigurations.Values) {
                if (null == category || species.categoryConfiguration.name.Equals(category))
                    speciesListbox.Items.Add(species.name);
            }

            if( speciesListbox.Items.Count > 0)
                speciesListbox.SelectedIndex = 0;
        }



        /// <summary>
        /// Event handler for the category list
        /// </summary>
        private void categoryListbox_SelectedIndexChanged(object sender, EventArgs e) {
            OnCategorySelected(categoryListbox.SelectedItem.ToString());
        }

        /// <summary>
        /// Updates the UI when the user checks/unchecks "Show all species"
        /// </summary>
        private void showAllCategoriesCheckbox_CheckedChanged(object sender, EventArgs e) {
            categoryListbox.Enabled = !showAllCategoriesCheckbox.Checked;

            // Change category to <null> so the species listbox displays all species
            OnCategorySelected(showAllCategoriesCheckbox.Checked ? null : categoryListbox.Text);
        }

        /// <summary>
        /// Updates the UI when the user selects a species
        /// </summary>
        private void speciesListbox_SelectedIndexChanged(object sender, EventArgs e) {
            // Activate correct panel for the selected species
            // Category panel must also be actived from here, because we could be showing animals from
            // all categories in the listview.
            SpeciesConfiguration speciesConfiguration = mSpeciesConfigurations[speciesListbox.Text];
            speciesConfiguration.inputPanel.BringToFront();
            speciesConfiguration.categoryConfiguration.inputPanel.BringToFront();
        }



        /// <summary>
        /// Adds an animal with the current specification to the list.
        /// </summary>
        private void addAnimalButton_Click(object sender, EventArgs e) {
            // Determine which type of animal to create, and use the correct UI elements to set it's properties
            Animal animal = AnimalFactory.CreateAnimal(
                speciesListbox.Text,
                new Dictionary<String, Object>(){
                    { "mammalTeethCount",       (int)mammalTeethCountUpDown.Value },
                    { "catClawLength",          (double)catClawLengthUpDown.Value },
                    { "dogTailLength",          (double)dogTailLengthUpDown.Value },
                    { "birdWingSpan",           (double)birdWingSpanUpDown.Value },
                    { "swanColor",              swanColorTextbox.Text },
                    { "crowWeight",             (double)crowWeightUpDown.Value },
                }
            );

            // Set common animal properties
            animal.Name = animalNameTextbox.Text;
            animal.age = (int)animalAgeUpDown.Value;
            animal.Gender = animalGenderListView.SelectedItem.ToString();

            mAnimalManager.AddAnimal(animal);

            // Add the animal to the list
            animalsListView.Items.Add(new ListViewItem( new string[]{ animal.ID, animal.GetSpecies(), animal.Name, animal.age.ToString(), animal.Gender, animal.GetSpecialCharacteristics() } ));
        }


        /// <summary>
        /// Reloads all animals from the AnimalManager and displays them in the list.
        /// </summary>
        private void DisplayAnimals() {
            animalsListView.Items.Clear();
            for (int i = 0; i < mAnimalManager.Count; i++) {
                Animal animal = mAnimalManager.GetAt(i);
                animalsListView.Items.Add(new ListViewItem(new string[] { animal.ID, animal.GetSpecies(), animal.Name, animal.age.ToString(), animal.Gender, animal.GetSpecialCharacteristics() }));
            }
        }


        /// <summary>
        /// Updates the eating type and feeding schedule when the user selects an animal in the list.
        /// </summary>
        private void animalsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            Animal animal = mAnimalManager.GetAt(e.Item.Index);
            if( null != animal) {
                eaterTypeTextBox.Text = animal.GetEaterType().ToString();
                feedingScheduleTextBox.Text = animal.GetFoodSchedule().ToString();
            }
        }


        /// <summary>
        /// Sorts the animals using different algorithems based on which column is clicked.
        /// </summary>
        private void animalsListView_ColumnClick(object sender, ColumnClickEventArgs e) {
            IComparer<Animal> comparer = null;

            if (animalsListView.Columns[e.Column].Text.Equals("ID"))
                comparer = new IdComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Name"))
                comparer = new NameComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Species"))
                comparer = new SpeciesComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Age"))
                comparer = new AgeComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Gender"))
                comparer = new GenderComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Special characteristics"))
                comparer = new SpecialCharacteristicsComparer();

            if (null != comparer) {
                mAnimalManager.Sort(comparer);
                DisplayAnimals();
            }
        }


        /// <summary>
        /// Delete an animal when the Delete button is clicked
        /// </summary>
        private void deleteAnimalButton_Click(object sender, EventArgs e) {
            if (animalsListView.SelectedIndices.Count == 1) {
                mAnimalManager.DeleteAt(animalsListView.SelectedIndices[0]);
                eaterTypeTextBox.Text = "";
                feedingScheduleTextBox.Text = "";
                DisplayAnimals();
            }
        }


        /// <summary>
        /// Brings up the RecipeForm where the user can create a new recipe which will be added to the RecipeManager.
        /// </summary>
        private void addFoodButton_Click(object sender, EventArgs e) {
            StaffOrFoodForm form = new StaffOrFoodForm("Add recipe", "Ingredients", "Ingredient");
            if (form.ShowDialog() == DialogResult.OK) {
                Recipe.Recipe recipe = new Recipe.Recipe();
                recipe.Name = form.result.name;
                form.result.stringList.ForEach(s => recipe.Ingredients.Add(s));
                mRecipeManager.Add(recipe);
                DisplayRecipes();
            }
        }


        /*
          * Reloads all recipes from the RecipeManager and displays them in the list.
          */
        private void DisplayRecipes() {
            foodListbox.Items.Clear();
            foodListbox.Items.AddRange(mRecipeManager.ToStringArray());
        }




        /// <summary>
        /// Brings up the StaffForm where the user can register staffs qualifications.
        /// </summary>
        private void addStaffButton_Click(object sender, EventArgs e) {
            StaffOrFoodForm form = new StaffOrFoodForm("Add staff", "qualifications", "Qualification");
            if (form.ShowDialog() == DialogResult.OK) {
                Staff.Staff staff = new Staff.Staff();
                staff.Name = form.result.name;
                form.result.stringList.ForEach(s => staff.Qualifications.Add(s));
                mStaffManager.Add(staff);
                DisplayStaff();
            }
        }

        /// <summary>
        /// Reloads all staff from the StaffManager and displays them in the list.
        /// </summary>
        private void DisplayStaff() {
            staffListbox.Items.Clear();
            staffListbox.Items.AddRange(mStaffManager.ToStringArray());
        }


        /// <summary>
        /// The user selected File -> New, so we reset the application.
        /// </summary>
        private void mnuFileNew_Click(object sender, EventArgs e) {
            Initialize();
        }

        private void binaryFileToolStripMenuItem2_Click(object sender, EventArgs e) {
        }

        /// <summary>
        /// The user selected File -> Save as -> Binary, so we display a save dialog and save the file.
        /// </summary>
        private void mnuFileSaveAsBinary_Click(object sender, EventArgs e) {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Binary file|*.bin";
            saveDlg.Title = "Save as binary file";
            saveDlg.ShowDialog();

            if (saveDlg.FileName != "") {
                mAnimalManager.BinarySerialize(saveDlg.FileName);
            }
        }

        /// <summary>
        /// The user selected File -> Open -> Binary, so we display an open dialog and open the file.
        /// </summary>
        private void mnuFileOpenBinary_Click(object sender, EventArgs e) {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Binary file|*.bin";
            openDlg.Title = "Open binary file";
            openDlg.ShowDialog();

            if (openDlg.FileName != "") {
                mAnimalManager.BinaryDeSerialize(openDlg.FileName);
                DisplayAnimals();
            }
        }
    }






    /// <summary>
    /// Class that represents a configuration for a category (for example which input panel to display).
    /// </summary>
    class CategoryConfiguration {
        public string name;
        public Panel inputPanel;

        public CategoryConfiguration(string name, Panel inputPanel) {
            this.name = name;
            this.inputPanel = inputPanel;
        }
    }


    /// <summary>
    /// Class that represents a configuration for a species (for example which input panel to display).
    /// </summary>
    class SpeciesConfiguration {
        public string name;
        public Panel inputPanel;
        public CategoryConfiguration categoryConfiguration;

        public SpeciesConfiguration(string name, Panel inputPanel, CategoryConfiguration categoryConfiguration) {
            this.name = name;
            this.inputPanel = inputPanel;

            // Determines which category configuration to use for this species
            this.categoryConfiguration = categoryConfiguration;
        }
    }


}
