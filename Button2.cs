using Godot;
using System;

public class Button2 : Button
{
    
    public override void _Pressed()
    {
        var textBox = (Label)GetNode("/root/Control/Label");

        textBox.Text = "hi2";  
    }
}
