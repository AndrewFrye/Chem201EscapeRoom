using Godot;
using System;

public class NextSceneButton : Button
{
    [Export] public string nextSceneString = "";

    public override void _Pressed()
    {
        GetTree().ChangeScene(nextSceneString);
    }
}