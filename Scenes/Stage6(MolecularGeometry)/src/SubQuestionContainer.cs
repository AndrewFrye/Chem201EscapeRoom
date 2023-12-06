using Godot;
using System;

namespace EscapeRoom.Scenes.Stage6_MolecularGeometry_.src
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
        }
    }
}