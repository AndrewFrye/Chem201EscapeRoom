using System;
using Godot;

namespace EscapeRoom.Scenes.Common
{
    public class PopupControls
    {
        public static void OpenIncorrectResponsePopup()
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