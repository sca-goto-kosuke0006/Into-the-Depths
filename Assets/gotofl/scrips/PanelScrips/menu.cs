using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用

public class menu : MonoBehaviour
{
	Button Button1;
	Button Button2;
	Button Button3;

	void Start()
	{
		// ボタンコンポーネントの取得
		Button1 = GameObject.Find("ruleButton").GetComponent<Button>();
		Button2 = GameObject.Find("BackButton").GetComponent<Button>();
		Button3 = GameObject.Find("TitelBackButton").GetComponent<Button>();

		// 最初に選択状態にしたいボタンの設定
		Button1.Select();

	}
}