using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CurrentFoodSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TacoPrefab;
    public GameObject ArepaPrefab;
    public GameObject NachoPrefab;
    public GameObject OjoPrefab;
    public GameObject TacoOjoPrefab;
    public GameObject TacoOjoMocoPrefab;
    public GameObject TacoOjoMocoRoachPrefab;
    public GameObject TacoOjoMocoUnasPrefab;
    public GameObject TacoGusanosPrefab;
    public GameObject TacoGusanosMocoPrefab;
    public GameObject TacoGusanosMocoRoachPrefab;
    public GameObject TacoGusanosMocoUnasPrefab;
    public GameObject TacoGusanosCeraPrefab;
    public GameObject TacoGusanosCeraRoachPrefab;
    public GameObject TacoGusanosCeraUnasPrefab;
    public GameObject TacoOjoCeraPrefab;
    public GameObject TacoOjoCeraRoachPrefab;
    public GameObject TacoOjoCeraUnasPrefab;

    public GameObject TacoEspongaPrefab;
    public GameObject TacoEspongaMocoPrefab;
    public GameObject TacoEspongaMocoRoachPrefab;
    public GameObject TacoEspongaMocoUnasPrefab;
    public GameObject TacoEspongaCeraPrefab;
    public GameObject TacoEspongaCeraRoachPrefab;
    public GameObject TacoEspongaCeraUnasPrefab;

    public GameObject ArepaOjoPrefab;
    public GameObject ArepaOjoMocoPrefab;
    public GameObject ArepaOjoMocoRoachPrefab;
    public GameObject ArepaOjoMocoUnasPrefab;
    public GameObject ArepaOjoCeraPrefab;
    public GameObject ArepaOjoCeraRoachPrefab;
    public GameObject ArepaOjoCeraUnasPrefab;

    public GameObject ArepaGusanosPrefab;
    public GameObject ArepaGusanosMocoPrefab;
    public GameObject ArepaGusanosMocoRoachPrefab;
    public GameObject ArepaGusanosMocoUnasPrefab;
    public GameObject ArepaGusanosCeraPrefab;
    public GameObject ArepaGusanosCeraRoachPrefab;
    public GameObject ArepaGusanosCeraUnasPrefab;

    public GameObject ArepaEspongaPrefab;
    public GameObject ArepaEspongaMocoPrefab;
    public GameObject ArepaEspongaMocoRoachPrefab;
    public GameObject ArepaEspongaMocoUnasPrefab;
    public GameObject ArepaEspongaCeraPrefab;
    public GameObject ArepaEspongaCeraRoachPrefab;
    public GameObject ArepaEspongaCeraUnasPrefab;

    public GameObject NachosOjoPrefab;
    public GameObject NachosOjoMocoPrefab;
    public GameObject NachosOjoMocoRoachPrefab;
    public GameObject NachosOjoMocoUnasPrefab;
    public GameObject NachosOjoCeraPrefab;
    public GameObject NachosOjoCeraRoachPrefab;
    public GameObject NachosOjoCeraUnasPrefab;

    public GameObject NachosGusanosPrefab;
    public GameObject NachosGusanosMocoPrefab;
    public GameObject NachosGusanosMocoRoachPrefab;
    public GameObject NachosGusanosMocoUnasPrefab;
    public GameObject NachosGusanosCeraPrefab;
    public GameObject NachosGusanosCeraRoachPrefab;
    public GameObject NachosGusanosCeraUnasPrefab;

    public GameObject NachosEspongaPrefab;
    public GameObject NachosEspongaMocoPrefab;
    public GameObject NachosEspongaMocoRoachPrefab;
    public GameObject NachosEspongaMocoUnasPrefab;
    public GameObject NachosEspongaCeraPrefab;
    public GameObject NachosEspongaCeraRoachPrefab;
    public GameObject NachosEspongaCeraUnasPrefab;

    void Start()
    {
        if (Player.item == FoodID.PanTaco)
        {
            Instantiate(TacoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.PanArepa)
        {
            Instantiate(ArepaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.PanNacho)
        {
            Instantiate(NachoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.Ojo)
        {
            Instantiate(OjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjo)
        {
            Instantiate(TacoOjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoMoco)
        {
            Instantiate(TacoOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoCera)
        {
            Instantiate(TacoOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoMocoRoach)
        {
            Instantiate(TacoOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoMocoUnas)
        {
            Instantiate(TacoOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoCeraRoach)
        {
            Instantiate(TacoOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoOjoCeraUnas)
        {
            Instantiate(TacoOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanos)
        {
            Instantiate(TacoGusanosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosMoco)
        {
            Instantiate(TacoGusanosMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosCera)
        {
            Instantiate(TacoGusanosCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosMocoRoach)
        {
            Instantiate(TacoGusanosMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosMocoUnas)
        {
            Instantiate(TacoGusanosMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosCeraRoach)
        {
            Instantiate(TacoGusanosCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoGusanosCeraUnas)
        {
            Instantiate(TacoGusanosCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.TacoEsponga)
        {
            Instantiate(TacoEspongaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoEspongaMoco)
        {
            Instantiate(TacoEspongaMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoEspongaMocoRoach)
        {
            Instantiate(TacoEspongaMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoEspongaMocoUnas)
        {
            Instantiate(TacoEspongaMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoEspongaCera)
        {
            Instantiate(TacoEspongaCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoEspongaCeraRoach)
        {
            Instantiate(TacoEspongaCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.TacoEspongaCeraUnas)
        {
            Instantiate(TacoEspongaCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.ArepaOjo)
        {
            Instantiate(ArepaOjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaOjoMoco)
        {
            Instantiate(ArepaOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaOjoMocoRoach)
        {
            Instantiate(ArepaOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaOjoMocoUnas)
        {
            Instantiate(ArepaOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaOjoCera)
        {
            Instantiate(ArepaOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaOjoCeraRoach)
        {
            Instantiate(ArepaOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaOjoCeraUnas)
        {
            Instantiate(ArepaOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.ArepaGusanos)
        {
            Instantiate(ArepaGusanosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaGusanosMoco)
        {
            Instantiate(ArepaGusanosMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaGusanosMocoRoach)
        {
            Instantiate(ArepaGusanosMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaGusanosMocoUnas)
        {
            Instantiate(ArepaGusanosMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaGusanosCera)
        {
            Instantiate(ArepaGusanosCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaGusanosCeraRoach)
        {
            Instantiate(ArepaGusanosCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaGusanosCeraUnas)
        {
            Instantiate(ArepaGusanosCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.ArepaEsponga)
        {
            Instantiate(ArepaEspongaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaEspongaMoco)
        {
            Instantiate(ArepaEspongaMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaEspongaMocoRoach)
        {
            Instantiate(ArepaEspongaMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaEspongaMocoUnas)
        {
            Instantiate(ArepaEspongaMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaEspongaCera)
        {
            Instantiate(ArepaEspongaCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaEspongaCeraRoach)
        {
            Instantiate(ArepaEspongaCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.ArepaEspongaCeraUnas)
        {
            Instantiate(ArepaEspongaCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.NachosOjo)
        {
            Instantiate(NachosOjoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosOjoMoco)
        {
            Instantiate(NachosOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosOjoMocoRoach)
        {
            Instantiate(NachosOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosOjoMocoUnas)
        {
            Instantiate(NachosOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosOjoCera)
        {
            Instantiate(NachosOjoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosOjoCeraRoach)
        {
            Instantiate(NachosOjoCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosOjoCeraUnas)
        {
            Instantiate(NachosOjoCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.NachosGusanos)
        {
            Instantiate(NachosGusanosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosGusanosMoco)
        {
            Instantiate(NachosGusanosMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosGusanosMocoRoach)
        {
            Instantiate(NachosGusanosMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosGusanosMocoUnas)
        {
            Instantiate(NachosGusanosMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosGusanosCera)
        {
            Instantiate(NachosGusanosCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosGusanosCeraRoach)
        {
            Instantiate(NachosGusanosCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosGusanosCeraUnas)
        {
            Instantiate(NachosGusanosCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

        if (Player.item == FoodID.NachosEsponga)
        {
            Instantiate(NachosEspongaPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosEspongaMoco)
        {
            Instantiate(NachosEspongaMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosEspongaMocoRoach)
        {
            Instantiate(NachosEspongaMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosEspongaMocoUnas)
        {
            Instantiate(NachosEspongaMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosEspongaCera)
        {
            Instantiate(NachosEspongaCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosEspongaCeraRoach)
        {
            Instantiate(NachosEspongaCeraRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }
        if (Player.item == FoodID.NachosEspongaCeraUnas)
        {
            Instantiate(NachosEspongaCeraUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}