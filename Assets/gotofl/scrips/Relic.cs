using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic : MonoBehaviour
{
    [SerializeField] GameObject Relic1;
    [SerializeField] GameObject Relic2;
    [SerializeField] GameObject Relic3;

    private void OnTriggerEnter2D(Collider2D collision) { 
    if (collision.gameObject.CompareTag("Relic1"))
        {
            Relic1.SetActive(true);
        }
    if (collision.gameObject.CompareTag("Relic2"))
        {
            Relic2.SetActive(true);
        }
    if (collision.gameObject.CompareTag("Relic3"))
        {
            Relic3.SetActive(true);
        }
    }
    


}

