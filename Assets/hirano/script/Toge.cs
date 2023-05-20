using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toge : MonoBehaviour
{
    [SerializeField]private float _length=1;
    private string enemyTag = "Enemy";
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var amplitude = 2; // 振幅
        var period = 1; // 一往復する周期（秒）
        var t = 4 * amplitude * Time.time / period; // 時間の進行速度を調整
        var value=Mathf.PingPong(t,2*amplitude)-amplitude;
       

        transform.localPosition = new Vector3(0, value, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag==enemyTag)
        {
        Debug.Log("Damage");
        }
    }
}