namespace Assignment {
    partial class StaffOrFoodForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.listboxGroup = new System.Windows.Forms.GroupBox();
            this.addToListTextbox = new System.Windows.Forms.TextBox();
            this.addToListboxLabel = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.listboxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(57, 15);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(295, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // listboxGroup
            // 
            this.listboxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxGroup.Controls.Add(this.addToListTextbox);
            this.listboxGroup.Controls.Add(this.addToListboxLabel);
            this.listboxGroup.Controls.Add(this.listbox);
            this.listboxGroup.Controls.Add(this.deleteButton);
            this.listboxGroup.Controls.Add(this.changeButton);
            this.listboxGroup.Controls.Add(this.addButton);
            this.listboxGroup.Location = new System.Drawing.Point(15, 51);
            this.listboxGroup.Name = "listboxGroup";
            this.listboxGroup.Size = new System.Drawing.Size(352, 208);
            this.listboxGroup.TabIndex = 2;
            this.listboxGroup.TabStop = false;
            this.listboxGroup.Text = "Qualifications";
            // 
            // addToListTextbox
            // 
            this.addToListTextbox.Location = new System.Drawing.Point(86, 19);
            this.addToListTextbox.Name = "addToListTextbox";
            this.addToListTextbox.Size = new System.Drawing.Size(251, 20);
            this.addToListTextbox.TabIndex = 5;
            // 
            // addToListboxLabel
            // 
            this.addToListboxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addToListboxLabel.AutoSize = true;
            this.addToListboxLabel.Location = new System.Drawing.Point(15, 22);
            this.addToListboxLabel.Name = "addToListboxLabel";
            this.addToListboxLabel.Size = new System.Drawing.Size(65, 13);
            this.addToListboxLabel.TabIndex = 4;
            this.addToListboxLabel.Text = "Qualification";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(111, 59);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(226, 134);
            this.listbox.TabIndex = 3;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.ingredientsListbox_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(18, 117);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(18, 88);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 59);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(156, 265);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // StaffOrFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.listboxGroup);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "StaffOrFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.TopMost = true;
            this.listboxGroup.ResumeLayout(false);
            this.listboxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.GroupBox listboxGroup;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addToListTextbox;
        private System.Windows.Forms.Label addToListboxLabel;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button okButton;
    }
}