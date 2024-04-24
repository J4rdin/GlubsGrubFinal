using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    void Start()
    {
        
    }

    public void GoBread()
    {
        SceneManager.LoadScene("Bread", LoadSceneMode.Additive);
        if (SceneManager.GetSceneByName("Meat").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Meat");
        }
        if (SceneManager.GetSceneByName("ToppingsYSalsas").isLoaded)
        {
            SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        }
        if (Player.item != "0000")
            DestroyFood();
    }
    public void GoMeat()
    {
        SceneManager.LoadScene("Meat", LoadSceneMode.Additive);
        if (SceneManager.GetSceneByName("ToppingsYSalsas").isLoaded)
        {
            SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        }
        if (SceneManager.GetSceneByName("Bread").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Bread");
        }
        if (Player.item != "0000")
            DestroyFood();
    }
    public void GoToppings()
    {
        SceneManager.LoadScene("ToppingsYSalsas", LoadSceneMode.Additive);
        if (SceneManager.GetSceneByName("Bread").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Bread");
        }
        if (SceneManager.GetSceneByName("Meat").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Meat");
        }
        if (Player.item != "0000")
            DestroyFood();
    }

    public void Playgame()
    {
        SceneManager.LoadScene("FoodTruckTopDown");
    }

    public void GoOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void GoPause()
    {
        SceneManager.LoadScene("Pause");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoBackMeat()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Meat");
        //if(Player.item != "0000")
        //    DestroyFood();
    }
    public void GoBackBread()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Bread");
        //    if (Player.item != "0000")
        //        DestroyFood();
    }

    public void GoBackClients()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Clientes");
        //Player.item = "0000";
    }

    public void GoBackToppings()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        //if (Player.item != "0000")
        //    DestroyFood();
    }
    public void DestroyFood()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(Player.item);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
