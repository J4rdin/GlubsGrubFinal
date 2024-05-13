using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaGusanoFusion: MonoBehaviour
{
    public GameObject ArepaGusanoMocoPrefab;
    public GameObject ArepaGusanoCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(ArepaGusanoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(ArepaGusanoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosCera;
            print(Player.item);
        }
    }

}
