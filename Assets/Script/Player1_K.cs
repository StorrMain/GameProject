using UnityEngine;

public class Player1_K : MonoBehaviour {
    
    public Material Player1Image;
    private GameObject Main;
    public GameObject CurrentTile;
    private int TurnProgress;
    private int TurnFlag;
    private float MoveDistance;

    void PositionGet()
    {
        float minDis = 10000f;
        GameObject[] Tiles = GameObject.FindGameObjectsWithTag("Tiles");
        foreach (GameObject Tile in Tiles)
        {
            float dis = Vector3.Distance(transform.position, Tile.transform.position);
            if (minDis < dis)
            {
                CurrentTile = Tile;
                minDis = dis;
            }
        }


    }

    void Start()
    {
        Main = GameObject.Find("Main");
        TurnFlag = Main.GetComponent<BattleMode_K>().TurnFlag;
    }
       
    void Update ()
    {

    }
}
