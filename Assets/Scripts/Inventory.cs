using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour {

	public bool[] isFull;
	public bool[] LocationAdded;
	//public GameObject[] slots;
	//public GameObject[] allPrefabs;
	public List<GameObject> objects = new List<GameObject>();
	public List<GameObject> locations = new List<GameObject>();
	public static bool ObjectSet;
	//public List<GameObject> allObjects = new List<GameObject>();

	private void Start(){
		ObjectSet = false;
	}


}
