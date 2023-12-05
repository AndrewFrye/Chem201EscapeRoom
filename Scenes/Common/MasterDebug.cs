using Godot;

namespace EscapeRoom.Scenes.Common
{
    public class MasterDebug : Node
    {
        public override void _Input(InputEvent @event)
        {
            if (@event.IsActionPressed("1"))
            {
                GetTree().ChangeScene("res://Scenes/Stage1(MultiQuestion)/Stage1.tscn");
            }
            else if (@event.IsActionPressed("2"))
            {
                GetTree().ChangeScene("res://Scenes/Stage2(Titration)/Stage2.tscn");
            }
            else if (@event.IsActionPressed("3"))
            {
                GetTree().ChangeScene("res://Scenes/Stage1(MultiQuestion)/Stage1.tscn");
            }
            else if (@event.IsActionPressed("4"))
            {
                GetTree().ChangeScene("res://Scenes/Stage4(Gases)/Stage4.tscn");
            }
            else if (@event.IsActionPressed("5"))
            {
                GetTree().ChangeScene("res://Scenes/Stage5(ElectronConfiguration)/Stage5.tscn");
            }
            else if (@event.IsActionPressed("6"))
            {
                GetTree().ChangeScene("res://Scenes/Stage6(MolecularGeometry)/Stage6.tscn");
            }
        }
    }
}