using UnityEngine;

public class LearnEventMethod : MonoBehaviour
{
	// 事件 : 在特定時間會自動執行
	// 開始 : 在播放遊戲後會自動執行一次,初始化,血量滿 
	// 輸出 print("訊息") - 將訊息輸出到儀表板 - 測試用
	private void Start()
	{
		print("SOD都是真的!!");

		// 語法:方案名稱();
		Test();

		ShootFire();

		// 呼叫有方法時的參數要輸入對應的引數
		Test2(233);
		Test2(2434);

		Shoot("地");
		Shoot("企");
		Shoot("雀");

		// 有預設值的參數可以不填寫
		Drive(666);
		Drive(87,"右方");
		// 多個預設值參數時可以用 參數名稱:指定
		Drive(168, sound: "WRYYYYYY");
	}

	// 更新:一秒執行約60次,持續執行,例如:移動 監聽玩家輸入
	private void Update()
	{
		print("(更新)不要停下來啊!");
	}

	public void Test()
	{
		print("測試");
	}

	// 方法:
	// 語法
	// 修飾詞 傳回類型 方法名稱 () { 程式內容 }
	// 無傳回 void
	// 方法名稱:Unity 習慣會用大寫開頭
	// 事件與方法差異:事件名稱為藍色,方法為白色
	// 事件與方法差異:事件會自動執行,方法不會

	// RPG釋放火球
	public void ShootFire()
	{
		print("火球");
		print("執行動畫");
	}
	public void ShootIce()
	{
		print("冰塊");
		print("執行動畫");
	}
	public void ShootThunder()
	{
		print("閃電");
		print("執行動畫");
	}

	/// <summary> 施放技能 </summary>
	/// <param name="prop"></param>
	public void Shoot(string prop)
	{
		print("施放"+ prop+"球!!");
		print("執行動畫");
	}


	// 參數語法:(參數類型 參數名稱,參數類型 參數名稱......)
	// 參數與欄位相同但不需要修飾詞
	public void Test2(int number)
	{
		print("測試2號,你所輸入的數字為:");
		print(number);
	}

	// 參數預設值:選填式參數
	// 語法:類型 名稱:值
	// 有預設值的參數必須放在最右邊
	public void Drive(int speed,string direction = "前方",string sound = "咻咻")
	{
		print("時數為" + speed + "公里");
		print("開車方向為" + direction);
		print("開車音效:"+ sound);
	}
}
