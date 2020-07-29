
using UnityEngine;

public class LearnMethodReturn : MonoBehaviour
{
	// 開始事件:播放時執行一次
	private void Start()
    {
		Method();				// 無傳回,不會得到資料

		// 區域變數 [類型 名稱]
		// 僅限於此大括號內使用
		string n = Name();		// 儲存於區域變數
		print(n);

		int a = Number();		// 傳回 會得到傳回類型
		print(a);

		print (Speed());        // 也可以直接使用傳回方式

		print("補血:" + HpAdd(78));
	} 

	// 方法語法 : 
	// 修飾詞 傳回類型 方法名稱(參數) { 程式內容 }
	public void Method()
	{
		print("一般方法");
	}

	public string Name()
	{
		return "UVULarGecko";
	}

	// 公開 傳回整數 + 
	public int Number()
	{
		// 傳回 2125
		return 2125;
	}

    public float Speed()
	{
		return 18.5f;
	}
	
	// 遊戲應用 : 補血後傳回補完的血
	public float HpAdd(float hp)
	{
		hp += 10;
		return hp;
	}
}
