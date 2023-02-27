using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyPhone : MonoBehaviour
{
    private IMessageService _messageService;
    
    public TMP_InputField inputFieldText;
    
    public void SetMessageService(IMessageService messageService)
    {
        this._messageService = messageService;
    }

    public void UseMessageService()
    {
        _messageService.SendMessage(inputFieldText.text);
        
        inputFieldText.text = "";
    }
}
