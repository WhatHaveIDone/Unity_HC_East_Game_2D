using UnityEngine;

public class LearnAPI : MonoBehaviour
{
	// 非靜態
	// (1) 實體物件或元件 (Unity 階層面板)
	// (2) 欄位
	public GameObject ball;
	public Transform tra;
	public Transform cube;



    void Start()
    {
		// <[取得]> 非靜態屬性 Properties
		// ****** 語法:
		// 欄位名稱.屬性
		print(ball.layer);

		print(" 球的座標: " + tra.position);

		// <[設定]> 非靜態屬性 Properties
		// ****** 語法:
		// 欄位名稱.屬性 = 值

		// 改變球(?)的尺寸
		tra.localScale = new Vector3(6, 6, 6);

		// 練習 ------



		// -----------
	}

	void Update()
    {
		// <[使用]> 方法 Methofs
		// ****** 語法:
		// 欄位名稱.方法(對應的引數)

		// 旋轉方塊
		cube.Rotate(0, 0, 10);
		// 移動方塊
		cube.Translate(0.1f, 0f ,0f);
	}
}
