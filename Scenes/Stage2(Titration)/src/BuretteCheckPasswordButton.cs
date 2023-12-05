using Godot;

namespace EscapeRoom.Scenes.Stage2_Titration_.src
{
    public class BuretteCheckPasswordButton : Common.CheckPasswordButton
    {
        [Export] private string NextScenePopupPath;
        [Export] private string IncorrectResponsePopupPath;

        private WindowDialog IncorrectPopup;
        private WindowDialog NextScenePopup;
        public override void _Ready()
        {
            Init();

            IncorrectPopup = GetNode<WindowDialog>(IncorrectResponsePopupPath);
            NextScenePopup = GetNode<WindowDialog>(NextScenePopupPath);
        }

        protected override void onCorrectInput()
        {
            NextScenePopup.PopupExclusive = true;
            NextScenePopup.PopupCenteredClamped();
        }

        protected override void onIncorrectInput()
        {
            IncorrectPopup.PopupExclusive = true;
            IncorrectPopup.PopupCenteredClamped();
        }
    }
}