using System.Windows.Forms;
using XxMeatKritikxX.App.Model;

namespace XxMeatKritikxX.App.Windows;

/// <summary>
/// Fenêtre principale
/// </summary>
public partial class MainForm : Form
{
    #region Properties

    /// <summary>
    /// Contexte de données
    /// </summary>
    public MeatKritikContext Context { get; set; }

    #endregion

    /// <summary>
    /// Constructeur de la fenêtre pricipale
    /// </summary>
    public MainForm()
    {
        Context = new();
        Context.MockupData();
        InitializeComponent();

        RefreshListBox(listBoxVideoGames, Context.VideoGames, nameof(VideoGame.Title));
        RefreshComboBox(comboBoxGenre, Context.Genres, nameof(Genre.Name));
        RefreshComboBox(comboBoxStudio, Context.Studios, nameof(Studio.Name));
    }

    #region Methods

    /// <summary>
    /// Gestionnaire d'événement de changement de sélection du jeu
    /// </summary>
    /// <param name="sender">composant envoyeur</param>
    /// <param name="e">Arguments</param>
    private void listBoxVideoGames_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxVideoGames.SelectedItem is not null)
        {
            pictureBoxVideoGame.Visible = false;
            VideoGame selectedVideoGame = (VideoGame)listBoxVideoGames.SelectedItem;

            groupBoxDescriptionVideoGame.Text = selectedVideoGame.Title;
            textBoxPrice.Text = selectedVideoGame.Price.ToString();
            dateTimePickerParutionDate.Value = selectedVideoGame.ParutionDate.ToDateTime(new TimeOnly());
            comboBoxGenre.SelectedItem = selectedVideoGame.Genre;
            comboBoxStudio.SelectedItem = selectedVideoGame.Studio;
            labelNote.Text = selectedVideoGame.GetAverageNotation() ?? "Non noté";

            if (!string.IsNullOrWhiteSpace(selectedVideoGame.UrlPicture))
            {
                pictureBoxVideoGame.LoadAsync(selectedVideoGame.UrlPicture);
                pictureBoxVideoGame.Visible = true;
            }
            RefreshListBox(listBoxNotation, selectedVideoGame.VideoGameUsers, nameof(VideoGameUser.FullName));
        }
    }

    /// <summary>
    /// Ouvre la gestion des utilisateurs
    /// </summary>
    /// <param name="sender">controle d'origine</param>
    /// <param name="e">Arguments</param>
    private void buttonManageUser_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        new UserForm(Context).ShowDialog();
        RefreshListBox(listBoxVideoGames, Context.VideoGames, nameof(VideoGame.Title));
        this.Visible = true;
    }

    /// <summary>
    /// Force le rafraichissement manuelle d'une liste
    /// </summary>
    /// <param name="listBox">liste</param>
    /// <param name="source">Source de la liste</param>
    private void RefreshListBox(ListBox listBox, object? source, string displayMember)
    {
        listBox.DataSource = null;
        listBox.DisplayMember = displayMember;
        listBox.DataSource = source;
    }

    /// <summary>
    /// Force le rafraichissement manuelle d'une liste déroulante
    /// </summary>
    /// <param name="listBox">liste</param>
    /// <param name="source">Source de la liste</param>
    private void RefreshComboBox(ComboBox listBox, object? source, string displayMember)
    {
        listBox.DataSource = null;
        listBox.DisplayMember = displayMember;
        listBox.DataSource = source;
    }

    #endregion

}
