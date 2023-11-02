using System.Diagnostics;
using Godot;

namespace EscapeRoom.Scenes.Stage1_MultiQuestion_.src
{
    public class SubQuestionCheckPassword : EscapeRoom.Scenes.Common.CheckPasswordButton
    {
        [Export] private string dataGridPath, keyValue;
        [Export] private int keyIndex;

        private VBoxContainer dataGrid;

        public override void _Ready()
        {
            Init();
            
            dataGrid = GetNode(dataGridPath) as VBoxContainer;
        }

        private bool valuesAdded = false;
        protected override void onCorrectInput()
        {
            if (valuesAdded) return;
            
            var indexLabel = new Label();
            indexLabel.Text = (keyIndex + 1).ToString();

            var valueLabel = new Label();
            valueLabel.Text = keyValue;
            
            dataGrid.AddChild(indexLabel);
            dataGrid.AddChild(valueLabel);

            foreach (HBoxContainer childContainer in dataGrid.GetChildren())
            {
                int index = -1;
                int.TryParse(((Label)(childContainer.GetChildren()[0])).Text, out index);
                index--;
                
                if (index >= 0)
                {
                    if (dataGrid.GetChildCount() >= index)
                    {
                        dataGrid.MoveChild(childContainer, index);
                    }
                }
            }
            
            valuesAdded = true;
        }

        protected override void onIncorrectInput()
        {
            throw new System.NotImplementedException();
        }
    }
}