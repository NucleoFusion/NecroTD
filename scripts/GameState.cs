using System;
using Godot;
using MapUtils;

public partial class GameState : Node
{
    public static MapType CurrentMap { get; set; } = MapType.NotSelected;
};
