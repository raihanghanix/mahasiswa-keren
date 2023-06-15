using Godot;
using System;

public partial class Scene19Opt3 : Control
{
	int count = 0;
	int selection = 0;

	BG bg;
	Character character;
	Dialog dialog;
	Options options;
	Paramater paramater;
	AnimationPlayer animationPlayer;

	public override void _Ready()
	{
		animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");

		bg = (BG)GD.Load<PackedScene>("res://Scenes/bg.tscn").Instantiate();
		character = (Character)GD.Load<PackedScene>("res://Scenes/character.tscn").Instantiate();
		dialog = (Dialog)GD.Load<PackedScene>("res://Scenes/dialog.tscn").Instantiate();
		options = (Options)GD.Load<PackedScene>("res://Scenes/options.tscn").Instantiate();
		paramater = (Paramater)GD.Load<PackedScene>("res://Scenes/paramater.tscn").Instantiate();

		AddChild(bg);
		AddChild(character);
		AddChild(dialog);
		AddChild(options);
		AddChild(paramater);

		bg.SetBackground($"{MySingleton.backgroundPath}/Layar laptop.png");
		dialog.SetDialogText($"Narator", $"Kamu kembali kekamarmu dan belajar ngoding dengan menonton Youtube.");
		options.HideBoxes();

		count = 0;
	}

	void OnButtonPressed()
	{
		count++;
		if (count == 1)
		{
			if (MySingleton.hasBecomeCommitte)
			{
				GetTree().ChangeSceneToFile($"{MySingleton.scenePath}/scene_20_special.tscn");
			}
			else if (!MySingleton.hasBecomeCommitte)
			{
				GetTree().ChangeSceneToFile($"{MySingleton.scenePath}/scene_21.tscn");
			}
		}
	}
}
