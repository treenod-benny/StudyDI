using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EmailService : MonoBehaviour, IMessageService
{
    public TextMeshProUGUI text;

    public void SendMessage(String msg)
    {
        text.text += msg + "\n";
    }
}
