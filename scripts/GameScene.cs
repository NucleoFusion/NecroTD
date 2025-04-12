using System;
using Godot;

public partial class GameScene : Node2D
{
    public override void _Ready()
    {
        GD.Print(GameState.CurrentMap);
    }
}
