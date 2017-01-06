using UnityEngine;
using System.Collections;

public class MoveComponent : MonoBehaviour {

	[SerializeField,Range (.1f,50f)]
	private float _movingSpeed = 1;

	public Vector2 TargetPosition {
		set;
		get;
	}

	private float _movingOffset = .25f;

	private Vector2 MyPosition
	{
		get
		{ 
			return new Vector2 (transform.position.x, transform.position.y);
		}

		set
		{ 
			var tempPos = transform.position;
			tempPos.x = value.x;
			transform.position = tempPos;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector2.Distance (TargetPosition, MyPosition) < _movingOffset) 
		{
			MyPosition = TargetPosition;
			return;
		}
		MyPosition = Vector2.Lerp (MyPosition, TargetPosition, Time.deltaTime * _movingSpeed);
	}
}
