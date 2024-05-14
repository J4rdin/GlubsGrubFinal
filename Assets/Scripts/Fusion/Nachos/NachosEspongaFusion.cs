using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachosEspongaFusion : MonoBehaviour
{
    public GameObject NachosEspongaMocoPrefab;
    public GameObject NachosEspongaCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(NachosEspongaMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosEspongaMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(NachosEspongaCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachosEspongaCera;
            print(Player.item);
        }
    }

}
