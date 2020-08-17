using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleCardCountScript6 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Six = 0;

	void Update()
	{
		if (isInsideCamera)
		{
			 Six = 6; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Six = 0;// Qが見えなくなったら12だけ数字を減らす。
		}
		
	}
	private void OnBecameInvisible()
	{
		isInsideCamera = false;//　カメラ内から出た
	}
	
	private void OnBecameVisible()
	{
		isInsideCamera = true;//　カメラ内に入った
	}
}
