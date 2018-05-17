using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ClassC
{
	private DisplayerSignal _onClassCDisplayedNMB;										// non-monobehaviour signal

	public ClassC(ClassD classD, DisplayerSignal onClassCDisplayed)                        // non-monobehaviour constructor injection
	{
		classD.DisplayDInfo();
		_onClassCDisplayedNMB = onClassCDisplayed;
	}
	
	public void DisplayC()
	{
		Debug.Log("What ClassC displays.");
		_onClassCDisplayedNMB.Fire();
	}
}

