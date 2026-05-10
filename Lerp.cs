using Godot;
using System;

public partial class Lerp : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	private void _on_computer_pressed()
	{
		GetTree().ChangeSceneToFile("res://Puter.tscn");
	}
    private void _on_diagnosis_pressed()
    {
        GetTree().ChangeSceneToFile("res://bleep.tscn");
    }
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
