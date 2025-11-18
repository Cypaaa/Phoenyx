using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class ButtonsTemplate : VBoxContainer
{
    [Export] public Button PlayButton = null!;
    [Export] public Button SettingsButton = null!;
    [Export] public Button ExtrasButton = null!;
    [Export] public Button QuitButton = null!;
}