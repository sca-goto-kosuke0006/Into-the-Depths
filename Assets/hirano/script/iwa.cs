using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iwa : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("sensor"))
        {

          
            Vector3 iwa =transform.position;
            Vector3 sensor=new Vector3(-2,1,0);
            float step=10.0f*Time.deltaTime;
            transform.position=Vector3.MoveTowards(iwa,sensor,10.0f);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(GetComponent<CircleCollider2D>());
            Destroy(GetComponent<Rigidbody2D>());
            
        
        }
    }
}
