using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class MyZenjectPhone : MonoBehaviour
{
    public TMP_InputField inputFieldText;

    private IMessageService _messageService;
    
    [Inject]
    public void SetMessageService( IMessageService messageService )
    {
        this._messageService = messageService;
    }

    public void UseMessageService()
    {
        _messageService.SendMessage( inputFieldText.text );
        
        inputFieldText.text = "";
    }
}
