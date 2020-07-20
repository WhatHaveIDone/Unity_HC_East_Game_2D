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
	// 品牌 CC數 重量 顏色 速度 是否有天窗
	string brand;
	int cc;
	float weight;
	bool window;
	float speed;

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
}
