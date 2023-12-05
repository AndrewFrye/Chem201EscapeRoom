using Godot;
using System;

namespace EscapeRoom.Scenes.Stage6_MolecularGeometry_.src
{
    public class NewAtomButton : Button
    {
        [Signal]
        public delegate void NewAtomCreated();

        public override void _Ready()
        {
            Connect("NewAtomCreated", GetNode<AtomMaster>("%AtomMaster"), "CreateNewAtom");
        }

        public override void _Pressed()
        {
            EmitSignal("NewAtomCreated");
        }
    }
}