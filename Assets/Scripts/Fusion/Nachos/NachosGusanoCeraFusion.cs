using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosGusanoCeraFusion : MonoBehaviour
{
    public GameObject NachosGusanosCeraRoachPrefab;
    public GameObject NachosGusanosCeraUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachosGusanosCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosGusanosCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachosGusanosCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosGusanosCeraUnas;
            print(Player.item);
        }
    }
}