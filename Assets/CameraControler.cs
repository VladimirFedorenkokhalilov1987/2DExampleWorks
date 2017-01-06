using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

	[SerializeField]
	private Transform _target;

	[SerializeField, Range (0,.5f), Tooltip("Border offset")]
	private float _borderPersent = .1f;

	private MoveComponent _moveComponent;
	private float _targetHalfWidth;

	private MoveComponent MoveComponent
	{
		get{ 
			if (_moveComponent == null) {
				_moveComponent = gameObject.GetComponent<MoveComponent> ();
			}
			return _moveComponent;
		}
	}

	public Vector2 BottomLeft
	{
		get{ 
			return Camera.main.ScreenToWorldPoint (Vector2.zero);
		}
	}
	public Vector2 UpRight
	{
		get{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, Screen.height));
		}
	}
	public float Width
	{
		get
		{ 
			return UpRight.x - BottomLeft.x;
		}
	}
	public float LeftBorderX
	{
		get{ 
			return BottomLeft.x + Width * _borderPersent;
		}
	}
	public float RightBorderX
	{
		get{ 
			return UpRight.x - Width * _borderPersent;
		}
	}
	// Use this for initialization
	void OnDrawGizmos () {
		Gizmos.color = Color.yellow;
		Gizmos.DrawLine (new Vector2 (LeftBorderX, UpRight.y), new Vector2 (LeftBorderX, BottomLeft.y));
		Gizmos.DrawLine (new Vector2 (RightBorderX, UpRight.y), new Vector2 (RightBorderX, BottomLeft.y));
	}


	private void TargetPositionHandler()
	{
		if (_target == null) {
			Debug.Log ("PPPPP");

			return;
		}
		if ((_target.position.x - _targetHalfWidth) > LeftBorderX && (_target.position.x + _targetHalfWidth) < RightBorderX) {
		
			return;
		}

		if (MoveComponent == null) {
			Debug.Log ("PPPPP");
			return;
		}
		MoveComponent.TargetPosition = _target.position;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
