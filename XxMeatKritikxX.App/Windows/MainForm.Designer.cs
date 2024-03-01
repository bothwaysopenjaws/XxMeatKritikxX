namespace XxMeatKritikxX.App.Windows
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonManageUser = new Button();
            listBoxVideoGames = new ListBox();
            groupBoxDescriptionVideoGame = new GroupBox();
            labelNote = new Label();
            listBoxNotation = new ListBox();
            textBoxPrice = new TextBox();
            dateTimePickerParutionDate = new DateTimePicker();
            comboBoxGenre = new ComboBox();
            comboBoxStudio = new ComboBox();
            labelPrice = new Label();
            pictureBoxVideoGame = new PictureBox();
            labelParutionDate = new Label();
            labelStudio = new Label();
            labelGenre = new Label();
            groupBoxDescriptionVideoGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoGame).BeginInit();
            SuspendLayout();
            // 
            // buttonManageUser
            // 
            buttonManageUser.Location = new Point(12, 484);
            buttonManageUser.Name = "buttonManageUser";
            buttonManageUser.Size = new Size(199, 40);
            buttonManageUser.TabIndex = 0;
            buttonManageUser.Text = "Utilisateurs";
            buttonManageUser.UseVisualStyleBackColor = true;
            buttonManageUser.Click += buttonManageUser_Click;
            // 
            // listBoxVideoGames
            // 
            listBoxVideoGames.FormattingEnabled = true;
            listBoxVideoGames.ItemHeight = 15;
            listBoxVideoGames.Location = new Point(12, 12);
            listBoxVideoGames.Name = "listBoxVideoGames";
            listBoxVideoGames.Size = new Size(199, 469);
            listBoxVideoGames.TabIndex = 1;
            listBoxVideoGames.SelectedIndexChanged += listBoxVideoGames_SelectedIndexChanged;
            // 
            // groupBoxDescriptionVideoGame
            // 
            groupBoxDescriptionVideoGame.Controls.Add(labelNote);
            groupBoxDescriptionVideoGame.Controls.Add(listBoxNotation);
            groupBoxDescriptionVideoGame.Controls.Add(textBoxPrice);
            groupBoxDescriptionVideoGame.Controls.Add(dateTimePickerParutionDate);
            groupBoxDescriptionVideoGame.Controls.Add(comboBoxGenre);
            groupBoxDescriptionVideoGame.Controls.Add(comboBoxStudio);
            groupBoxDescriptionVideoGame.Controls.Add(labelPrice);
            groupBoxDescriptionVideoGame.Controls.Add(pictureBoxVideoGame);
            groupBoxDescriptionVideoGame.Controls.Add(labelParutionDate);
            groupBoxDescriptionVideoGame.Controls.Add(labelStudio);
            groupBoxDescriptionVideoGame.Controls.Add(labelGenre);
            groupBoxDescriptionVideoGame.Location = new Point(217, 12);
            groupBoxDescriptionVideoGame.Name = "groupBoxDescriptionVideoGame";
            groupBoxDescriptionVideoGame.Size = new Size(755, 512);
            groupBoxDescriptionVideoGame.TabIndex = 2;
            groupBoxDescriptionVideoGame.TabStop = false;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Font = new Font("Segoe UI", 20F);
            labelNote.Location = new Point(541, 28);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(0, 37);
            labelNote.TabIndex = 10;
            // 
            // listBoxNotation
            // 
            listBoxNotation.FormattingEnabled = true;
            listBoxNotation.ItemHeight = 15;
            listBoxNotation.Location = new Point(383, 77);
            listBoxNotation.Name = "listBoxNotation";
            listBoxNotation.Size = new Size(362, 409);
            listBoxNotation.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(97, 115);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(181, 23);
            textBoxPrice.TabIndex = 8;
            // 
            // dateTimePickerParutionDate
            // 
            dateTimePickerParutionDate.Location = new Point(97, 86);
            dateTimePickerParutionDate.Name = "dateTimePickerParutionDate";
            dateTimePickerParutionDate.Size = new Size(182, 23);
            dateTimePickerParutionDate.TabIndex = 7;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(97, 28);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(182, 23);
            comboBoxGenre.TabIndex = 6;
            // 
            // comboBoxStudio
            // 
            comboBoxStudio.FormattingEnabled = true;
            comboBoxStudio.Location = new Point(97, 57);
            comboBoxStudio.Name = "comboBoxStudio";
            comboBoxStudio.Size = new Size(182, 23);
            comboBoxStudio.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(55, 123);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 15);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Prix : ";
            // 
            // pictureBoxVideoGame
            // 
            pictureBoxVideoGame.Location = new Point(6, 161);
            pictureBoxVideoGame.Name = "pictureBoxVideoGame";
            pictureBoxVideoGame.Size = new Size(300, 300);
            pictureBoxVideoGame.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxVideoGame.TabIndex = 3;
            pictureBoxVideoGame.TabStop = false;
            // 
            // labelParutionDate
            // 
            labelParutionDate.AutoSize = true;
            labelParutionDate.Location = new Point(6, 92);
            labelParutionDate.Name = "labelParutionDate";
            labelParutionDate.Size = new Size(85, 15);
            labelParutionDate.TabIndex = 2;
            labelParutionDate.Text = "Date de sortie :";
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Location = new Point(43, 65);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(47, 15);
            labelStudio.TabIndex = 1;
            labelStudio.Text = "Studio :";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(44, 36);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(47, 15);
            labelGenre.TabIndex = 0;
            labelGenre.Text = "Genre : ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 536);
            Controls.Add(groupBoxDescriptionVideoGame);
            Controls.Add(listBoxVideoGames);
            Controls.Add(buttonManageUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "XxMeatKritikxX";
            groupBoxDescriptionVideoGame.ResumeLayout(false);
            groupBoxDescriptionVideoGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonManageUser;
        private ListBox listBoxVideoGames;
        private GroupBox groupBoxDescriptionVideoGame;
        private Label labelParutionDate;
        private Label labelStudio;
        private Label labelGenre;
        private TextBox textBoxPrice;
        private DateTimePicker dateTimePickerParutionDate;
        private ComboBox comboBoxGenre;
        private ComboBox comboBoxStudio;
        private Label labelPrice;
        private PictureBox pictureBoxVideoGame;
        private ListBox listBoxNotation;
        private Label labelNote;
    }
}
