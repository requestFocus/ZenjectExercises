using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Displayer : MonoBehaviour
{
	[Inject]
	ClassC _classCInjected;										// field injection

	[Inject]
	ClassC _classCInjectedProperty { get; set; }				// property injection

	ClassC _classC;

	private void Start()
	{
		_classC.DisplayCNoDependencies();
		_classCInjected.DisplayCNoDependencies();
		_classCInjectedProperty.DisplayCNoDependencies();
	}

	[Inject]
	private void ClassCInjectedMethod(ClassC classC)			// method injection
	{
		_classC = classC;
	}
}
