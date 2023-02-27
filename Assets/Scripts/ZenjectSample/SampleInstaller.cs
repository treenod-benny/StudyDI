using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SampleInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ButtonView>().FromComponentsInHierarchy().AsSingle();

        Container.Bind(typeof(IInitializable), typeof(IDisposable)).To<Sample>().AsSingle();
    }
}
