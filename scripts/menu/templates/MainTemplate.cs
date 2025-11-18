using Godot;
using System;

public partial class MainTemplate : Panel
{
	[Export] public TextureRect PeruchorTexture = null!;
	[Export] public Panel NewsPanel = null!;
	[Export] public ButtonsTemplate ButtonsContainer = null!;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() { }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) { }
}
