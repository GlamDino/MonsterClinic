using Godot;
using System;

public partial class CharachterSpeech : Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        Hide();
    }
    private void _on_dialogue_trigger_pressed()
    {
        Visible = !Visible;
        Text = "AHHHH!! \n MY HEAD HURTSSS!!!";
    }
    private void _on_zoom_into_patient_pressed()
    {
        Visible = !Visible;
        Text = "You are looking at me too closely...\n are you sure this is correct procedure?";
    }
    private void _on_pulse_measurement_pressed()
    {
        Visible = !Visible;
        Text = "Heart Rate: 80bpm";
    }
    private void _on_diagnosis_tools_pressed()
    {
        Visible = !Visible;
        Text = "soooo, you are telling me \n THAT is gonna help you diagnose me??";
    }
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
