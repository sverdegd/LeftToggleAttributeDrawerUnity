//LeftToggleAttributeDrawer by SVerde
//contact@sverdegd.com

using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(LeftToggleAttribute))]
public class LeftToggleAttributeDrawer : PropertyDrawer
{

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        position.height = 16;
        if (property.propertyType == SerializedPropertyType.Boolean) {
            LeftToggleAttribute leftToggle = attribute as LeftToggleAttribute;

            if (leftToggle.labelOverride == string.Empty)
                property.boolValue = EditorGUI.ToggleLeft(position, label, property.boolValue);
            else
                property.boolValue = EditorGUI.ToggleLeft(position, leftToggle.labelOverride, property.boolValue);
        }
        else {
            EditorGUI.LabelField(position, label.text, "Use LeftToggle with bool");
        }

    }
}
