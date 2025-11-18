using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class ProgressTemplate : Panel
{
	[Export] public ColorRect BackgroundColor { get; set; } = null!;
	[Export] public ColorRect MainColor { get; set; } = null!;

	public override void _Ready() { }
	public override void _Process(double delta) { }

}
