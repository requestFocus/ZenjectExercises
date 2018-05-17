using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DisplayerInstaller : MonoInstaller
{
	public ClassB ClassB;

	public override void InstallBindings()
	{
		Container.Bind<ClassC>().AsSingle().NonLazy();
		Container.Bind<ClassD>().AsSingle();

		Container.Bind<ClassB>().FromComponentInNewPrefab(ClassB).AsSingle().NonLazy();

		Container.DeclareSignal<DisplayerSignal>();
		Container.DeclareSignal<DisplayerSignal2>();

		Container.BindSignal<DisplayerSignal>().To(() => Debug.Log("Signal fired. DisplayC() was called."));
		Container.BindSignal<DisplayerSignal2>().To(() => Debug.Log("Signal fired. DisplayB() was called."));
	}
}
