using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaEspongaMocoFusion : MonoBehaviour
{
    public GameObject ArepaEspongaMocoRoachPrefab;
    public GameObject ArepaEspongaMocoUnasPrefab;
    public GameObject ArepaEspongaMocoPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(ArepaEspongaMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(ArepaEspongaMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaMocoUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(ArepaEspongaMocoPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaMocoPelos;
            print(Player.item);
        }
    }
}
