namespace XxMeatKritikxX.App
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
            SuspendLayout();
            // 
            // buttonManageUser
            // 
            buttonManageUser.Location = new Point(37, 37);
            buttonManageUser.Name = "buttonManageUser";
            buttonManageUser.Size = new Size(152, 40);
            buttonManageUser.TabIndex = 0;
            buttonManageUser.Text = "Utilisateurs";
            buttonManageUser.UseVisualStyleBackColor = true;
            // 
            // listBoxVideoGames
            // 
            listBoxVideoGames.FormattingEnabled = true;
            listBoxVideoGames.ItemHeight = 15;
            listBoxVideoGames.Location = new Point(37, 102);
            listBoxVideoGames.Name = "listBoxVideoGames";
            listBoxVideoGames.Size = new Size(154, 319);
            listBoxVideoGames.TabIndex = 1;
            // 
            // groupBoxDescriptionVideoGame
            // 
            groupBoxDescriptionVideoGame.Location = new Point(217, 46);
            groupBoxDescriptionVideoGame.Name = "groupBoxDescriptionVideoGame";
            groupBoxDescriptionVideoGame.Size = new Size(755, 385);
            groupBoxDescriptionVideoGame.TabIndex = 2;
            groupBoxDescriptionVideoGame.TabStop = false;
            groupBoxDescriptionVideoGame.Text = "groupBox1";
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
            ResumeLayout(false);
        }

        #endregion

        private Button buttonManageUser;
        private ListBox listBoxVideoGames;
        private GroupBox groupBoxDescriptionVideoGame;
    }
}
