using UnityEngine;
using System.Collections;


public delegate void OnTargetDelegat();

public class puzzlePartController : MonoBehaviour {

	public event OnTargetDelegat OnTargetEvent;

	private void OnTargetEventHandler()
	{
		if (OnTargetEvent != null)
			OnTargetEvent ();
	}

	[SerializeField]
	private Vector2 _targetPoint;

	private Vector2 _originPos;
	private SpriteRenderer _renderer;
	private SpriteRenderer _Renderer
	{
		get
		{
			if (_renderer == null)
				_renderer = GetComponent<SpriteRenderer> ();
			return _renderer;
		}
	}

	private Vector2 _MousePosInWorld
	{
		get{ 
			return Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}
	}
	private Vector2 _hitOffSet;

	private bool _onTarget;

	void Start () {
		_originPos = transform.position;
	}
	
	void OnMouseDown () 

	{
		if (_onTarget)
			return;

		if (_Renderer != null) {
			_Renderer.sortingOrder = 1;
		}

		_hitOffSet = _MousePosInWorld - (Vector2)transform.position;
	}

	void OnMouseDrag () 
	{
		transform.position = _MousePosInWorld - _hitOffSet;
	}

	void OnMouseUp () 
	{
		if (_onTarget)
			return;

		if (Vector2.Distance (_targetPoint, transform.position) < 1)
		{
			transform.position = _targetPoint;
			_onTarget = true;
			OnTargetEventHandler ();
		}
		else 
		{
			transform.position = _originPos;
		}

		if (_Renderer != null) {
			_Renderer.sortingOrder = 0;
		}
	}
}
