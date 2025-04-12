using System;
using Godot;

public partial class MapSelection : Node2D
{
    public override void _Ready()
    {
        VBoxContainer _mapSelector = GetNode<VBoxContainer>("MapSelector");

        _mapSelector.GetNode<Button>("AshenRidge").Pressed += toAshen;
        _mapSelector.GetNode<Button>("ObsidianWastes").Pressed += toObsidian;
        _mapSelector.GetNode<Button>("WitheredMarsh").Pressed += toMarsh;
    }

    private void toAshen()
    {
        GameState.CurrentMap = MapUtils.MapType.AshenRidge;
        GetTree().ChangeSceneToFile("res://scenes/game_scene.tscn");
    }

    private void toObsidian()
    {
        GameState.CurrentMap = MapUtils.MapType.ObsidianWastes;
        GetTree().ChangeSceneToFile("res://scenes/game_scene.tscn");
    }

    private void toMarsh()
    {
        GameState.CurrentMap = MapUtils.MapType.ObsidianWastes;
        GetTree().ChangeSceneToFile("res://scenes/game_scene.tscn");
    }
}
