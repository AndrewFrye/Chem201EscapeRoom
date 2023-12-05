using Godot;

namespace EscapeRoom.Scenes.Stage4_Gases_.src
{
    public class InfoButtonBase : Button
    {
        [Export] public string PopupPath { get; set; }

        public override void _Pressed()
        {
            var popup = GetNode<WindowDialog>(PopupPath);
            popup.PopupCenteredClamped();
        }
    }
}