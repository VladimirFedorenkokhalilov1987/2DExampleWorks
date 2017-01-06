using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {
	public float _playerSpeed;
	private float _spawnSpeed = 5.0f;
	public bool _isMove =false;
	public Vector2 _curSavePos;
	// Use this for initialization 
	void Start () {
		_playerSpeed = _spawnSpeed;
	}
	
	// Update is called once per frame
	void Update () {

		if (_playerSpeed % 10 == 0)
			_playerSpeed = 10;

		float _trnsfV = Input.GetAxis ("Vertical") * _playerSpeed * Time.deltaTime;
		float _trnsfH = Input.GetAxis ("Horizontal") * _playerSpeed * Time.deltaTime;

		if (_trnsfH != 0 || _trnsfV != 0)
			_isMove = true;
		else
			_isMove = false;
		if(Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift))
			_playerSpeed +=1f;
			else
			_playerSpeed=_spawnSpeed;


		transform.Translate (new Vector3 (_trnsfH, _trnsfV, 0));
	
	}

	void OnTriggerEnter2D(Collider2D _other)
	{
		if (_other.tag == "SavePoint")
			_curSavePos = transform.position;
		if (_other.tag == "KillPoint")
			transform.position =	_curSavePos;
	}
}
