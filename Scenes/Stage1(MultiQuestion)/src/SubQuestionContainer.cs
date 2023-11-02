using Godot;
using System;

public class SubQuestionContainer : TabContainer
{
    public override void _Ready()
    {
        this.SetTabTitle(0, "Password Input");
        this.SetTabTitle(1, "Question 1");
    }
}
