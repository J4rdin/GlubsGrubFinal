using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaGusanoMoco : MonoBehaviour
{
    public GameObject ArepaGusanoMocoRoachPrefab;
    public GameObject ArepaGusanoMocoUnasPrefab;
    public GameObject ArepaGusanoMocoPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(ArepaGusanoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(ArepaGusanoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosMocoUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(ArepaGusanoMocoPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosMocoPelos;
            print(Player.item);
        }
    }
}