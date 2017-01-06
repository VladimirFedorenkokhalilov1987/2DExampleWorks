using UnityEngine;
using System.Collections;
using GameConstants;

public class TrukController : MonoBehaviour {

	[SerializeField]
	private WheelJoint2D[] _whils;

	private float _currSpeed;
	private int _currGear;



	
	// Update is called once per frame
	void LateUpdate () {
		SpeedHandler (Input.GetAxis ("Horizontal"));
	}

	void SpeedHandler (float speedValue) {
		if (_whils == null || _whils.Length < 2)
			return;

		foreach (var item in _whils) {
			if (item == null)
				continue;

			if (!item.useMotor)
				item.useMotor = true;

			var tempMotor = new JointMotor2D ();
			tempMotor = item.motor;

			if (speedValue == 0)
				tempMotor.motorSpeed = 0;
			else
				tempMotor.motorSpeed += TruckConfig.EngineAcceleration * speedValue * Time.deltaTime;
				item.motor = tempMotor;
		}
	}

	private void GearHandler(int currGear)
	{
	}
}
