using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosGusanoFusion : MonoBehaviour
{
    public GameObject NachosGusanosMocoPrefab;
    public GameObject NachosGusanosCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(NachosGusanosMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosGusanosMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(NachosGusanosCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosGusanosCera;
            print(Player.item);
        }
    }

}
