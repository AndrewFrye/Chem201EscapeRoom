using Godot;
using System;

public class SubQuestionContainer : TabContainer
{
    public override void _Ready()
    {
        this.SetTabTitle(0, "Password Input");
        this.SetTabTitle(1, "Question 1");
        this.SetTabTitle(2, "Question 2");
        this.SetTabTitle(3, "Question 3");
        this.SetTabTitle(4, "Question 4");
        this.SetTabTitle(5, "Question 5");
        this.SetTabTitle(6, "Question 6");
        this.SetTabTitle(7, "Question 7");
        this.SetTabTitle(8, "Question 8");
        this.SetTabTitle(9, "Question 9");
        this.SetTabTitle(10, "Question 10");
    }
}
