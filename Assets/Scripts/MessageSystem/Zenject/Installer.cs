using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings() 
    {
        Container.Bind<IMessageService>()
            .To<DMService>()
            .FromComponentsInHierarchy()
            .AsSingle();
    }
}
