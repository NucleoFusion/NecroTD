using Godot;
using System;

//TODO: Add Styling to buttons, maybe have a texture for them. 

public partial class MainMenu : Control
{
	private Button _start;
	private Button _quit;
	private Button _settings;

	public override void _Ready()
	{
		_start = GetTree().CurrentScene.GetNode<Button>("VBoxContainer/Start");
		_quit = GetTree().CurrentScene.GetNode<Button>("VBoxContainer/Quit");
		_settings = GetTree().CurrentScene.GetNode<Button>("VBoxContainer/Settings");

		_start.Pressed += Start;
		_quit.Pressed += Quit;
		_settings.Pressed += Settings;
	}

	public void Start()
	{
		GetTree().ChangeSceneToFile("res://scenes/map_selection.tscn");
	}

	public void Quit()
	{
		GetTree().Quit();
	}
	public void Settings()
	{
		// GetTree().ChangeSceneToFile("res://scenes/settings.tscn");
	}

}
