using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ClassB : MonoBehaviour
{
	[Inject]
	private DisplayerSignal2 _onClassBDisplayedMB;

	private void Start()
	{
		Debug.Log("I am a ClassB.");
	}

	public void DisplayB()
	{
		Debug.Log("What ClassB displays.");
		_onClassBDisplayedMB.Fire();
	}
}
