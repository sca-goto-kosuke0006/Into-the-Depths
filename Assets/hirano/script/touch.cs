using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    [SerializeField] private GameObject rightMove;
    [SerializeField] private GameObject leftMove;

    private bool a;
    
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
        if(collider.gameObject.CompareTag("iwa"))
        {
            Move();
            Debug.Log("うごいた");
        }
    }
    private void Move()
    {
        rightMove.transform.Translate(Vector3.right * Time.deltaTime);
        leftMove.transform.Translate(Vector3.left*Time.deltaTime);
    }
}
