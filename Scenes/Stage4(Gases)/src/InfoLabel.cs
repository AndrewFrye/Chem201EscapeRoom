using Godot;

namespace EscapeRoom.Scenes.Stage4_Gases_.src
{
    public class InfoLabel : RichTextLabel
    {
        public bool LabelVisible
        {
            get { return Visible; }
            set { Visible = value; }
        }

        public int InfoId { get; set; }
    }
}