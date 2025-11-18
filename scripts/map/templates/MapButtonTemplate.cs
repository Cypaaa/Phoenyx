using Godot;
using System;

public partial class MapButtonTemplate : Panel
{
	[Export] public Label TitleLabel { get; set; } = null!;
	[Export] public RichTextLabel ExtraLabel { get; set; } = null!;
	[Export] public TextureRect CoverTexture { get; set; } = null!;
	[Export] public TextureRect FavoritedIcon { get; set; } = null!;
    [Export] public ColorRect HoverColor { get; set; } = null!;
    [Export] public Panel HolderPanel { get; set; } = null!;
    [Export] public Panel NormalPanel { get; set; } = null!;
    [Export] public Panel SelectedPanel { get; set; } = null!;
    [Export] public Button MainButton { get; set; } = null!;


    public string Title;
	public string Artist;
	public string Author;
	public int Difficulty;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        this.MainButton.MouseEntered += () => {
            this.HoverColor.Color = Color.FromHtml("#ffffff10");
        };

        this.MainButton.MouseExited += () => {
            this.HoverColor.Color = Color.FromHtml("#ffffff00");
        };
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) { }

    public void Setup(string fileName, string coverFile, string title, string artist, string author, string difficultyName, int difficulty)
    {
        this.Name = fileName;
        this.Title = title;
        this.Artist = artist;
        this.Author = author;
        this.Difficulty = difficulty;
        this.TitleLabel.Text = author != "" ? $"{author} - {title}" : title;
        this.ExtraLabel.Text = $"[color={Phoenyx.Constants.SecondaryDifficultyColours[difficulty].ToHtml(false)}]{difficultyName}[color=808080] - {author}".ReplaceLineEndings("");
        this.CoverTexture.Texture = coverFile != null ? ImageTexture.CreateFromImage(Image.LoadFromFile(coverFile)) : this.CoverTexture.Texture;
    }

}
