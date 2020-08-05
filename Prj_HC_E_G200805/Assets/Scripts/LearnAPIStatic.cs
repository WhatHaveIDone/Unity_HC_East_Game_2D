using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
    // 認識 API 內有靜態 (Static) 關鍵字的成員
    void Start()
    {
		// <[取得]> 靜態屬性 Static Properties
		// ****** 語法:
		// 類別.靜態屬性

		print(Random.value);    // 隨機浮點數		
		print(Mathf.PI);

		// <[設定]> 靜態屬性 Static Properties
		// ****** 語法:
		// 類別.靜態屬性 = 值
		// *$* Read Only 不能設定 (唯獨)
		// 如果設定唯獨屬性會有錯誤
		
		// 時間速度
		Time.timeScale = 0.1f; // 變慢

		// <[使用]> 靜態方法 Static Method
		// ****** 語法:
		// 類別.靜態方法(對應引數)

		// 小數點
		float r = Random.Range(10.1f, 50.5f);
		print(" 在10.1 ~ 50.5間的隨機值: " + r);

		// 整數不包含最大值
		int ri = Random.Range(1, 5);
		print(" 在1 ~ 5間的隨機值: " + ri);

		// 練習 ------

		// 設定滑鼠鼠標可見 = 不可見
		Cursor.visible = false;
		print("滑鼠鼠標已隱藏");

		// 負數取絕對值
		float abs = Mathf.Abs(-9);
		print(" -9的絕對值為: " + abs);
		
		// ------------
	}

	void Update()
    {
		/* print("現在遊戲時間:" + Time.time );	*/

		// 練習 ------

		// 是否按下任意鍵 - 輸入 Input - true/false
		print( " 玩家是否按下任意鍵: " + Input.anyKeyDown);
		
		// ------------
	}
}
