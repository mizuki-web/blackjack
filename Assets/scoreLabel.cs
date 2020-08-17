using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreLabel : MonoBehaviour
{
	public GameObject score_object = null;
	public int score_num = 0; // スコア変数
	//public int count7 = 0;
	public int Q = 0;
	Renderer targetRenderer;


	void Start()
    {
		targetRenderer = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update()
	{
		if (targetRenderer.isVisible) {
			Q = 12;
		
	}
		else
		{
			// 表示されていない場合の処理
			Q = 0;
		}
		Text score_text = score_object.GetComponent<Text>();
		score_num = Q;
		score_text.text = "total:" + score_num;
	}
}
