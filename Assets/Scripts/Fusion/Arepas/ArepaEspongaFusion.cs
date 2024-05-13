using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArepaEspongaFusion : MonoBehaviour
{
    public GameObject ArepaEspongaMocoPrefab;
    public GameObject ArepaEspongaCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(ArepaEspongaMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(ArepaEspongaCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.ArepaEspongaCera;
            print(Player.item);
        }
    }

}
