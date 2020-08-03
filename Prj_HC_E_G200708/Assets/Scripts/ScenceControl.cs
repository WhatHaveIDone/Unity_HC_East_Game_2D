using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceControl : MonoBehaviour
{
	// '方法'要被'按鈕'呼叫需要設為'公開 public'

	/// <summary> 切換場景 </summary>
	public void ChangeScence()
	{
		// 切換場景
		// 場景管理.載入場景(" 場景名稱 ");
		SceneManager.LoadScene("Stage_01");
	}

	/// <summary> 離開遊戲 </summary>
	public void Quit()
	{
		// 關閉遊戲並離開
		// 應用程式.離開
		Application.Quit();
	}

	// 延遲呼叫方法 Invoke( "方法名稱",延遲秒數 )
	/// <summary> 延遲切換場景 </summary>
	public void DelayChangeScence()
	{
		print("延遲一秒");
		Invoke("ChangeScence", 1.0f);
	}

	/// <summary> 延遲離開遊戲 </summary>
	public void DelayQuit()
	{
		Invoke("Quit", 1.0f);
	}

	void Start()
    {
        
    }

    void Update()
    {
        
    }
}
