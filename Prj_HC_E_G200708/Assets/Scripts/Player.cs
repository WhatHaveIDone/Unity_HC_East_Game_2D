using UnityEngine;

public class Player : MonoBehaviour
{
	#region 欄位
	
	[Header("速度"),Range(0,1000)]
	public float speed = 5;
	[Header("跳越高度"), Range(0,1000)]
	public int jump = 350;
	[Header("生命值"), Range(0,1000)]
	public float hp = 500;

	public bool isGround;
	public int coin;

	[Header("音效區域")]
	public AudioClip sndHit;
	public AudioClip sndSlide;
	public AudioClip sndJump;
	public AudioClip sndCoin;

	[Header("動畫控制器")]
	public Animator anim;
	[Header("Rigidbody")]
	public Rigidbody2D rid;
	[Header("CapsuleCollider")]
	public CapsuleCollider2D cap;
	
	#endregion


	#region 方法

	/// <summary> 移動 </summary>
	public void Move()
	{
		
	}
	/// <summary> 跳躍 </summary>
	public void Jump()
	{
		// 布林值 = 輸入.按下按鈕(按鍵列舉.空白鍵)
		bool space = Input.GetKeyDown(KeyCode.Space);
		// 動畫控制器.設定布林值("參數名稱",布林值)
		anim.SetBool("JumpCtrl", space);
	}
	/// <summary> 滑行 </summary>
	public void Slide()
	{
		// 布林值 = 輸入.按下按鈕(按鍵列舉.左控制鍵)
		bool ctrl = Input.GetKey(KeyCode.LeftControl);
		// 動畫控制器.設定布林值("參數名稱",布林值)
		anim.SetBool("SlideCtrl", ctrl);
	}
	/// <summary> 吃金幣 </summary>
	public void GetCoin()
	{

	}
	/// <summary> 受傷 </summary>
	public void Hurt()
	{

	}
	/// <summary> 死亡 </summary>
	public void Died()
	{
		anim.SetTrigger("DeadTrigger");
	}
	/// <summary> 通關 </summary>
	public void Win()
	{

	}

	#endregion


	#region 事件
	
	void Start()
    {
        
    }

    void Update()
    {
		Jump();
    }
	
	#endregion
}
