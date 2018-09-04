using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

	private PickUpManager pickUpManager;
	private InventoryManager inventory;
	public GameObject BoxAdd;
	public  GameObject SpriteBoxAdd;


	private void Start ()
	{
		inventory = GameObject.Find("GameManager").GetComponent<InventoryManager> ();
		pickUpManager = GameObject.Find("GameManager").GetComponent<PickUpManager> ();
		BoxAdd = GameObject.Find("box");
		SpriteBoxAdd = GameObject.Find ("Full_Item");

	}
		
		

	void OnTriggerStay(Collider other) {
		if (other.CompareTag ("Player")) {
			//InventoryManager.ActionKeyTwo = true;
			//Debug.Log (InventoryManager.ActionKeyTwo);
			//Debug.Log (InventoryManager.ActionKeyOne);
			if (InventoryManager.ActionKeyOne == true ) {
			
			
				for (int i = 0; i < inventory.slots.Length; i++) {
					if (inventory.isFull [i] == false) {
			
						inventory.objects.Add (BoxAdd);
						inventory.InventorySprite.Add (SpriteBoxAdd);

						pickUpManager.GetComponent<PickUpManager> ().PickedUpObject ();

						gameObject.SetActive (false);
						break;
					}
				}
			}
		}



				}


}
