using UnityEngine;
using System.Collections;
	
public class PanelActivation : MonoBehaviour {
	private GameObject[] panels;
	
	void Start(){
		int panelcount = GameObject.FindGameObjectsWithTag("Panel").Length;
		panels = new GameObject[panelcount];
		for(int i=0; i < panelcount; i++){
			panels[i] = GameObject.Find("Pg"+(i+1).ToString());
			Debug.Log(panels[i].name);
		}
		
		activatedPanel(0);
		
	}
	
	void activatedPanel(int number){
		foreach (GameObject i in panels){
			i.SetActive(false);
			Debug.Log("setting "+i.name+" false");
		}
		panels[number].SetActive(true);
		Debug.Log("setting "+panels[number].name+" true");
	}
	
}
