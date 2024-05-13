using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatsOnThePan : MonoBehaviour
{
    public static int BreadNum = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "1000")
        {
            BreadNum = 1;
        }
        else if (other.gameObject.tag == "2000")
        {
            BreadNum = 2;
        }
        else if (other.gameObject.tag == "3000")
        {
            BreadNum = 3;
        }
    }
}
