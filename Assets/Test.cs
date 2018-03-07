using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	// int型の変数mpを宣言し、53で初期化してください
	private int mp = 53;    // 魔法力

	// mpを消費して魔法攻撃をするMagic関数を作ってください
	// Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
	// 魔法攻撃用の関数
	public void Magic(int usemp) { 
		if (this.mp >= usemp) 
		{
			Debug.Log("「魔法攻撃をした。残りMPは" + (this.mp - usemp).ToString() +  "。」");
		} 
		else
		{
			Debug.Log("「MPが足りないため魔法が使えない。」");
		}

		// 残りhpを減らす
		this.mp -= usemp;
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// int型配列　要素数5つ　初期化
		int[] points = new int[5];

		// 配列の各要素に値を設定
		points [0] = 256;
		points [1] = 1000;
		points [2] = 1;
		points [3] = 12345;
		points [4] = 55;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

		// 配列の要素をすべて逆から表示する
		for (int j = 4; j >= 0; j--) {
			Debug.Log (points [j]);
		}



		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 魔法攻撃用の関数を10回呼び出す
		for (int k = 0; k <= 10; k++) {
			lastboss.Magic(5);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
