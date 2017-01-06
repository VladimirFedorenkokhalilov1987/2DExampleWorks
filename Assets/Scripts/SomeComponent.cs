using UnityEngine;
using System.Collections;

public class SomeComponent : MonoBehaviour {

	private void Awake()
	{
		print ("Helo");
	}

	private void Start()
	{
		print ("Start");
	}

	private void OnEnable()
	{
		print ("OnEnable");

	}

	private void OnDisable()
	{
		print ("OnDisabled");
	}

	private void OnDestroy()
	{
		print ("OnDestroy");
	}
}
