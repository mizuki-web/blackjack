using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleCardCountScript9 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Nine = 0; // スコア変数

	// Start is called before the first frame update


	// Update is called once per frame
	void Update()
	{
		if (isInsideCamera)
		{
			Nine = 9;
		}
		else
		{
			Nine = 0;
		}
		
	}
	private void OnBecameInvisible()
	{
		isInsideCamera = false;
	}
	//　カメラ内に入った
	private void OnBecameVisible()
	{
		isInsideCamera = true;
	}
}
