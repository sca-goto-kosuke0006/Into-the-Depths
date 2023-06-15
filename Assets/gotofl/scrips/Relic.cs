using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Relic : MonoBehaviour
{
    [SerializeField] GameObject Relic1;
    [SerializeField] GameObject Relic2;
    [SerializeField] GameObject Relic3;

    [SerializeField] private Text relicCount;
    private int reliccount = 0;

    private void OnTriggerEnter2D(Collider2D collision) { 
    if (collision.gameObject.CompareTag("Relic1"))
        {
            Relic1.SetActive(true);
            Debug.Log("遺物1を見つけた");
            reliccount += 1;
            relicCount.text = string.Format("Relic:{0:00}", reliccount);

        }
    if (collision.gameObject.CompareTag("Relic2"))
        {
            Relic2.SetActive(true);
            Debug.Log("遺物2を見つけた");
            reliccount += 1;
            relicCount.text = string.Format("Relic:{0:00}", reliccount);
        }
    if (collision.gameObject.CompareTag("Relic3"))
        {
            Relic3.SetActive(true);
            Debug.Log("遺物3を見つけた");
            reliccount += 1;
            relicCount.text = string.Format("Relic::", reliccount);
        }
    }
    


}

