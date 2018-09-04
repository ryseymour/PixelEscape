using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour {

	private InventoryManager inventory;
	public GameObject ObjectInstance;
	public GameObject ObjectToPlace;

	// Use this for initialization
	private void Start () {
		inventory = GetComponent<InventoryManager> ();
	}

	public void PlacedObject (){
		for (int i = 0; i < inventory.slots.Length; i++) {
			if (inventory.LocationAdded [i] == false) {
				inventory.LocationAdded [i] = true;
				ObjectToPlace = inventory.objects [i];
				ObjectInstance = Instantiate (inventory.objects[i], transform.position, transform.rotation);
				ObjectInstance.SetActive (true);
				inventory.objects [i] = null;
				Inventory.ObjectSet = true;
				break;
	}
	
}
	}
}
