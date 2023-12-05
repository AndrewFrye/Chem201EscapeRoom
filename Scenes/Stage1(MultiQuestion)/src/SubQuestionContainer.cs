using Godot;
using System;

namespace EscapeRoom.Scenes.Stage1_MultiQuestion_.src
{
    public class SubQuestionContainer : TabContainer
    {
        public override void _Ready()
        {
            SetTabTitle(0, "Password Input");
            SetTabTitle(1, "Question 1");
            SetTabTitle(2, "Question 2");
            SetTabTitle(3, "Question 3");
            SetTabTitle(4, "Question 4");
            SetTabTitle(5, "Question 5");
            SetTabTitle(6, "Question 6");
            SetTabTitle(7, "Question 7");
            SetTabTitle(8, "Question 8");
            SetTabTitle(9, "Question 9");
            SetTabTitle(10, "Question 10");
        }
    }
}