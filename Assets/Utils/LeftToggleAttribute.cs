//LeftToggleAttributeDrawer by SVerde
//contact@sverdegd.com

using UnityEngine;

public class LeftToggleAttribute : PropertyAttribute
{
    public string labelOverride = string.Empty;

    public LeftToggleAttribute(){
        
    }

    public LeftToggleAttribute(string labelOverride)
    {
        this.labelOverride = labelOverride;
    }
}
