using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosGusanoMocoFusion : MonoBehaviour
{
    public GameObject NachosGusanosMocoRoachPrefab;
    public GameObject NachosGusanosMocoUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachosGusanosMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosGusanosMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachosGusanosMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosGusanosMocoUnas;
            print(Player.item);
        }
    }
}
