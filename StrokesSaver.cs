using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StrokesSaver : MonoBehaviour {

	public Text strokes_to_display;

	//public UISystem strokes_manager;

	private int finalstrokes2;

	public int finalStrokes;

	private int check = 0;

	private int derp = 7;




	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
		/*if(check != 1){

			finalstrokes2 = UISystem.strokes;

			Debug.Log (finalstrokes2);

			strokes_to_display.text = finalstrokes2.ToString();
			++check;
		}*/

		finalstrokes2 = UISystem.strokes;

		Debug.Log (finalstrokes2);

		strokes_to_display.text = finalstrokes2.ToString();

	}

	public void transferStrokes (){

		strokes_to_display.text = finalstrokes2.ToString();
	}

	/*(public void stupid(){

		finalstrokes2 = strokes_manager.strokes2;

		strokes_to_display.text = finalstrokes2.ToString ();
		Debug.Log ("TEST");
	}*/
		
}
