namespace XxMeatKritikxX.App.Windows
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            listBoxUsers = new ListBox();
            listBoxVideoGames = new ListBox();
            groupBoxNotation = new GroupBox();
            buttonRemove = new Button();
            buttonValidate = new Button();
            labelComment = new Label();
            richTextBoxComment = new RichTextBox();
            numericUpDownNote = new NumericUpDown();
            labelNote = new Label();
            buttonAddNotation = new Button();
            buttonReutrn = new Button();
            buttonAddUser = new Button();
            buttonDeleteUser = new Button();
            buttonUpdateUser = new Button();
            groupBoxManageUser = new GroupBox();
            textBoxPseudo = new TextBox();
            labelUpdateText = new Label();
            buttonUpdateUserValidate = new Button();
            groupBoxNotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNote).BeginInit();
            groupBoxManageUser.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(8, 15);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(165, 289);
            listBoxUsers.TabIndex = 0;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // listBoxVideoGames
            // 
            listBoxVideoGames.FormattingEnabled = true;
            listBoxVideoGames.ItemHeight = 15;
            listBoxVideoGames.Location = new Point(196, 15);
            listBoxVideoGames.Name = "listBoxVideoGames";
            listBoxVideoGames.Size = new Size(188, 409);
            listBoxVideoGames.TabIndex = 1;
            listBoxVideoGames.SelectedIndexChanged += listBoxVideoGames_SelectedIndexChanged;
            // 
            // groupBoxNotation
            // 
            groupBoxNotation.Controls.Add(buttonRemove);
            groupBoxNotation.Controls.Add(buttonValidate);
            groupBoxNotation.Controls.Add(labelComment);
            groupBoxNotation.Controls.Add(richTextBoxComment);
            groupBoxNotation.Controls.Add(numericUpDownNote);
            groupBoxNotation.Controls.Add(labelNote);
            groupBoxNotation.Location = new Point(397, 15);
            groupBoxNotation.Name = "groupBoxNotation";
            groupBoxNotation.Size = new Size(403, 226);
            groupBoxNotation.TabIndex = 2;
            groupBoxNotation.TabStop = false;
            groupBoxNotation.Text = "Notation";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(209, 173);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(189, 37);
            buttonRemove.TabIndex = 11;
            buttonRemove.Text = "Supprimer";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(7, 173);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(189, 37);
            buttonValidate.TabIndex = 10;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new Point(7, 27);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(86, 15);
            labelComment.TabIndex = 9;
            labelComment.Text = "Commentaire :";
            // 
            // richTextBoxComment
            // 
            richTextBoxComment.Location = new Point(7, 58);
            richTextBoxComment.Name = "richTextBoxComment";
            richTextBoxComment.Size = new Size(391, 109);
            richTextBoxComment.TabIndex = 8;
            richTextBoxComment.Text = "";
            // 
            // numericUpDownNote
            // 
            numericUpDownNote.Location = new Point(272, 25);
            numericUpDownNote.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNote.Name = "numericUpDownNote";
            numericUpDownNote.Size = new Size(126, 23);
            numericUpDownNote.TabIndex = 7;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(190, 27);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(76, 15);
            labelNote.TabIndex = 6;
            labelNote.Text = "Note (0 -10) :";
            // 
            // buttonAddNotation
            // 
            buttonAddNotation.Location = new Point(404, 378);
            buttonAddNotation.Name = "buttonAddNotation";
            buttonAddNotation.Size = new Size(189, 46);
            buttonAddNotation.TabIndex = 3;
            buttonAddNotation.Text = "Noter ce jeu";
            buttonAddNotation.UseVisualStyleBackColor = true;
            buttonAddNotation.Click += buttonAddNotation_Click;
            // 
            // buttonReutrn
            // 
            buttonReutrn.Location = new Point(599, 378);
            buttonReutrn.Name = "buttonReutrn";
            buttonReutrn.Size = new Size(196, 46);
            buttonReutrn.TabIndex = 4;
            buttonReutrn.Text = "Retour";
            buttonReutrn.UseVisualStyleBackColor = true;
            buttonReutrn.Click += buttonReturn_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(8, 316);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(165, 30);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "Ajouter";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(7, 393);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(166, 32);
            buttonDeleteUser.TabIndex = 6;
            buttonDeleteUser.Text = "Supprimer";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonUpdateUser
            // 
            buttonUpdateUser.Location = new Point(7, 352);
            buttonUpdateUser.Name = "buttonUpdateUser";
            buttonUpdateUser.Size = new Size(166, 35);
            buttonUpdateUser.TabIndex = 7;
            buttonUpdateUser.Text = "Modifier";
            buttonUpdateUser.UseVisualStyleBackColor = true;
            buttonUpdateUser.Click += buttonUpdateUser_Click;
            // 
            // groupBoxManageUser
            // 
            groupBoxManageUser.Controls.Add(textBoxPseudo);
            groupBoxManageUser.Controls.Add(labelUpdateText);
            groupBoxManageUser.Controls.Add(buttonUpdateUserValidate);
            groupBoxManageUser.Location = new Point(400, 247);
            groupBoxManageUser.Name = "groupBoxManageUser";
            groupBoxManageUser.Size = new Size(396, 122);
            groupBoxManageUser.TabIndex = 8;
            groupBoxManageUser.TabStop = false;
            groupBoxManageUser.Text = "Modifier Utilisateur";
            // 
            // textBoxPseudo
            // 
            textBoxPseudo.Location = new Point(122, 24);
            textBoxPseudo.Name = "textBoxPseudo";
            textBoxPseudo.Size = new Size(115, 23);
            textBoxPseudo.TabIndex = 2;
            // 
            // labelUpdateText
            // 
            labelUpdateText.AutoSize = true;
            labelUpdateText.Location = new Point(15, 27);
            labelUpdateText.Name = "labelUpdateText";
            labelUpdateText.Size = new Size(101, 15);
            labelUpdateText.TabIndex = 1;
            labelUpdateText.Text = "nouveau pseudo :";
            // 
            // buttonUpdateUserValidate
            // 
            buttonUpdateUserValidate.Location = new Point(257, 19);
            buttonUpdateUserValidate.Name = "buttonUpdateUserValidate";
            buttonUpdateUserValidate.Size = new Size(121, 31);
            buttonUpdateUserValidate.TabIndex = 0;
            buttonUpdateUserValidate.Text = "Valider";
            buttonUpdateUserValidate.UseVisualStyleBackColor = true;
            buttonUpdateUserValidate.Click += buttonUpdateUserValidate_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxManageUser);
            Controls.Add(buttonUpdateUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonAddUser);
            Controls.Add(buttonReutrn);
            Controls.Add(buttonAddNotation);
            Controls.Add(groupBoxNotation);
            Controls.Add(listBoxVideoGames);
            Controls.Add(listBoxUsers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            Text = "UserForm";
            groupBoxNotation.ResumeLayout(false);
            groupBoxNotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNote).EndInit();
            groupBoxManageUser.ResumeLayout(false);
            groupBoxManageUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private ListBox listBoxVideoGames;
        private GroupBox groupBoxNotation;
        private Label labelComment;
        private RichTextBox richTextBoxComment;
        private NumericUpDown numericUpDownNote;
        private Label labelNote;
        private Button buttonAddNotation;
        private Button buttonRemove;
        private Button buttonValidate;
        private Button buttonReutrn;
        private Button buttonAddUser;
        private Button buttonDeleteUser;
        private Button buttonUpdateUser;
        private GroupBox groupBoxManageUser;
        private TextBox textBoxPseudo;
        private Label labelUpdateText;
        private Button buttonUpdateUserValidate;
    }
}