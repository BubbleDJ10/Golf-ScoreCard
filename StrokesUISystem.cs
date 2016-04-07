using UnityEngine;
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
	public Text strokesText10;
	public Text strokesText11;
	public Text strokesText12;
	public Text strokesText13;
	public Text strokesText14;
	public Text strokesText15;
	public Text strokesText16;
	public Text strokesText17;
	public Text strokesText18;
	public Text P1Totaltext;
	public Text P2Totaltext;

	public static int first = 0;

	public static int position = 1;

	public static int previous_position = 0;

	public static int p1b9_total = 0;

	public static int p2b9_total = 0;

	public static int total = 0;

	//public static bool[] position_check = new bool[9];

	public static int[] strokes = new int[19];

	//public static int[] strokes_final = new int[9];

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

		if (strokes [position+9] > 9)
			strokesText10.fontSize = 60;

		strokesText10.text = strokes [position+9].ToString ();

		if (strokes [position+10] > 9)
			strokesText11.fontSize = 60;

		strokesText11.text = strokes [position+10].ToString ();

		if (strokes [position+11] > 9)
			strokesText12.fontSize = 60;

		strokesText12.text = strokes [position+11].ToString ();

		if (strokes [position+12] > 9)
			strokesText13.fontSize = 60;

		strokesText13.text = strokes [position+12].ToString ();

		if (strokes [position+13] > 9)
			strokesText14.fontSize = 60;

		strokesText14.text = strokes [position+13].ToString ();

		if (strokes [position+14] > 9)
			strokesText15.fontSize = 60;

		strokesText15.text = strokes [position+14].ToString ();

		if (strokes [position+15] > 9)
			strokesText16.fontSize = 60;

		strokesText16.text = strokes [position+15].ToString ();

		if (strokes [position+16] > 9)
			strokesText17.fontSize = 60;

		strokesText17.text = strokes [position+16].ToString ();

		if (strokes [position+17] > 9)
			strokesText18.fontSize = 60;

		strokesText18.text = strokes [position+17].ToString ();

		while (position != 10) {

			total = total + strokes[position];

			++position;
		}

		P1Totaltext.text = total.ToString ();

		total = 0;

		while (position != 19) {

			total = total + strokes[position];

			++position;
		}

		P2Totaltext.text = total.ToString ();

		position = previous_position;

		previous_position = 0;
		//Debug.Log (strokes[position]);	
	}

	public void Back_9(){

		previous_position = position;

		total = 0;

		position = 1;

		while (position != 10) {

			total = total + strokes[position];

			++position;
		}

		p1b9_total = total;

		total = 0;

		while (position != 19) {

			total = total + strokes[position];

			++position;
		}

		p2b9_total = total;

		position = previous_position;

		previous_position = 0;

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

		/*strokes_final[0] = 0;
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
		position_check [7] = false;*/

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
	public void setHole10(){
		position = 10;
	}
	public void setHole11(){
		position = 11;
	}
	public void setHole12(){
		position = 12;
	}
	public void setHole13(){
		position = 13;
	}
	public void setHole14(){
		position = 14;
	}
	public void setHole15(){
		position = 15;
	}
	public void setHole16(){
		position = 16;
	}
	public void setHole17(){
		position = 17;
	}
	public void setHole18(){
		position = 18;
	}

	// Update is called once per frame
	void Update () {



	}
}
