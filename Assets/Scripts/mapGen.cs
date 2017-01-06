using UnityEngine;
using System.Collections;

public class mapGen : MonoBehaviour {
	public Transform _pruj;
	public int _prujCount;
	int _scale;

	private Vector2 _mapSize = new Vector2 (50, 50);
	// Use this for initialization
	void Start () {
		GenMap ();
	}

	void GenMap()
	{
		_prujCount = Random.Range (50, 200);
		for (int i = 0; i < _prujCount; i++) 
		{
			_scale = Random.Range (1, 4);
			_pruj.localScale = new Vector2 (_scale,_scale);
			Instantiate (_pruj, new Vector2 (Random.Range(0, _mapSize.x), Random.Range(0,_mapSize.y)),_pruj.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
