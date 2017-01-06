using UnityEngine;
using System.Collections;

public class RotationComponent : MonoBehaviour {
	[SerializeField]
	private float _speed;

	private static Transform _mainTransform;



	void OnEnable () {
		if (_mainTransform == null)
			_mainTransform = transform;
	}

	void OnDisable () {
		if (_mainTransform != transform)
			_mainTransform = null;
	}
	

	void LateUpdate () 
	{
		if (_mainTransform == null)
			_mainTransform = transform;

		if (_mainTransform == transform) {
			transform.Rotate (Vector3.forward * _speed * Time.deltaTime);

		} else {
			transform.rotation = _mainTransform.rotation;
		}

	}
}
