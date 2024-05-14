using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosOjoFusion : MonoBehaviour
{
    public GameObject NachosOjoMocoPrefab;
    public GameObject NachosOjoCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(NachosOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosOjoMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(NachosOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosOjoCera;
            print(Player.item);
        }
    }

}