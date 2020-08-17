﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
	

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//メインカメラ上のマウスポインタのある位置からrayを飛ばす
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;


		if (Physics.Raycast(ray, out hit, Mathf.Infinity))
		{
			//Rayが当たったオブジェクトの名前と位置情報をログに表示する
			Debug.Log(hit.collider.gameObject.name);
			Debug.Log(hit.collider.gameObject.transform.position);
			if (hit.collider.gameObject.transform.position.y>2.0)
			{
				Debug.Log("d side");
			}
		}

	}

}
