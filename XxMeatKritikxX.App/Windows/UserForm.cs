using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XxMeatKritikxX.App.Model;

namespace XxMeatKritikxX.App.Windows;

public partial class UserForm : Form
{
    /// <summary>
    /// Contexte de données
    /// </summary>
    public MeatKritikContext Context { get; set; }

    /// <summary>
    /// Jeu sélectionné
    /// </summary>
    public VideoGame? SelectedVideoGame { get; set; }

    /// <summary>
    /// Utilisateur sélectionné
    /// </summary>
    public User? SelectedUser { get; set; }

    /// <summary>
    /// Notation sélectionné
    /// </summary>
    public VideoGameUser? SelectedVideoGameUser { get; set; }

    /// <summary>
    /// Constructeur de formulaire pour la gestion des utilisateurs
    /// </summary>
    /// <param name="context">Contexte de données</param>
    public UserForm(MeatKritikContext context)
    {
        Context = context;
        InitializeComponent();
        RefreshList(listBoxUsers, Context.UserRepository.Read(), nameof(User.Pseudo));

        listBoxVideoGames.DataSource = context.VideoGames;
        listBoxVideoGames.DisplayMember = nameof(VideoGame.Title);
    }

    /// <summary>
    /// Changement de l'utilisateur sélectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e) => ManageNotationVisibility();

    /// <summary>
    /// Changement du jeu sélectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void listBoxVideoGames_SelectedIndexChanged(object sender, EventArgs e) => ManageNotationVisibility();

    /// <summary>
    /// Modification des visibilités
    /// </summary>
    private void ManageNotationVisibility()
    {
        groupBoxNotation.Visible = false;
        buttonAddNotation.Visible = false;
        SelectedVideoGame = listBoxVideoGames.SelectedItem as VideoGame;
        SelectedUser = listBoxUsers.SelectedItem as User;
        VideoGameUser? videoGameUser = SelectedUser?
            .VideoGameUsers
            .FirstOrDefault(vGU => vGU.VideoGame == SelectedVideoGame);
        if (videoGameUser != null)
        {
            groupBoxNotation.Visible = true;
            richTextBoxComment.Text = videoGameUser.Comment;
            numericUpDownNote.Value = videoGameUser.Note;

        }
        else if (SelectedVideoGame != null && SelectedUser != null)
            buttonAddNotation.Visible = true;
        else
            groupBoxNotation.Visible = false;
    }

    /// <summary>
    /// Ajout d'une notation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAddNotation_Click(object sender, EventArgs e)
    {

        if (SelectedUser != null && SelectedVideoGame != null)
        {
            SelectedVideoGameUser = new(SelectedUser, SelectedVideoGame, 0);
            ManageNotationVisibility();
            buttonAddNotation.Visible = false;
        }
    }

    /// <summary>
    /// Valide la notation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonValidate_Click(object sender, EventArgs e)
    {
        if (SelectedVideoGameUser != null)
        {
            if (int.TryParse(numericUpDownNote.Value.ToString(), out int valueInt))
            {
                SelectedVideoGameUser.Note = valueInt;
            }
            else
            {
                MessageBox.Show("Conversion de la note impossible, veuillez saisir un entier de 1 à 10");
                SelectedVideoGameUser.Note = 0;
            }
            SelectedVideoGameUser.Comment = richTextBoxComment.Text;
        }
    }

    /// <summary>
    /// Supprime la notation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (SelectedVideoGame != null && SelectedUser != null && SelectedVideoGameUser != null)
        {
            SelectedVideoGame.VideoGameUsers.Remove(SelectedVideoGameUser);
            SelectedUser.VideoGameUsers.Remove(SelectedVideoGameUser);
            SelectedVideoGameUser = null;
        }

        ManageNotationVisibility();
    }

    /// <summary>
    /// Ferme la fenêtre
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonReturn_Click(object sender, EventArgs e) => this.Close();

    private void buttonAddUser_Click(object sender, EventArgs e)
    {
        Context.UserRepository.Create(new("Encarton"));
        RefreshList(listBoxUsers, Context.UserRepository.Read(), nameof(User.Pseudo));
    }

    private void buttonUpdateUser_Click(object sender, EventArgs e)
    {

    }

    private void buttonDeleteUser_Click(object sender, EventArgs e)
    {
        if (SelectedUser != null)
        {
            Context.UserRepository.Delete(SelectedUser);
            RefreshList(listBoxUsers, Context.UserRepository.Read(), nameof(User.Pseudo));
        }
        else
        {
            MessageBox.Show("Suppression impossible, élément non sélectionné");
        }
    }

    /// <summary>
    /// Rafraichit la liste
    /// </summary>
    /// <param name="listBox"></param>
    /// <param name="source"></param>
    /// <param name="displayMember"></param>
    private void RefreshList(ListBox listBox, object? source, string displayMember)
    {
        listBox.DataSource = null;
        listBox.DataSource = source;
        listBoxUsers.DisplayMember = displayMember;

    }

    private void buttonUpdateUserValidate_Click(object sender, EventArgs e)
    {
        if (SelectedUser != null)
        {
            SelectedUser.Pseudo = textBoxPseudo.Text;
            Context.UserRepository.Update(SelectedUser);
        }

    }
}
