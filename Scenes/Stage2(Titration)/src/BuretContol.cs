using Godot;
using System;

public class BuretContol : VSlider
{
    private Label flowRateLabel;
    private Label addedVolumeLabel;
    private Sprite flask;
    public float addedVolume, targetVolume, tolerance;
    
    public override void _Ready()
    {
        addedVolumeLabel = GetNode<Label>("root/Control/AddedBaseVolumeLabel");
        flowRateLabel = GetNode<Label>("root/Control/BuretControl/[Debug]BuretFlowRateLabel");
        flask = GetNode<Sprite>("root/Control/TitrationFlask");

        addedVolume = 0f;
        targetVolume = 0f;
        tolerance = 0f;
    }
    
    public override void _Process(float delta)
    {
        //Set the debug label for showing the current flow rate, this will be disabled in the final version
        flowRateLabel.Text = $"{this.Value} mL/s";

        //Add the current flow rate to the 
        addedVolume += (float)this.Value * delta;
        addedVolumeLabel.Text = $"{Math.Round((decimal)addedVolume, 2)} mL";
    }

    public void changeFlaskSprite()
    {
        var variance = addedVolume - targetVolume;

        if (variance < targetVolume - tolerance)
        {
            //Make flask clear
        } 
        else if (variance > targetVolume + variance)
        {
            //Make flask dark pink
        }
        else
        {
            //Make flask faint pink
        }
    }

    private void _on_ResetButton_pressed()
    {
        //Reset the addedd volume and the slider
        addedVolume = 0f;
        this.Value = 0;
    }
}
