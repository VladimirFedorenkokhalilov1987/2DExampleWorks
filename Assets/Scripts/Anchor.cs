using UnityEngine;
using System.Collections;

public enum ScreenPosition
{
	None,
	UpLeft,
	UpMiddle,
	UpRight,
	MiddleLeft,
	MiddleMiddle,
	MiddleRight,
	BottomLeft,
	BottomMiddle,
	BottomRight
}

public enum CalculationCondition
{
	None,
	OnStart,
	OnUpdate
}

public class Anchor : MonoBehaviour {
	[SerializeField]
	private Vector2 _offset;

	[SerializeField]
	private ScreenPosition _currentScreenPos;

	[SerializeField]
	private CalculationCondition _currentCondition;

	private Vector2 UpLeft
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height));
		}
	}

	private Vector2 UpMiddle
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width/2, Screen.height));
		}
	}

	private Vector2 UpRight
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, Screen.height));
		}
	}

	private Vector2 MiddleLeft
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height/2));
		}
	}

	private Vector2 MiddleMiddle
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width/2, Screen.height/2));
		}
	}

	private Vector2 MiddleRight
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, Screen.height/2));
		}
	}

	private Vector2 BottomLeft
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (0, 0));
		}
	}

	private Vector2 BottomMiddle
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width/2, 0));
		}
	}

	private Vector2 BottomRight
	{
		get
		{ 
			return Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0));
		}
	}

	void Start () 
	{
		if (_currentCondition == CalculationCondition.OnStart) 
		{
			transform.position = GetPosition (_currentScreenPos) +_offset;
		}
	}
	
	void Update () 
	{
		if (_currentCondition == CalculationCondition.OnStart)
			return;
		transform.position = GetPosition (_currentScreenPos) + _offset;
	}

	private Vector2 GetPosition(ScreenPosition position)
	{
		switch (position) {



		case ScreenPosition.UpLeft:
			return UpLeft;
			break;

		case ScreenPosition.UpMiddle:
			return UpMiddle;
			break;

		case ScreenPosition.UpRight:
			return UpRight;
			break;

		case ScreenPosition.MiddleLeft:
			return MiddleLeft;
			break;

		case ScreenPosition.MiddleMiddle:
			return MiddleMiddle;
			break;

		case ScreenPosition.MiddleRight:
			return MiddleRight;
			break;

		case ScreenPosition.BottomLeft:
			return BottomLeft;
			break;

		case ScreenPosition.BottomMiddle:
			return BottomMiddle;
			break;

		case ScreenPosition.BottomRight:
			return BottomRight;
			break;
		
		default:
			return Vector2.zero;
		}


		}

	}