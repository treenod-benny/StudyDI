using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;


public class Sample : IInitializable, IDisposable
{
    [Inject]
    List<ButtonView> buttons;
    
    [Inject(Id = typeof(IDisposable))]
    List<IDisposable> subscriptions = new List<IDisposable>();

    public void Initialize()
    {
        Debug.Log("Initialize");

        buttons.ForEach(button =>
        {
            subscriptions.Add(button.OnClickObservable().Subscribe(text => OnClick(text)));
        });
    }
    
    public void Dispose()
    {
        subscriptions.ForEach(subscription => subscription.Dispose());
        subscriptions.Clear();

        Debug.Log("Dispose");
    }
    
    void OnClick (string buttonText)
    {
        Debug.Log(buttonText);
    }
}
