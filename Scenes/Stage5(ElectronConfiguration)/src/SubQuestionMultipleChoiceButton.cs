using Godot;

namespace EscapeRoom.Scenes.Stage5_ElectronConfiguration_.src
{
    public class SubQuestionMultipleChoiceButton : Common.MultipleChoiceButton
    {
        [Export] private string DataGridPath, KeyValue;
        [Export] private int KeyIndex;

        private VBoxContainer DataGrid;

        public override void _Ready()
        {
            DataGrid = GetNode(DataGridPath) as VBoxContainer;
        }

        private bool valuesAdded = false;
        protected override void CorrectResponsePressed()
        {
            if (valuesAdded) return;
            
            var indexLabel = new Label();
            indexLabel.Text = (KeyIndex + 1).ToString();

            var valueLabel = new Label();
            valueLabel.Text = KeyValue;

            var row = new HBoxContainer();
            row.AddChild(indexLabel);
            row.AddChild(valueLabel);
            
            DataGrid.AddChild(row);
            
            foreach (HBoxContainer childContainer in DataGrid.GetChildren())
            {
                int index = -1;
                int.TryParse(((Label)(childContainer.GetChildren()[0])).Text, out index);
                index--;
                
                if (index >= 0)
                {
                    if (DataGrid.GetChildCount() >= index)
                    {
                        DataGrid.MoveChild(childContainer, index);
                    }
                }
            }
            
            valuesAdded = true;
        }

        protected override void IncorrectResponsePressed()
        {
            var popup = new Popup();
            var popupBox = new VBoxContainer();
            popupBox.Alignment = BoxContainer.AlignMode.Center;
            
            var popupHeader = new Label();
            popupHeader.Text = "Incorrect";
            popupBox.AddChild(popupHeader);

            var closePopupButton = new Button();
            closePopupButton.SetScript(ResourceLoader.Load("res://Scenes/Common/ClosePopupButton.cs"));
            closePopupButton.Text = "Try Again";
            popupBox.AddChild(closePopupButton);
            
        }
    }
}