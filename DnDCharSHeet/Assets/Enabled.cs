using UnityEngine;
using System.Collections;

public class Enabled : MonoBehaviour {

	private int myNumber;
	
	void OnEnable(){
		if(Time.time > 0){
			myNumber = (int)(this.gameObject.name[2]);
			SendMessageUpwards("activatedPanel",myNumber);
		}
	}
	
}
