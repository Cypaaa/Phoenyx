using Godot;
using System;
using System.Collections.Generic;

public partial class JukeboxTemplate : Panel
{
	[Export] public ColorRect BackgroundColor { get; set; } = null!;
	[Export] public HBoxContainer SpectrumHBox { get; set; } = null!;
	[Export] public Label TitleLabel { get; set; } = null!;
	[Export] public Button UndefinedButton { get; set; } = null!;
	[Export] public TextureButton PauseButton { get; set; } = null!;
	[Export] public TextureButton SkipButton { get; set; } = null!;
	[Export] public TextureButton RewindButton { get; set; } = null!;
	[Export] public ProgressTemplate ProgressPanel { get; set; } = null!;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.UndefinedButton.MouseEntered += () => {
			Tween tween = this.TitleLabel.CreateTween();
			tween.TweenProperty(this.TitleLabel, "modulate", Color.Color8(255, 255, 255), 0.25).SetTrans(Tween.TransitionType.Quad);
			tween.Play();
		};

		this.UndefinedButton.MouseExited += () => {
			Tween tween = this.TitleLabel.CreateTween();
			tween.TweenProperty(this.TitleLabel, "modulate", Color.Color8(194, 194, 194), 0.25).SetTrans(Tween.TransitionType.Quad);
			tween.Play();
		};

		foreach (TextureButton button in new [] {this.PauseButton, this.SkipButton, this.RewindButton})
		{
			button.MouseEntered += () => {
				Tween tween = button.CreateTween();
				tween.TweenProperty(button, "self_modulate", Color.Color8(255, 255, 255), 0.25).SetTrans(Tween.TransitionType.Quad);
				tween.Play();
			};

			button.MouseExited += () => {
				Tween tween = button.CreateTween();
				tween.TweenProperty(button, "self_modulate", Color.Color8(194, 194, 194), 0.25).SetTrans(Tween.TransitionType.Quad);
				tween.Play();
			};
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) { }
}
