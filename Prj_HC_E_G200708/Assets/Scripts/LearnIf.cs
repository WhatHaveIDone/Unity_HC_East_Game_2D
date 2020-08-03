using UnityEngine;

public class LearnIf : MonoBehaviour
{
	// 判斷式 If
	// 判斷 布林值 來決定要執行哪種程式
	// 範例:
	// 判斷 玩家是否死亡 顯示遊戲結束
    void Start()
    {
        // 語法:
		// 如果(布林值){ 程式內容 }
		// 如果布林值等於 true 時才會執行 {} 內容
		if (true)
		{
			print("我是判斷式");
		}
    }

	public bool open;

    void Update()
    {
		// 語法:
		// 否則{ 程式內容 }
		// 當布林值等於 false 時才會執行否則 {} 內容 
		// 否則必須寫在 if 下方,不能單獨使用
		if (open)
		{
			print("FBI OPEN UP !!!");
		}
		else
		{
			print("OK. Let's move.");
		}



    }
}
