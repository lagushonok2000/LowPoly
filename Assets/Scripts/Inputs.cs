using System;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public Action <string> InputKeyBoard1;
    public Action <string> InputKeyBoard2;
    public Action <string> InputKeyBoard3;
    public Action <string> InputKeyBoard4;
    public Action <string> InputKeyBoard5;

    public Action <bool> MouseWheelUp; 

    private string[] _anims = new string[] { "active1", "active2", "active3", "active4", "active5" };

    private void Update()
    {
        InputKeyBoardMethod();
        InputMouse();
    }

    private void InputKeyBoardMethod()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            InputKeyBoard1?.Invoke(_anims[0]);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            InputKeyBoard2?.Invoke(_anims[1]);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            InputKeyBoard3?.Invoke(_anims[2]);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            InputKeyBoard4?.Invoke(_anims[3]);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            InputKeyBoard5?.Invoke(_anims[4]);
        }

    }

    private void InputMouse()
    {
        float mouse = Input.GetAxis("Mouse ScrollWheel");

        if (mouse >= 0.1f)
        {
            MouseWheelUp?.Invoke(true);
        }
        
        else if (mouse <= -0.1)
        {
            MouseWheelUp?.Invoke(false);
        }
    }
}
