using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
	public GameObject score_object = null;
	public GameObject Dscore_object = null;
	public GameObject Q;
	public GameObject seven;
	public GameObject six;
	public GameObject nine;
	//public int A = 0;
	//public int B = 0;
	public int Pcard=0;
	public int Dcard = 0;
	// Start is called before the first frame update
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
		//プレイヤーの手札
		int A = Q.GetComponent<VisibleCardCountScript12>().PTwelve;
		int B = seven.GetComponent<VisibleCardCountScript7>().PSeven;
		int C = six.GetComponent<VisibleCardCountScript6>().Six;
		int D = nine.GetComponent<VisibleCardCountScript9>().Nine;
		Pcard = A + B + C + D;

		//ディーラーの手札
		int DA = Q.GetComponent<VisibleCardCountScript12>().DTwelve;

		Dcard = DA;

		Text score_text = score_object.GetComponent<Text>();
		score_text.text = "Ptotal:" + Pcard;
		Text Dscore_text = Dscore_object.GetComponent<Text>();
		Dscore_text.text = "Dtotal:" + Dcard;
	}
}
