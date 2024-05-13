using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaOjoCeraFusion : MonoBehaviour
{
    public GameObject ArepaOjoCeraRoachPrefab;
    public GameObject ArepaOjoCeraUnasPrefab;
    public GameObject ArepaOjoCeraPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(ArepaOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(ArepaOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoCeraUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(ArepaOjoCeraPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoMocoPelos;
            print(Player.item);
        }
    }
}

