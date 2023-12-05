using Godot;
using System;
using System.Collections.Generic;

namespace EscapeRoom.Scenes.Stage6_MolecularGeometry_.src
{
    public class AtomMaster : Node2D
    {
        [Signal]
        public delegate void ChangeSelectedAtom(int id);
        
        public override void _Ready()
        {
            
        }

        public void NewAtomSelected()
        {
            EmitSignal("ChangeSelectedAtom");
        }

        public List<Atom> Atoms;
        public void CreateNewAtom()
        {
            var atom = new Atom();
            AddChild(atom);
            Connect("ChangeSelectedAtom", atom, "ChangeSelectedAtom");
        }
    }
}