using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoEspongaCeraFusion : MonoBehaviour
{
    public GameObject TacoEspongaCeraRoachPrefab;
    public GameObject TacoEspongaCeraUnasPrefab;
    public GameObject TacoEspongaCeraPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(TacoEspongaCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(TacoEspongaCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaCeraUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(TacoEspongaCeraPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaCeraPelos;
            print(Player.item);
        }
    }
}
