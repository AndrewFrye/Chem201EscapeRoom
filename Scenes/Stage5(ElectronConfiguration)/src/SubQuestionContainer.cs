using Godot;
using System;

namespace EscapeRoom.Scenes.Stage5_ElectronConfiguration_.src
{
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
        }
    }
}