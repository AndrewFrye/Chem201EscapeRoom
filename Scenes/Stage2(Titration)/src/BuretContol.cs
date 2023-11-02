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
        
#if RELEASE
        flowRateLabel.Visible = false;
#endif
        
        flask = GetNode<Sprite>("%TitrationFlask");

        addedVolume = 0f;
    }
    
    public override void _Process(float delta)
    {
        //Set the debug label for showing the current flow rate, this will be disabled in the final version
        flowRateLabel.Text = $"{Math.Round((decimal)this.Value, 5)} mL/s";

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
        //Reset the added volume and the slider
        addedVolume = 0f;
        this.Value = 0;
    }
}
