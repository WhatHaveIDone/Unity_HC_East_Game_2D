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
	[Header("剛體2D")]
	public Rigidbody2D ridb;
	[Header("膠囊2D")]
	public CapsuleCollider2D capc;
	[Header("音頻來源")]
	public AudioSource auds;

	#endregion


	#region 方法

	// 繪製圖示事件:繪製輔助線條,只會在 Scene 看得到
	/// <summary> 繪製圖示 </summary>
	private void OnDrawGizmos()
	{
		// 圖示.顏色 = 顏色.紅色
		Gizmos.color = Color.red;
		// 圖示.繪製射線(起點 , 方向);
		// transform			此物件的變形元件
		// transform.position	此物件的座標
		// transform.up			此物件的上方 Y 預設為 1
		// transform.right		此物件的右方 X 預設為 1
		// transform.forward	此物件的前方 Z 預設為 1
		Gizmos.DrawRay(transform.position + new Vector3(-0.05f,-0.0f) , -transform.up*0.8f);
	}

	/// <summary> 移動 </summary>
	public void Move()
	{
		// Time.deltaTime 一偵的時間
		// Update 內 移動/旋轉/運動 * Time.deltaTime 
		// 避免不同裝置執行速度不同
		transform.Translate(speed * Time.deltaTime, 0, 0);	// 變形.位移(x, y, z)
	}

	/// <summary> 跳躍 </summary>
	public void Jump()
	{
		// 布林值 = 輸入.按下按鈕(按鍵列舉.空白鍵)
		bool space = Input.GetKeyDown(KeyCode.Space);

		// 2D 射線碰撞物件 = 2D 物理.射線碰撞(起點,方向,長度,圖層)
		// 圖層語法:1 << 圖層編號
		RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(-0.05f,-0.0f) , -transform.up , 0.01f , 1 << 8);

		// 如果在地板上
		if(hit)
		{
			// 如果 碰到地板 是否在地板上 = 是
			isGround = true;
			// 只跳一次 恢復成跑步動畫
			anim.SetBool("JumpCtrl", false);
		}
		else
		{
			isGround = false;
		}

		if (isGround)
		{
			if (space)
			{
				// 動畫控制器.設定布林值("參數名稱",布林值)
				anim.SetBool("JumpCtrl", true);
				// 剛體.添加推力(二維向量)
				ridb.AddForce(new Vector2(0, jump));
				// 音效來源.播放一次(音效.音量)
				auds.PlayOneShot(sndJump, 0.3f);
			}
		}
	}

	/// <summary> 滑行 </summary>
	public void Slide()
	{
		// 布林值 = 輸入.按下按鈕(按鍵列舉.左控制鍵)
		bool ctrl = Input.GetKeyDown(KeyCode.LeftControl);
		// 動畫控制器.設定布林值("參數名稱",布林值)
		anim.SetBool("SlideCtrl", ctrl);

		// '如果' 按下 '左邊CTRL' 播放一次音效
		// 判斷式如果只有一行可以省略大括號
		if (Input.GetKeyDown(KeyCode.LeftControl)) auds.PlayOneShot(sndSlide, 0.5f);

		// '如果' 按下CTRL 
		if(ctrl)
		{
			// 滑行 位移 -0.1 -1.5 尺寸 1.35 1.35
			capc.offset = new Vector2(-0.1f, -1.5f);
			capc.size = new Vector2(1.35f, 1.35f);
		}
		else
		{
			// ???
		}
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

    void Update()	// 更新,方法沒有放在這就不會動
    {
		Move();
		Jump();
		Slide();
    }
	
	#endregion
}
