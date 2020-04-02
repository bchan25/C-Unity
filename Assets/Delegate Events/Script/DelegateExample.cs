using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // Delegate like a Varaible that holds serveral Methods

    public delegate void ColorChange(Color newColor);
    public ColorChange onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    private void Start()
    {
        // Assign method and invoking them
        onColorChange = UpdateColor;
        onColorChange(Color.green);

        // Multiple Methods in a Delegate
        onComplete += Task;
        onComplete += TaskTwo;
        onComplete += TaskThree;

        // Remove Task
        onComplete -= Task;

        // Check not null
        if(onComplete != null)
            onComplete();
    }

    // Must match delegate
    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changing color to: " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task Finish");
    }

    public void TaskTwo()
    {
        Debug.Log("Task2 Finish");
    }

    public void TaskThree()
    {
        Debug.Log("Task3 Finish");
    }
}
