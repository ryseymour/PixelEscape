using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public bool[] isFull;

	public GameObject[] slots;
	//public GameObject[] allPrefabs;
	public List<GameObject> objects = new List<GameObject>();
	public List<GameObject> locations = new List<GameObject>();
	public bool[] LocationAdded;
	public List<GameObject> InventorySprite = new List<GameObject> ();

	public static bool ObjectSet;
	public static bool ActionKeyOne;
	public static bool ActionKeyTwo;
	//public List<GameObject> allObjects = new List<GameObject>();

	private void Start(){
		ObjectSet = false;
		ActionKeyOne = false;
		ActionKeyTwo = false;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			ActionKeyOne = true;
			Debug.Log (ActionKeyOne);
		}

		if (Input.GetKeyUp (KeyCode.E)) {
			ActionKeyOne = false;
			//Debug.Log (ActionKeyOne);
		}
	}


}
