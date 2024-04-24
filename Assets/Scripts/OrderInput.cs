using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.GetComponent("Arrastrar") != null)
        {
            Destroy(other);
        }

    }

    public void DestroyFood()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(Player.item);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
