﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public bool isClosed = false;
    public bool isLocked = false;
    Toggle m_Toggle;
    Vector3 closedRotation = new Vector3(0, 0, 0);
    Vector3 openRotation = new Vector3(0, -135, 0);

    // Start is called before the first frame update
    void Start()
    {
        if (isClosed)
        {
            transform.eulerAngles = closedRotation;
        }
        else
        {
            transform.eulerAngles = openRotation;
        }
    }

    public bool Open()
    {
        if (isClosed && !isLocked)
        {
            //Debug.Log("door is now open");
            isClosed = false;
            transform.eulerAngles = openRotation;
            return true;
        }

        //Debug.Log("door was either locked or already open");
        return false;
    }

    public bool Close()
    {
        if (!isClosed)
        {
            //Debug.Log("door is now closed");
            transform.eulerAngles = closedRotation;
            isClosed = true;
        }
        return true;
    }

    public void ToggleValueChanged(Toggle change) {
        if (change)
        {
            transform.eulerAngles = openRotation;
            Open();
            isClosed = true;
        }
        else {
            transform.eulerAngles = closedRotation;
            Close();
            isClosed = false;
        }
        
    }
    public void dooropen(bool tickOn)
    {
        
    }
}
