using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoEspongaMocoFusion : MonoBehaviour
{
    public GameObject TacoEspongaMocoRoachPrefab;
    public GameObject TacoEspongaMocoUnasPrefab;
    public GameObject TacoEspongaMocoPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(TacoEspongaMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(TacoEspongaMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaMocoUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(TacoEspongaMocoPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaMocoPelos;
            print(Player.item);
        }
    }
}

