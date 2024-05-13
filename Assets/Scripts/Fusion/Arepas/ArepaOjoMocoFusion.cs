using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaOjoMocoFusion : MonoBehaviour
{
    public GameObject ArepaOjoMocoRoachPrefab;
    public GameObject ArepaOjoMocoUnasPrefab;
    public GameObject ArepaOjoMocoPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(ArepaOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(ArepaOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoMocoUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(ArepaOjoMocoPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoMocoPelos;
            print(Player.item);
        }
    }
}

