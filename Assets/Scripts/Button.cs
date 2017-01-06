using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Button : MonoBehaviour {

	[SerializeField]
	private UnityEvent _buttonDelegat;

	[SerializeField]
	private SpriteRenderer _buttonRenderer;

	[SerializeField]
	private Sprite _hoverViev;

	[SerializeField]
	private Sprite _normalViev;

	[SerializeField]
	private Sprite _pressedViev;


	void OnMouseDown () 
	{
		if (_buttonRenderer == null)
			return;
		_buttonRenderer.sprite = _pressedViev;
	}
	
	void OnMouseUp () {
		
	}

	void OnMouseUpAsButton ()
	{
		
		if (_buttonRenderer == null)
			return;
		_buttonRenderer.sprite = _hoverViev;

		if (_buttonDelegat != null) {
			_buttonDelegat.Invoke ();
		}
	}

	void OnMouseOver () 
	{
		print ("Over");	
	}

	void OnMouseEnter () 
	{

		if (_buttonRenderer == null)
			return;
		_buttonRenderer.sprite = _hoverViev;
	}

	void OnMouseExit () 
	{
		if (_buttonRenderer == null)
			return;
		_buttonRenderer.sprite = _normalViev;
	}
}
