using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpManager : MonoBehaviour {

	private InventoryManager inventory;
	public GameObject SpritePopUp;



	private void Start ()
	{
		inventory = GetComponent<InventoryManager> ();
	}

	public void PickedUpObject (){
		for (int i = 0; i < inventory.slots.Length; i++) {
			if (inventory.isFull [i] == false) {
				inventory.isFull [i] = true;
				SpritePopUp = Instantiate (inventory.InventorySprite[i], inventory.slots[i].transform, false);


				//gameObject.SetActive (false);
				break;
	}
		}
	}

	void Update () {

	}
		

}
