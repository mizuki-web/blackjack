using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
	
	[SerializeField] GameObject text;

	void Update()
	{
		int count = GameObject.FindGameObjectsWithTag("Q").Length;

		
		
		if ((count < 15) && (count > 0))
		{

			text.SetActive(true);

		}
	}
}