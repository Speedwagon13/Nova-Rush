using UnityEngine.UI;
using UnityEngine;

public class IntroScript : MonoBehaviour {

    public Text myText;

	// Use this for initialization
	void Start () {
        myText.text = "3";
	}
	
	// Update is called once per frame
	void Update () {
		 if (Time.time < 3) {
            myText.text = ((int) (4 - Time.time)).ToString();
        } else if (Time.time < 4)
        {
            myText.text = "Mission Start!";
        } else
        {
            myText.text = "";
        }
	}
}
