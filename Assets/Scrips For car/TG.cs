using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TG : MonoBehaviour
{
    public GameObject Canvas2;
    private void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าวัตถุที่ชนเข้ามาเป็นผู้เล่นหรือไม่
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit the obstacle!");
            
            Canvas2.SetActive(true);
        }
    }
}
