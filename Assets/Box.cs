using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GM").GetComponent<GM>().GameOver();
    }
}
