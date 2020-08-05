using UnityEngine;

public class Car : MonoBehaviour
{
	/*
	資料 
	品牌 CC數 重量 顏色 速度 是否有天窗

	欄位 field:儲存資料
	欄位語法
	欄位類型 欄位名稱 結束符號
	
	整數	int		: 無小數點之值,ex:1, 64, -1450
	浮點數	float	: 有小數點的值,ex:1.14, 4.86, -23.33
	字串	string	: 文字,ex:Starbust, uvularGecko2125, NMSL@gmail.com
	布林值	bool	: 是 否,ex: true, false
	 */

	// 資料 
	// 品牌 CC數 重量 是否有天窗 速度
	/*
	語法:[屬性名稱(值)]
	標題 Header("標題")
	提示 Tooltip("提示文字")
	範圍 Range(最小值,最大值) - 僅限於數值類型 
	*/

	[Header("品牌")]
	public string brand = " 品牌 ";
	[Header("CC數"),Tooltip(" 汽車的CC數 ")]
	public int cc = 1500;
	[Header("重量"), Range(0,100)]
	public float weight = 20.5f;
	[Header("是否有天窗"), Tooltip(" 打勾代表有,反之亦然 ")]
	public bool window = true;
	[Header("速度"), Range(0, 200)]
	public float speed = 60.5f;

	/*
	類別 成員命名規則
	可:
	1.底線, 例:shirakami_fubuki
	2.數字中間後面, 例:krito1 kirito2 asuna69
	3.中文 (不建議), 例:大社國

	不可:
	1.特殊符號, 例:@#%$*^ 空格
	2.數字開頭, 例:88byebye
	3.保留字, 例:class int bool 
	*/

	// 補充 : UNITY 常用資料類型
	// 顏色 座標 (2 3 4)
	// Color Vector234

	[Header("顏色")]
	public Color Color = Color.red;
	[Header("我的顏色")]
	public Color myColor = new Color(0.5f,0.5f,0.9f);

	public Vector2 posZero = Vector2.zero;
	public Vector2 posOne = Vector2.one;
	public Vector2 myVector2 = new Vector2(0, 1);

	public Vector3 pos3 = new Vector3(3,2,1);
	public Vector3 pos4 = new Vector4(1, 2, 3, 4);

	// 儲存物件 元件
	// 物件 階層()面板內的所有東西
	// 元件 屬性()面板內的粗體字

	

}
