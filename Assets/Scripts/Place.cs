using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour {
	public GameObject LocationAdd;
	private InventoryManager inventory;
	public GameObject ObjectToReceive;
	public GameObject ObjectInstance;
	private placeManager PlaceManager;

	// Use this for initialization
	void Start () {
		LocationAdd = GameObject.Find("Woodstand");
		inventory = GameObject.Find("GameManager").GetComponent<InventoryManager> ();
		PlaceManager = GameObject.Find("GameManager").GetComponent<placeManager> ();

		ObjectInstance = null;
		ObjectToReceive = null;

		Debug.Log (inventory);
	}

	void OnTriggerStay(Collider other) {
		if (other.CompareTag ("Player")) {
			if (InventoryManager.ActionKeyOne == false) {
			
				for (int i = 0; i < inventory.LocationAdded.Length; i++) {
					if (inventory.LocationAdded [i] == false) {
						if (inventory.isFull [i] == true) {

							inventory.locations.Add (LocationAdd);
							ObjectToReceive = inventory.objects [i];

							Debug.Log (ObjectToReceive);

							ObjectInstance = Instantiate (ObjectToReceive, transform.position, transform.rotation);
							ObjectInstance.SetActive (true);
					
							//inventory.isFull [i] = false;
							inventory.LocationAdded [i] = true;
							PlaceManager.GetComponent<placeManager> ().PlacedComplete ();
							break;

						}
					}
				}
			}
		}
	}


	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			for (int i = 0; i < inventory.slots.Length; i++) {
				inventory.locations.Remove (LocationAdd);
				//PlaceManager.GetComponent<placeManager> ().PlacedComplete ();
				break;
}
		}
	}
}