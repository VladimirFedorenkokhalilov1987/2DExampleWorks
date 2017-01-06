using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class PictureChenger : MonoBehaviour {

	[SerializeField]
	private Sprite[] _sprites;

	[SerializeField]
	private SpriteRenderer _renderer;

	private int _currentIndex;

	void OnMouseDown () {
		if (_sprites == null || _sprites.Length==null || _renderer == null)
			return;

		print ("clik");

		_currentIndex++;
		if (_currentIndex >= _sprites.Length)
			_currentIndex = 0;

		_renderer.sprite = _sprites [_currentIndex];
	}
	
	void Update () {
	
	}
}
