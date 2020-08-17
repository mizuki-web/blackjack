using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer : MonoBehaviour
{
	public GameObject score_object = null;
	public GameObject Q;
	public GameObject seven;
	public GameObject six;
	public GameObject nine;
	public int X = 0;
	// Start is called before the first frame update
	// Update is called once per frame
	void Update()
	{
		int A = Q.GetComponent<VisibleCardCountScript12>().Twelve;
		int B = seven.GetComponent<VisibleCardCountScript7>().PSeven;
		int C = six.GetComponent<VisibleCardCountScript6>().Six;
		int D = nine.GetComponent<VisibleCardCountScript9>().Nine;
		X = A + B + C + D;
		if (X> 0 && X <= 11)
		{
			Text score_text = score_object.GetComponent<Text>();
			score_text.text = "HIt";
		}
		else if (X > 11 && X < 22)
		{
			Text score_text = score_object.GetComponent<Text>();
			score_text.text = "Stick";
		}
		else if (X > 22)
		{
			Text score_text = score_object.GetComponent<Text>();
			score_text.text = "Burst";
		}
		else
		{
			Text score_text = score_object.GetComponent<Text>();
			score_text.text = "none";
		}
	}
}

