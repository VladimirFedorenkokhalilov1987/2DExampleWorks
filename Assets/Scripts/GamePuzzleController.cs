using UnityEngine;
using System.Collections;

public class GamePuzzleController : MonoBehaviour {

	[SerializeField]
	private puzzlePartController[] _parts;

	private int _counter;

	void Start () {
		

		if (_parts == null)
			return;

		foreach (var item in _parts) {
			if (item == null)
				continue;

			item.OnTargetEvent+= Item_OnTargetEvent;
		}
			
		}

	private void Item_OnTargetEvent ()
	{
		_counter++;
		if (_counter == _parts.Length) {
			Debug.Log ("You WIN!");
		}

	}

	
void OnDestroy () {
	if (_parts == null)
		return;

	foreach (var item in _parts) {
		if (item == null)
			continue;

		item.OnTargetEvent-= Item_OnTargetEvent;
	}

}
}
