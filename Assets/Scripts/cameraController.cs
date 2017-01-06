using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	public Transform _player;
	int _distance = -10;
	float _lift =1.5f;

	float _startSize;

	// Use this for initialization
	void Start () {
		_startSize = this.GetComponent<Camera>().orthographicSize;
	
	}
	
	// Update is called once per frame
	void Update () {
		var targetScript = _player.GetComponent<Player1> ();

		if (targetScript._isMove)
			this.GetComponent<Camera> ().orthographicSize = Mathf.Lerp (this.GetComponent<Camera> ().orthographicSize, _startSize, Time.time * 0.003f);
				else
			this.GetComponent<Camera>().orthographicSize = Mathf.Lerp(this.GetComponent<Camera>().orthographicSize, 10.0f, Time.time*0.01f);

		transform.position = new Vector3 (0, _lift, _distance) + _player.position;
		transform.LookAt (_player);
	}
}
