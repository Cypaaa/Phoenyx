using Godot;
using System;

public partial class MenusTemplate : Panel
{
	[Export] public MainTemplate MainPanel = null!;
	[Export] public PlayTemplate PlayPanel = null!;
	[Export] public ExtrasTemplate ExtrasPanel = null!;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() { }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) { }
}
