using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspongaFusion : MonoBehaviour
{
    public GameObject TacoEspongaPrefab;
    public GameObject ArepaEspongaPrefab;
    public GameObject NachosEspongaPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "1000")
        {
            Instantiate(TacoEspongaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEsponga;
            print(Player.item);
        }
        else if (other.gameObject.tag == "2000")
        {
            Instantiate(ArepaEspongaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEsponga;
            print(Player.item);
        }
        else if (other.gameObject.tag == "3000")
        {
            Instantiate(NachosEspongaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosEsponga;
            print(Player.item);
        }
    }
}
