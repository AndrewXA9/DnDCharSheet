using UnityEngine;
using System.Collections;

public class DrawerPull : MonoBehaviour {
	
	private int state = 0;
	
	private float inPos;
	private float outPos;
	
	private float offsetX;
	
	void Start() {
		outPos = this.transform.localPosition.x;
		this.transform.localPosition -= Vector3.right*(Screen.width/2f);
		inPos = this.transform.localPosition.x;
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(0) && ((Input.mousePosition.x < 20 && state == 0) || (state == 2))){
			state = 1;
			offsetX = Input.mousePosition.x-this.transform.localPosition.x;
		}
		
		if(state == 1){
			this.transform.localPosition = new Vector3(Mathf.Clamp(Input.mousePosition.x-offsetX,inPos,outPos),this.transform.localPosition.y,this.transform.localPosition.z);
			
			if(Input.GetMouseButtonUp(0)){
				if(Mathf.Abs(this.transform.localPosition.x-inPos) > Mathf.Abs(this.transform.localPosition.x-outPos)){
					state = 2;
					this.transform.localPosition = new Vector3(outPos,this.transform.localPosition.y,this.transform.localPosition.z);
				}
				else{
					state = 0;
					this.transform.localPosition = new Vector3(inPos,this.transform.localPosition.y,this.transform.localPosition.z);
				}
			}
			
		}
		
		
	}
	
	
}
