using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaOjoFusion : MonoBehaviour
{
    public GameObject ArepaOjoMocoPrefab;
    public GameObject ArepaOjoCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(ArepaOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(ArepaOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaOjoCera;
            print(Player.item);
        }
    }

}
