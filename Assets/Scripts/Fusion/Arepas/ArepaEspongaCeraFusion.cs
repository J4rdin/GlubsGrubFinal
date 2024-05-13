using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaEspongaCeraFusion : MonoBehaviour
{
    public GameObject ArepaEspongaCeraRoachPrefab;
    public GameObject ArepaEspongaCeraUnasPrefab;
    public GameObject ArepaEspongaCeraPelosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(ArepaEspongaCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaCeraRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(ArepaEspongaCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaCeraUnas;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0003")
        {
            Instantiate(ArepaEspongaCeraPelosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaMocoPelos;
            print(Player.item);
        }
    }
}
