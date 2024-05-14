using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosEspongaMocoFusion : MonoBehaviour
{
    public GameObject NachosEspongaMocoRoachPrefab;
    public GameObject NachosEspongaMocoUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachosEspongaMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosEspongaMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachosEspongaMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosEspongaMocoUnas;
            print(Player.item);
        }
    }
}
