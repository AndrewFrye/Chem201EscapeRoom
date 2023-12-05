using Godot;

namespace EscapeRoom.Scenes.Stage4_Gases_.src
{
    public class InfoButtonBase : Button
    {
        [Export] public string InfoLabelPath { get; set; }
        [Export] public string LabelText { get; set; }
        [Export] public int InfoId { get; set; }
        
        private InfoLabel InfoLabel;
        
        public override void _Ready()
        {
            InfoLabel = GetNode<InfoLabel>(InfoLabelPath);
        }

        public override void _Pressed()
        {
            if (InfoLabel.LabelVisible && InfoLabel.InfoId == InfoId)
            {
                
                    InfoLabel.LabelVisible = false;
                    InfoLabel.InfoId = -1;
                
            }
            else
            {
                InfoLabel.LabelVisible = false;
                InfoLabel.InfoId = InfoId;

                InfoLabel.Text = LabelText;
            }
        }
    }
}