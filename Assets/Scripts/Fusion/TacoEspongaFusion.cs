using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoEspongaFusion : MonoBehaviour
{
    public GameObject TacoEspongaMocoPrefab;
    public GameObject TacoEspongaCeraPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(TacoEspongaMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaMoco;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0020")
        {
            Instantiate(TacoEspongaCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoEspongaCera;
            print(Player.item);
        }
    }

}
