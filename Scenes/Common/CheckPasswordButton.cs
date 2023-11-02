using Godot;

namespace EscapeRoom.Scenes.Common
{
    public abstract class CheckPasswordButton : Button
    {
        [Export] protected string PasswordInputNodePath;
        [Export] protected string Password;
        
        protected TextEdit passwordInput { get; set; }

        protected void Init()
        {
            passwordInput = GetNode(PasswordInputNodePath) as TextEdit;
        }

        public override void _Pressed()
        {
            if (passwordInput.Text == Password)
            {
                onCorrectInput();
            }
            else
            {
                onIncorrectInput();
            }
        }

        protected abstract void onCorrectInput();

        protected abstract void onIncorrectInput();
    }
}