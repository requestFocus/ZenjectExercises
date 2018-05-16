using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DisplayerInstaller : MonoInstaller
{
	public override void InstallBindings()
	{
		Container.Bind<ClassC>().AsSingle().NonLazy();
		Container.Bind<ClassD>().AsSingle();
	}
}
