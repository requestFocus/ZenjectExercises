using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ClassC
{
	public ClassC(ClassD classD)                        // non-monobehaviour constructor injection
	{
		classD.DisplayDInfo();
	}
	
	public void DisplayCNoDependencies()
	{
		Debug.Log("What ClassC displays without dependencies.");
	}
}

