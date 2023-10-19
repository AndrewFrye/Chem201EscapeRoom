using Godot;

namespace EscapeRoom.Scenes.Common
{
    public class CheckPasswordButton : Button
    {
        [Export] private string PasswordInputNodePath;
        [Export] private string PasswordLabelNodePath;
        [Export] private string NextSceneButtonNodePath;
        [Export] private string Password;
        
        private TextEdit passwordInput { get; set; }
        private Button nextSceneButton { get; set; }

        public override void _Ready()
        {
            passwordInput = GetNode(PasswordInputNodePath) as TextEdit;
            nextSceneButton = GetNode(NextSceneButtonNodePath) as Button;
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

        private void onCorrectInput()
        {
            nextSceneButton.Visible = true;
        }

        private void onIncorrectInput()
        {
            
        }
    }
}