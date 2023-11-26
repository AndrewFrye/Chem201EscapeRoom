using Godot;

namespace EscapeRoom.Scenes.Common
{
    public abstract class MultipleChoiceButton : Button
    {
        [Export] protected bool CorrectResponse { get; set; }

        public override void _Pressed()
        {
            if (CorrectResponse)
            {
                CorrectResponsePressed();
            }
            else
            {
                IncorrectResponsePressed();
            }
        }

        protected abstract void CorrectResponsePressed();
        protected abstract void IncorrectResponsePressed();
    }
}