using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StrokesUISystem : MonoBehaviour {

	public Text strokesText;

	public static int position = 0;

	public static int final_position = 0;

	public static bool[] position_check = new bool[9];

	public static int[] strokes = new int[9];

	public static int[] strokes_final = new int[9];

	public void changeScene(string Destination){
		Application.LoadLevel (Destination);
	}

	public void previousScene(string previous){

		Application.LoadLevel (previous);

	}

	void FinalSetStrokes(){

		strokes_final [final_position] = strokes [position];

		strokesText.text = strokes_final [final_position].ToString ();

		position_check [position] = true;
	}

	void SetStrokes ()
	{
		strokesText.text = strokes[position].ToString ();
		Debug.Log (strokes[position]);	
	}


	public void AddStroke()
	{
		++strokes[position];
		SetStrokes ();
	}

	public void RemoveStroke()
	{
		if(strokes[position] > 0)
			strokes[position] = strokes[position] - 1;

		SetStrokes ();
	}
	// Use this for initialization
	void Start () {
		SetStrokes ();
		strokes[0] = 0;
		strokes[1] = 0;
		strokes[2] = 0;
		strokes[3] = 0;
		strokes[4] = 0;
		strokes[5] = 0;
		strokes[6] = 0;
		strokes[7] = 0;

		strokes_final[0] = 0;
		strokes_final[1] = 0;
		strokes_final[2] = 0;
		strokes_final[3] = 0;
		strokes_final[4] = 0;
		strokes_final[5] = 0;
		strokes_final[6] = 0;
		strokes_final[7] = 0;

		position_check [0] = false;
		position_check [1] = false;
		position_check [2] = false;
		position_check [3] = false;
		position_check [4] = false;
		position_check [5] = false;
		position_check [6] = false;
		position_check [7] = false;

	}

	// Update is called once per frame
	void Update () {



	}
}
