using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Displayer : MonoBehaviour
{
	// ============== NON MONOBEHAVIOUR
	// field injection
	[Inject]
	ClassC _classCInjected;

	// property injection
	[Inject]
	ClassC _classCInjectedProperty { get; set; }

	// method injection
	ClassC _classC;												
	[Inject]
	private void ClassCInjectedMethod(ClassC classC)			
	{
		_classC = classC;
	}

	// ============== MONOBEHAVIOUR
	// field injection
	[Inject]
	ClassB _classBInjected;

	// property injection
	[Inject]
	ClassB _classBInjectedProperty { get; set; }

	// method injection
	ClassB _classB;
	[Inject]
	private void ClassBInjectionMethod(ClassB classB)
	{
		_classB = classB;
	}

	//======================

	private void Start()
	{
		//_classC.DisplayC();
		//_classCInjected.DisplayC();
		//_classCInjectedProperty.DisplayC();

		_classBInjected.DisplayB();
		_classBInjectedProperty.DisplayB();
		_classBInjectedProperty.DisplayB();
	}
}
