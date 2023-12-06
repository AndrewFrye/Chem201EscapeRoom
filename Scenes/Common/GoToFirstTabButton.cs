using Godot;

namespace EscapeRoom.Scenes.Common
{
    public class GoToFirstTabButton : Button
    {
        [Export] private string TabContainerPath { get; set; }

        public override void _Pressed()
        {
            GetNode<TabContainer>("%SubQuestions").CurrentTab = 0;
            GetParent<WindowDialog>().Hide();
        }
    }
}