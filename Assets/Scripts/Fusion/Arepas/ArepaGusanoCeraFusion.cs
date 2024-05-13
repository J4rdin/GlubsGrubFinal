using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaGusanoCera : MonoBehaviour
{
    public GameObject ArepaGusanoCeraRoachPrefab;
    public GameObject ArepaGusanoCeraUnasPrefab;
    public GameObject ArepaGusanoCeraPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(ArepaGusanoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(ArepaGusanoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosCeraUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(ArepaGusanoCeraPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaGusanosMocoPelos;
            print(Player.item);
        }
    }
}
