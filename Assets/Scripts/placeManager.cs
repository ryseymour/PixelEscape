using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeManager : MonoBehaviour {

	private PickUpManager pickUpManager;
	private InventoryManager inventory;

	// Use this for initialization
	void Start () {
		inventory = GetComponent<InventoryManager> ();
		pickUpManager = GetComponent<PickUpManager> ();
	}
	
	public void PlacedComplete ()
	{
		for (int i = 0; i < inventory.slots.Length; i++) {
		inventory.isFull [i] = false;
			inventory.objects [i] = null;
			//Will need to switch this for a general variable


	}
}

}
