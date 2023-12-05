using Godot;
using System;

public class BuretContol : VSlider
{
    private Label flowRateLabel;
    private Label addedVolumeLabel;
    private Sprite flask;
    private float addedVolume;
    [Export] public float targetVolume, tolerance;

    public override void _Ready()
    {
        addedVolumeLabel = GetNode<Label>("%AddedBaseVolumeLabel");
        flowRateLabel = GetNode<Label>("%[Debug]BuretFlowRateLabel");

        flask = GetNode<Sprite>("%Flask");

        addedVolume = 0f;
    }

    public override void _Process(float delta)
    {
        //Set the debug label for showing the current flow rate, this will be disabled in the final version
        flowRateLabel.Text = $"{Math.Round((decimal)Value, 5)} mL/s";

        //Add the current flow rate to the 
        addedVolume += (float)Value * delta;
        addedVolumeLabel.Text = $"{Math.Round((decimal)addedVolume, 2)} mL";
        
        changeFlaskSprite();
    }

    public void changeFlaskSprite()
    {
        var variance = addedVolume - targetVolume;

        if (addedVolume <= targetVolume + tolerance && addedVolume >= targetVolume - tolerance)
        {
            flask.Texture = ResourceLoader.Load<Texture>("res://Scenes/Stage2(Titration)/sprites/SlightlyPinkFlask.png");
        }
        else if (variance < tolerance)
        {
            flask.Texture = ResourceLoader.Load<Texture>("res://Scenes/Stage2(Titration)/sprites/ClearFlask.png");
        }
        else if (variance > tolerance)
        {
            flask.Texture = ResourceLoader.Load<Texture>("res://Scenes/Stage2(Titration)/sprites/VeryPinkFlask.png");
        }
    }

    private void _on_ResetButton_pressed()
    {
        //Reset the added volume and the slider
        addedVolume = 0f;
        Value = 0;
    }
}