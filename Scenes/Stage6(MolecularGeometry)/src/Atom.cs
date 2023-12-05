using Godot;
using System;
using Object = Godot.Object;

namespace EscapeRoom.Scenes.Stage6_MolecularGeometry_.src
{
    public class Atom : Area2D
    {
        [Signal]
        public delegate void AtomSelected();

        private Sprite VfxController;
        private CollisionShape2D Collider;
        
        public int ID { get; set; }
        public bool Selected { get; set; }
        private string SelectedSpritePath = "res://Scenes/Stage6(MolecularGeometry)/resources/Prototypes/BlueCircle.png";
        private string StaticSpritePath = "res://Scenes/Stage6(MolecularGeometry)/resources/Prototypes/BlackCircle.png";
        
        public override void _Ready()
        {
            Init();
        }

        public override void _InputEvent(Object viewport, InputEvent @event, int shapeIdx)
        {
            if (@event.IsActionPressed("LeftClick"))
            {
                EmitSignal("AtomSelected");
            }
            
        }

        public void ChangeSelectedAtom(string AtomID)
        {
            if (Name == AtomID && !Selected)
            {
                    VfxController.Texture = ResourceLoader.Load<Texture>(SelectedSpritePath);
                    Selected = true;
            }
            else if (Selected)
            {
                VfxController.Texture = ResourceLoader.Load<Texture>(StaticSpritePath);
                Selected = false;
            }
        }

        public void Init()
        {
            Name = "Test";
            
            var vfx = new Sprite();
            AddChild(vfx);

            var collider = new CollisionShape2D();
            collider.Shape = new CircleShape2D();
            collider.Scale = new Vector2(3, 3);
            AddChild(collider);

            Position = new Vector2(100, 100);
            
            vfx.Texture = ResourceLoader.Load<Texture>(StaticSpritePath);
            
            Connect("AtomSelected", GetNode<AtomMaster>("%AtomMaster"), "NewAtomSelected");
        }
    }
}