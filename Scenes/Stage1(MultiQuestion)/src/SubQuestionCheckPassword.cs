using System.Diagnostics;
using Godot;

namespace EscapeRoom.Scenes.Stage1_MultiQuestion_.src
{
    public class SubQuestionCheckPassword : Common.CheckPasswordButton
    {
        [Export] private string dataGridPath, keyValue, key2Value;
        [Export] private int keyIndex, key2Index;

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

            var row = new HBoxContainer();
            row.Alignment = BoxContainer.AlignMode.Center;
            row.AddChild(indexLabel);
            row.AddChild(valueLabel);

            if (key2Value != null)
            {
                var index2Label = new Label();
                index2Label.Text = (key2Index + 1).ToString();

                var value2Label = new Label();
                value2Label.Text = key2Value;

                var row2 = new HBoxContainer();
                row2.Alignment = BoxContainer.AlignMode.Center;
                row2.AddChild(index2Label);
                row2.AddChild(value2Label);

                dataGrid.AddChild(row2);
            }

            dataGrid.AddChild(row);

            foreach (HBoxContainer childContainer in dataGrid.GetChildren())
            {
                var index = -1;
                int.TryParse(((Label)childContainer.GetChildren()[0]).Text, out index);
                index--;

                if (index >= 0)
                    if (dataGrid.GetChildCount() >= index)
                        dataGrid.MoveChild(childContainer, index);
            }

            valuesAdded = true;
        }

        protected override void onIncorrectInput()
        {
            throw new System.NotImplementedException();
        }
    }
}