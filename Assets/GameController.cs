using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {


	public UnityEngine.UI.Text scoreLabel;
	public GameObject HitLabel;
	public GameObject stickLabel;
	// Use this for initialization
	void Start()
{
		HitLabel.SetActive(false);
		stickLabel.SetActive(false);
	}

// Update is called once per frame
void Update()
{

		int count = GameObject.FindGameObjectsWithTag("Q").Length;

		scoreLabel.text = count.ToString();

		if ((count < 15) && (count > 0))
		{

			HitLabel.SetActive(true);

		}
		if (count > 17)
		{

			stickLabel.SetActive(true);

		}
	}

}
