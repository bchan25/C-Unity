using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public delegate void ActionClick();
    // Event for objects to subcribe to
    public static event ActionClick onClick;

    public void ButtonClick()
    {
        // If event is not null
        if (onClick != null)
            onClick();
    }
}
