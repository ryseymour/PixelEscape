using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceScript : MonoBehaviour {
	public GameObject LocationAdd;
	private InventoryManager inventory;
	public GameObject ObjectToPlace;
	public GameObject ObjectInstance;
	private PlacementManager placeManager;

	// Use this for initialization
	void Start () {
		LocationAdd = GameObject.Find("Woodstand");
		placeManager = GameObject.Find("GameManager").GetComponent<PlacementManager> ();
		inventory = GameObject.Find("GameManager").GetComponent<InventoryManager> ();
		//ObjectToPlace = inventory.objects [i]();
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			for (int i = 0; i < inventory.slots.Length; i++) {

				inventory.locations.Add (LocationAdd);
				inventory.objects.Add (ObjectToPlace);
				placeManager.GetComponent<PlacementManager> ().PlacedObject ();
				//ObjectToPlace = inventory.objects [i];
				ObjectInstance = Instantiate (ObjectToPlace, transform.position, transform.rotation);
					//PlaceTransform = LocationAdd.transform;

					//inventory.objects.Add (ObjectToPlace);
					//Instantiate (ObjectToPlace, inventory.locations [i].transform, true);
					//ObjectInstance = Instantiate (ObjectToPlace, transform.position, transform.rotation);
					//ObjectInstance.SetActive (true);
					//inventory.objects [i].GetComponent<PickUp> ().WipeClean ();
					//inventory.objects [i] = null;
					//Inventory.ObjectSet = true;

					//goes to inventory then pickup
					break;
				}
			}

		}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			for (int i = 0; i < inventory.slots.Length; i++) {
				inventory.locations.Remove (LocationAdd);
				//inventory.objects.Remove (ObjectToPlace);
				inventory.LocationAdded [i] = false;
		}
	}
}
		
}
