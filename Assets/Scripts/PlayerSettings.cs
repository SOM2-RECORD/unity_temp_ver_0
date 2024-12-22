using UnityEngine;

public enum EControlType{
    mouse,
    keyboardMouse
}

public class PlayerSettings
{
    public static EControlType controlType;

    public static string nickname; // add
}
