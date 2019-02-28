namespace Assignment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.speciesListbox = new System.Windows.Forms.ListBox();
            this.showAllCategoriesCheckbox = new System.Windows.Forms.CheckBox();
            this.categoryListbox = new System.Windows.Forms.ListBox();
            this.animalAgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.animalNameTextbox = new System.Windows.Forms.TextBox();
            this.birdInput = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.birdWingSpanUpDown = new System.Windows.Forms.NumericUpDown();
            this.swanInput = new System.Windows.Forms.Panel();
            this.swanColorTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.crowInput = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.crowWeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.catInput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.catClawLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.dogInput = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dogTailLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.mammalInput = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mammalTeethCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.animalGenderListView = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteAnimalButton = new System.Windows.Forms.Button();
            this.animalsListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.species = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialCharacteristics = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addAnimalButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.foodPage = new System.Windows.Forms.TabPage();
            this.foodListbox = new System.Windows.Forms.ListBox();
            this.addFoodButton = new System.Windows.Forms.Button();
            this.staffPage = new System.Windows.Forms.TabPage();
            this.staffListbox = new System.Windows.Forms.ListBox();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.feedingScheduleTextBox = new System.Windows.Forms.TextBox();
            this.eaterTypeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAgeUpDown)).BeginInit();
            this.birdInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdWingSpanUpDown)).BeginInit();
            this.swanInput.SuspendLayout();
            this.crowInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crowWeightUpDown)).BeginInit();
            this.catInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catClawLengthUpDown)).BeginInit();
            this.dogInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogTailLengthUpDown)).BeginInit();
            this.mammalInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mammalTeethCountUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.foodPage.SuspendLayout();
            this.staffPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.speciesListbox);
            this.groupBox1.Controls.Add(this.showAllCategoriesCheckbox);
            this.groupBox1.Controls.Add(this.categoryListbox);
            this.groupBox1.Controls.Add(this.animalAgeUpDown);
            this.groupBox1.Controls.Add(this.animalNameTextbox);
            this.groupBox1.Controls.Add(this.birdInput);
            this.groupBox1.Controls.Add(this.swanInput);
            this.groupBox1.Controls.Add(this.crowInput);
            this.groupBox1.Controls.Add(this.catInput);
            this.groupBox1.Controls.Add(this.dogInput);
            this.groupBox1.Controls.Add(this.mammalInput);
            this.groupBox1.Controls.Add(this.animalGenderListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(613, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal specification";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Species";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // speciesListbox
            // 
            this.speciesListbox.FormattingEnabled = true;
            this.speciesListbox.Location = new System.Drawing.Point(408, 33);
            this.speciesListbox.Name = "speciesListbox";
            this.speciesListbox.Size = new System.Drawing.Size(195, 108);
            this.speciesListbox.TabIndex = 6;
            this.speciesListbox.SelectedIndexChanged += new System.EventHandler(this.speciesListbox_SelectedIndexChanged);
            // 
            // showAllCategoriesCheckbox
            // 
            this.showAllCategoriesCheckbox.AutoSize = true;
            this.showAllCategoriesCheckbox.Location = new System.Drawing.Point(188, 118);
            this.showAllCategoriesCheckbox.Name = "showAllCategoriesCheckbox";
            this.showAllCategoriesCheckbox.Size = new System.Drawing.Size(105, 17);
            this.showAllCategoriesCheckbox.TabIndex = 4;
            this.showAllCategoriesCheckbox.Text = "Show all species";
            this.showAllCategoriesCheckbox.UseVisualStyleBackColor = true;
            this.showAllCategoriesCheckbox.CheckedChanged += new System.EventHandler(this.showAllCategoriesCheckbox_CheckedChanged);
            // 
            // categoryListbox
            // 
            this.categoryListbox.FormattingEnabled = true;
            this.categoryListbox.Location = new System.Drawing.Point(188, 33);
            this.categoryListbox.Name = "categoryListbox";
            this.categoryListbox.Size = new System.Drawing.Size(195, 82);
            this.categoryListbox.TabIndex = 3;
            this.categoryListbox.SelectedIndexChanged += new System.EventHandler(this.categoryListbox_SelectedIndexChanged);
            // 
            // animalAgeUpDown
            // 
            this.animalAgeUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.animalAgeUpDown.Location = new System.Drawing.Point(10, 81);
            this.animalAgeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.animalAgeUpDown.Name = "animalAgeUpDown";
            this.animalAgeUpDown.ReadOnly = true;
            this.animalAgeUpDown.Size = new System.Drawing.Size(156, 20);
            this.animalAgeUpDown.TabIndex = 1;
            this.animalAgeUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // animalNameTextbox
            // 
            this.animalNameTextbox.Location = new System.Drawing.Point(10, 36);
            this.animalNameTextbox.Name = "animalNameTextbox";
            this.animalNameTextbox.Size = new System.Drawing.Size(157, 20);
            this.animalNameTextbox.TabIndex = 0;
            this.animalNameTextbox.Text = "Kalle";
            // 
            // birdInput
            // 
            this.birdInput.Controls.Add(this.label4);
            this.birdInput.Controls.Add(this.birdWingSpanUpDown);
            this.birdInput.Location = new System.Drawing.Point(188, 149);
            this.birdInput.Name = "birdInput";
            this.birdInput.Size = new System.Drawing.Size(195, 58);
            this.birdInput.TabIndex = 14;
            this.birdInput.Tag = "cat_input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wing span (cm)";
            // 
            // birdWingSpanUpDown
            // 
            this.birdWingSpanUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.birdWingSpanUpDown.Location = new System.Drawing.Point(3, 20);
            this.birdWingSpanUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.birdWingSpanUpDown.Name = "birdWingSpanUpDown";
            this.birdWingSpanUpDown.ReadOnly = true;
            this.birdWingSpanUpDown.Size = new System.Drawing.Size(189, 20);
            this.birdWingSpanUpDown.TabIndex = 1;
            this.birdWingSpanUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // swanInput
            // 
            this.swanInput.Controls.Add(this.swanColorTextbox);
            this.swanInput.Controls.Add(this.label6);
            this.swanInput.Location = new System.Drawing.Point(408, 149);
            this.swanInput.Name = "swanInput";
            this.swanInput.Size = new System.Drawing.Size(195, 58);
            this.swanInput.TabIndex = 11;
            this.swanInput.Tag = "cat_input";
            // 
            // swanColorTextbox
            // 
            this.swanColorTextbox.Location = new System.Drawing.Point(3, 20);
            this.swanColorTextbox.Name = "swanColorTextbox";
            this.swanColorTextbox.Size = new System.Drawing.Size(189, 20);
            this.swanColorTextbox.TabIndex = 3;
            this.swanColorTextbox.Text = "black";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Color";
            // 
            // crowInput
            // 
            this.crowInput.Controls.Add(this.label5);
            this.crowInput.Controls.Add(this.crowWeightUpDown);
            this.crowInput.Location = new System.Drawing.Point(408, 149);
            this.crowInput.Name = "crowInput";
            this.crowInput.Size = new System.Drawing.Size(195, 58);
            this.crowInput.TabIndex = 13;
            this.crowInput.Tag = "cat_input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Weight (kg)";
            // 
            // crowWeightUpDown
            // 
            this.crowWeightUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.crowWeightUpDown.Location = new System.Drawing.Point(3, 20);
            this.crowWeightUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.crowWeightUpDown.Name = "crowWeightUpDown";
            this.crowWeightUpDown.ReadOnly = true;
            this.crowWeightUpDown.Size = new System.Drawing.Size(189, 20);
            this.crowWeightUpDown.TabIndex = 1;
            // 
            // catInput
            // 
            this.catInput.Controls.Add(this.label1);
            this.catInput.Controls.Add(this.catClawLengthUpDown);
            this.catInput.Location = new System.Drawing.Point(408, 149);
            this.catInput.Name = "catInput";
            this.catInput.Size = new System.Drawing.Size(195, 58);
            this.catInput.TabIndex = 8;
            this.catInput.Tag = "cat_input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Claw length (cm)";
            // 
            // catClawLengthUpDown
            // 
            this.catClawLengthUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.catClawLengthUpDown.Location = new System.Drawing.Point(3, 20);
            this.catClawLengthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.catClawLengthUpDown.Name = "catClawLengthUpDown";
            this.catClawLengthUpDown.ReadOnly = true;
            this.catClawLengthUpDown.Size = new System.Drawing.Size(189, 20);
            this.catClawLengthUpDown.TabIndex = 1;
            // 
            // dogInput
            // 
            this.dogInput.Controls.Add(this.label2);
            this.dogInput.Controls.Add(this.dogTailLengthUpDown);
            this.dogInput.Location = new System.Drawing.Point(408, 149);
            this.dogInput.Name = "dogInput";
            this.dogInput.Size = new System.Drawing.Size(195, 58);
            this.dogInput.TabIndex = 9;
            this.dogInput.Tag = "cat_input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tail length (cm)";
            // 
            // dogTailLengthUpDown
            // 
            this.dogTailLengthUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.dogTailLengthUpDown.Location = new System.Drawing.Point(3, 20);
            this.dogTailLengthUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dogTailLengthUpDown.Name = "dogTailLengthUpDown";
            this.dogTailLengthUpDown.ReadOnly = true;
            this.dogTailLengthUpDown.Size = new System.Drawing.Size(189, 20);
            this.dogTailLengthUpDown.TabIndex = 1;
            // 
            // mammalInput
            // 
            this.mammalInput.Controls.Add(this.label3);
            this.mammalInput.Controls.Add(this.mammalTeethCountUpDown);
            this.mammalInput.Location = new System.Drawing.Point(188, 149);
            this.mammalInput.Name = "mammalInput";
            this.mammalInput.Size = new System.Drawing.Size(195, 58);
            this.mammalInput.TabIndex = 10;
            this.mammalInput.Tag = "cat_input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number pf teeth";
            // 
            // mammalTeethCountUpDown
            // 
            this.mammalTeethCountUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.mammalTeethCountUpDown.Location = new System.Drawing.Point(3, 20);
            this.mammalTeethCountUpDown.Name = "mammalTeethCountUpDown";
            this.mammalTeethCountUpDown.ReadOnly = true;
            this.mammalTeethCountUpDown.Size = new System.Drawing.Size(189, 20);
            this.mammalTeethCountUpDown.TabIndex = 1;
            // 
            // animalGenderListView
            // 
            this.animalGenderListView.FormattingEnabled = true;
            this.animalGenderListView.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.animalGenderListView.Location = new System.Drawing.Point(10, 126);
            this.animalGenderListView.Name = "animalGenderListView";
            this.animalGenderListView.Size = new System.Drawing.Size(157, 82);
            this.animalGenderListView.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.deleteAnimalButton);
            this.groupBox2.Controls.Add(this.animalsListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(907, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animals";
            // 
            // deleteAnimalButton
            // 
            this.deleteAnimalButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteAnimalButton.Location = new System.Drawing.Point(10, 227);
            this.deleteAnimalButton.Name = "deleteAnimalButton";
            this.deleteAnimalButton.Size = new System.Drawing.Size(114, 26);
            this.deleteAnimalButton.TabIndex = 5;
            this.deleteAnimalButton.Text = "Delete animal";
            this.deleteAnimalButton.UseVisualStyleBackColor = true;
            this.deleteAnimalButton.Click += new System.EventHandler(this.deleteAnimalButton_Click);
            // 
            // animalsListView
            // 
            this.animalsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.species,
            this.name,
            this.age,
            this.gender,
            this.specialCharacteristics});
            this.animalsListView.FullRowSelect = true;
            this.animalsListView.Location = new System.Drawing.Point(10, 23);
            this.animalsListView.MultiSelect = false;
            this.animalsListView.Name = "animalsListView";
            this.animalsListView.Size = new System.Drawing.Size(593, 198);
            this.animalsListView.TabIndex = 0;
            this.animalsListView.UseCompatibleStateImageBehavior = false;
            this.animalsListView.View = System.Windows.Forms.View.Details;
            this.animalsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.animalsListView_ColumnClick);
            this.animalsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.animalsListView_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // species
            // 
            this.species.Text = "Species";
            this.species.Width = 52;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 68;
            // 
            // age
            // 
            this.age.Text = "Age";
            this.age.Width = 35;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 61;
            // 
            // specialCharacteristics
            // 
            this.specialCharacteristics.Text = "Special characteristics";
            this.specialCharacteristics.Width = 539;
            // 
            // addAnimalButton
            // 
            this.addAnimalButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addAnimalButton.Location = new System.Drawing.Point(408, 238);
            this.addAnimalButton.Name = "addAnimalButton";
            this.addAnimalButton.Size = new System.Drawing.Size(114, 26);
            this.addAnimalButton.TabIndex = 4;
            this.addAnimalButton.Text = "Add animal";
            this.addAnimalButton.UseVisualStyleBackColor = true;
            this.addAnimalButton.Click += new System.EventHandler(this.addAnimalButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.foodPage);
            this.tabControl1.Controls.Add(this.staffPage);
            this.tabControl1.Location = new System.Drawing.Point(631, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 216);
            this.tabControl1.TabIndex = 8;
            // 
            // foodPage
            // 
            this.foodPage.BackColor = System.Drawing.SystemColors.Window;
            this.foodPage.Controls.Add(this.foodListbox);
            this.foodPage.Controls.Add(this.addFoodButton);
            this.foodPage.Location = new System.Drawing.Point(4, 22);
            this.foodPage.Name = "foodPage";
            this.foodPage.Padding = new System.Windows.Forms.Padding(3);
            this.foodPage.Size = new System.Drawing.Size(279, 190);
            this.foodPage.TabIndex = 0;
            this.foodPage.Text = "Food";
            // 
            // foodListbox
            // 
            this.foodListbox.FormattingEnabled = true;
            this.foodListbox.Location = new System.Drawing.Point(7, 10);
            this.foodListbox.Name = "foodListbox";
            this.foodListbox.Size = new System.Drawing.Size(264, 134);
            this.foodListbox.TabIndex = 5;
            // 
            // addFoodButton
            // 
            this.addFoodButton.Location = new System.Drawing.Point(7, 155);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(75, 26);
            this.addFoodButton.TabIndex = 4;
            this.addFoodButton.Text = "Add food";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // staffPage
            // 
            this.staffPage.BackColor = System.Drawing.SystemColors.Window;
            this.staffPage.Controls.Add(this.staffListbox);
            this.staffPage.Controls.Add(this.addStaffButton);
            this.staffPage.Location = new System.Drawing.Point(4, 22);
            this.staffPage.Name = "staffPage";
            this.staffPage.Padding = new System.Windows.Forms.Padding(3);
            this.staffPage.Size = new System.Drawing.Size(279, 190);
            this.staffPage.TabIndex = 1;
            this.staffPage.Text = "Staff";
            // 
            // staffListbox
            // 
            this.staffListbox.FormattingEnabled = true;
            this.staffListbox.Location = new System.Drawing.Point(7, 10);
            this.staffListbox.Name = "staffListbox";
            this.staffListbox.Size = new System.Drawing.Size(264, 134);
            this.staffListbox.TabIndex = 7;
            // 
            // addStaffButton
            // 
            this.addStaffButton.Location = new System.Drawing.Point(7, 155);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(75, 26);
            this.addStaffButton.TabIndex = 6;
            this.addStaffButton.Text = "Add staff";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.feedingScheduleTextBox);
            this.groupBox3.Controls.Add(this.eaterTypeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(609, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 198);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feeding schedule";
            // 
            // feedingScheduleTextBox
            // 
            this.feedingScheduleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedingScheduleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.feedingScheduleTextBox.Enabled = false;
            this.feedingScheduleTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.feedingScheduleTextBox.Location = new System.Drawing.Point(6, 46);
            this.feedingScheduleTextBox.Multiline = true;
            this.feedingScheduleTextBox.Name = "feedingScheduleTextBox";
            this.feedingScheduleTextBox.Size = new System.Drawing.Size(276, 145);
            this.feedingScheduleTextBox.TabIndex = 1;
            // 
            // eaterTypeTextBox
            // 
            this.eaterTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eaterTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.eaterTypeTextBox.Enabled = false;
            this.eaterTypeTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.eaterTypeTextBox.Location = new System.Drawing.Point(6, 20);
            this.eaterTypeTextBox.Name = "eaterTypeTextBox";
            this.eaterTypeTextBox.Size = new System.Drawing.Size(276, 20);
            this.eaterTypeTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addAnimalButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Animal Farm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAgeUpDown)).EndInit();
            this.birdInput.ResumeLayout(false);
            this.birdInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdWingSpanUpDown)).EndInit();
            this.swanInput.ResumeLayout(false);
            this.swanInput.PerformLayout();
            this.crowInput.ResumeLayout(false);
            this.crowInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crowWeightUpDown)).EndInit();
            this.catInput.ResumeLayout(false);
            this.catInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catClawLengthUpDown)).EndInit();
            this.dogInput.ResumeLayout(false);
            this.dogInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogTailLengthUpDown)).EndInit();
            this.mammalInput.ResumeLayout(false);
            this.mammalInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mammalTeethCountUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.foodPage.ResumeLayout(false);
            this.staffPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel catInput;
        private System.Windows.Forms.NumericUpDown catClawLengthUpDown;
        private System.Windows.Forms.ListBox speciesListbox;
        private System.Windows.Forms.CheckBox showAllCategoriesCheckbox;
        private System.Windows.Forms.ListBox categoryListbox;
        private System.Windows.Forms.NumericUpDown animalAgeUpDown;
        private System.Windows.Forms.TextBox animalNameTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView animalsListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Panel dogInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dogTailLengthUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mammalInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mammalTeethCountUpDown;
        private System.Windows.Forms.Panel swanInput;
        private System.Windows.Forms.TextBox swanColorTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel crowInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown crowWeightUpDown;
        private System.Windows.Forms.Panel birdInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown birdWingSpanUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader species;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader specialCharacteristics;
        private System.Windows.Forms.Button addAnimalButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox animalGenderListView;
        private System.Windows.Forms.Button deleteAnimalButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage foodPage;
        private System.Windows.Forms.ListBox foodListbox;
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.TabPage staffPage;
        private System.Windows.Forms.ListBox staffListbox;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox feedingScheduleTextBox;
        private System.Windows.Forms.TextBox eaterTypeTextBox;
    }
}

