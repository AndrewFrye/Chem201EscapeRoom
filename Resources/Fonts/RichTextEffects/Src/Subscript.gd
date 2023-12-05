tool
extends RichTextEffect


var bbcode = "subscript"
func _process_custom_fx(char_fx : CharFXTransform):
    char_fx.offset = Vector2(0, char_fx.env.offset_y if char_fx.env.has("offset_y") else 10)
    return true