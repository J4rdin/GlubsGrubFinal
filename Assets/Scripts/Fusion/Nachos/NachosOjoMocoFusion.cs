using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosOjoMocoFusion : MonoBehaviour
{
    public GameObject NachosOjoMocoRoachPrefab;
    public GameObject NachosOjoMocoUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachosOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosOjoMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachosOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosOjoMocoUnas;
            print(Player.item);
        }
    }
}