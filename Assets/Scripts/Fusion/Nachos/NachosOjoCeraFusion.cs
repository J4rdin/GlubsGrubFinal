using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosOjoCeraFusion : MonoBehaviour
{
    public GameObject NachosOjoCeraRoachPrefab;
    public GameObject NachosOjoCeraUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachosOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosOjoCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachosOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosOjoCeraUnas;
            print(Player.item);
        }
    }
}
