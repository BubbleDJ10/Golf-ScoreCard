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

	public void changeScene(string Destination){using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StrokesUISystem : MonoBehaviour {

	public Text displayText;
	public Text strokesText1;
	public Text strokesText2;
	public Text strokesText3;
	public Text strokesText4;
	public Text strokesText5;
	public Text strokesText6;
	public Text strokesText7;
	public Text strokesText8;
	public Text strokesText9;
	public Text P1Totaltext;
	public Text P2Totaltext;

	public static int first = 0;

	public static int position = 1;

	public static int previous_position = 0;

	public static int total = 0;

	public static bool[] position_check = new bool[9];

	public static int[] strokes = new int[10];

	public static int[] strokes_final = new int[9];

	public void changeScene(string Destination){
		Application.LoadLevel (Destination);
	}

	public void previousScene(string previous){

		Application.LoadLevel (previous);

	}

	void FinalSetStrokes(){

		//strokes_final [final_position] = strokes [position];

		//strokesText.text = strokes_final [final_position].ToString ();

		//position_check [position] = true;
	}

	void SetStrokes ()
	{
		previous_position = position;

		displayText.text = strokes [position].ToString ();

		total = 0;

		position = 1;
		//if (position == 1)
		if (strokes [position] > 9)
			strokesText1.fontSize = 60;
		
			strokesText1.text = strokes [position].ToString ();
	
		if (strokes [position+1] > 9)
			strokesText2.fontSize = 60;

			strokesText2.text = strokes [position+1].ToString ();

		if (strokes [position+2] > 9)
			strokesText3.fontSize = 60;

			strokesText3.text = strokes [position+2].ToString ();

		if (strokes [position+3] > 9)
			strokesText4.fontSize = 60;

			strokesText4.text = strokes [position+3].ToString ();

		if (strokes [position+4] > 9)
			strokesText5.fontSize = 60;

			strokesText5.text = strokes [position+4].ToString ();

		if (strokes [position+5] > 9)
			strokesText6.fontSize = 60;

			strokesText6.text = strokes [position+5].ToString ();

		if (strokes [position+6] > 9)
			strokesText7.fontSize = 60;

			strokesText7.text = strokes [position+6].ToString ();

		if (strokes [position+7] > 9)
			strokesText8.fontSize = 60;

			strokesText8.text = strokes [position+7].ToString ();

		if (strokes [position+8] > 9)
			strokesText9.fontSize = 60;

			strokesText9.text = strokes [position+8].ToString ();

		while (position != 10) {

			total = total + strokes[position];

			++position;
		}

		P1Totaltext.text = total.ToString ();

		position = previous_position;

		previous_position = 0;
		//Debug.Log (strokes[position]);	
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
		if(first != 1){
			strokes[0] = 0;
			strokes[1] = 0;
			strokes[2] = 0;
			strokes[3] = 0;
			strokes[4] = 0;
			strokes[5] = 0;
			strokes[6] = 0;
			strokes[7] = 0;
			first = 1;
		}

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

	public void setHole1(){
		position = 1;
	}
	public void setHole2(){
		position = 2;
	}
	public void setHole3(){
		position = 3;
	}
	public void setHole4(){
		position = 4;
	}
	public void setHole5(){
		position = 5;
	}
	public void setHole6(){
		position = 6;
	}
	public void setHole7(){
		position = 7;
	}
	public void setHole8(){
		position = 8;
	}
	public void setHole9(){
		position = 9;
	}

	// Update is called once per frame
	void Update () {



	}
}

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
