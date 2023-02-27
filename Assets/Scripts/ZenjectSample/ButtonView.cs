using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class ButtonView : MonoBehaviour
{
    [SerializeField] 
    private Button _button;

    [SerializeField] 
    private TextMeshProUGUI text;
    
    public IObservable<string> OnClickObservable()
    {
        return _button.OnClickAsObservable().Select(_ => text.text);
    }
}
