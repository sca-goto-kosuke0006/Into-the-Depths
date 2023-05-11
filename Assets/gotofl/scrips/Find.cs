using UnityEngine;

public class Find : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("Hit");

			// 0.2秒後に消える
			Destroy(gameObject, 0.01f);
		}
	}

}