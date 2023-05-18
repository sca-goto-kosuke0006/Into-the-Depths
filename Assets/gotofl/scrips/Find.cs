using UnityEngine;

public class Find : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			// 0.1秒後に消える
			Destroy(gameObject, 0.01f);
		}
	}

}