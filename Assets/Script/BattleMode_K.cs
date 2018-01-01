using UnityEngine;

public class BattleMode_K : MonoBehaviour {

    public int[] TurnProgress = new int[] { 0, 0 };//{現在行動中のエンティティ,ターンの進行度}
    public int TurnFlag = 0;
    public int MovingPlayer = 0;
    public static float MoveDistance = 10;
    public GameObject SubCam_Data ;
    public GameObject[] Entities;

    void Start () {
        MoveDistance = 800 / (MoveDistance - 1);
        Entities = new GameObject[] 
            { GameObject.Find("Player1"),GameObject.Find("Player2"),GameObject.Find("Player3"),
              GameObject.Find("Player4"),GameObject.Find("Player5"),GameObject.Find("Player6"),
              GameObject.Find("Enemy1") ,GameObject.Find("Enemy2") ,GameObject.Find("Enemy3") ,
              GameObject.Find("Enemy4")};
    }

    void MovingPhase()
    {

    }

    void AttackPhase()
    {

    }

    void AvoidancePhase()
    {

    }

    void EvacatePhase()
    {

    }

    void Update ()
    {
		
	}
}
