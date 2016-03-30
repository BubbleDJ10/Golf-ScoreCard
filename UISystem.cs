using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UISystem : MonoBehaviour {

	StrokesSaver strokesstuff;

	public Text strokesText;

	public static int strokes;

	private int check = 0;

	public int strokes2;

	private int holeNumber = 1;

	public void changeScene(string Destination){

		Application.LoadLevel (Destination);
	

	}

	/*public void finalizeStrokes(int strokes3){

		strokes2 = strokes3;

		finalStrokesText.text = strokes.ToString ();
	}*/


	/*public void finalize()
	{
		finalizeStrokes (strokes);
	}*/



	public void previousScene(string previous){

		Application.LoadLevel (previous);

	}

	public void AddStroke()
	{
		++strokes;
		SetStrokes ();
	}

	public void RemoveStroke()
	{
		if(strokes > 0)
		strokes = strokes - 1;

		SetStrokes ();
	}
		
	void Start ()
	{
		Screen.SetResolution (2560, 1440, true);
		strokes = 0;
		SetStrokes ();
	}

	void SetStrokes ()
	{
		strokesText.text = strokes.ToString ();
	}

	void Update ()
	{
		
	}


}
