namespace ContactsBook
{
    partial class PhoneBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewButton = new Button();
            FirstNameTextBox = new TextBox();
            label1 = new Label();
            PhoneNumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailLabel = new Label();
            LastNameLabel = new Label();
            DeleteButton = new Button();
            SaveButton = new Button();
            LoadButton = new Button();
            PhoneBookDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PhoneBookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // NewButton
            // 
            NewButton.Location = new Point(672, 20);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(116, 23);
            NewButton.TabIndex = 0;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(113, 21);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(553, 23);
            FirstNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(113, 138);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(553, 23);
            PhoneNumberTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(113, 99);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(553, 23);
            EmailTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(113, 60);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(553, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(66, 138);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(41, 19);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            EmailLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(66, 103);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(41, 19);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Email";
            // 
            // LastNameLabel
            // 
            LastNameLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(45, 64);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(62, 19);
            LastNameLabel.TabIndex = 8;
            LastNameLabel.Text = "Last Name";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(672, 138);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(116, 23);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(672, 98);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(116, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(672, 60);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(116, 23);
            LoadButton.TabIndex = 11;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // PhoneBookDataGrid
            // 
            PhoneBookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PhoneBookDataGrid.Location = new Point(22, 188);
            PhoneBookDataGrid.Name = "PhoneBookDataGrid";
            PhoneBookDataGrid.RowTemplate.Height = 25;
            PhoneBookDataGrid.Size = new Size(766, 250);
            PhoneBookDataGrid.TabIndex = 12;
            PhoneBookDataGrid.CellDoubleClick += PhoneBookDataGrid_CellDoubleClick;
            // 
            // PhoneBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PhoneBookDataGrid);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(LastNameLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(label1);
            Controls.Add(FirstNameTextBox);
            Controls.Add(NewButton);
            Name = "PhoneBook";
            Text = "PhoneBook";
            Load += PhoneBook_Load;
            ((System.ComponentModel.ISupportInitialize)PhoneBookDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewButton;
        private TextBox FirstNameTextBox;
        private Label label1;
        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
        private TextBox LastNameTextBox;
        private Label PhoneNumberLabel;
        private Label EmailLabel;
        private Label LastNameLabel;
        private Button DeleteButton;
        private Button SaveButton;
        private Button LoadButton;
        private DataGridView PhoneBookDataGrid;
    }
}