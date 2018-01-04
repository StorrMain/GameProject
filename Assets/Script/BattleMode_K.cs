using UnityEngine;

public class BattleMode_K : MonoBehaviour {

    public int[] TurnProgress = new int[] { 0, 0 };//{現在行動中のエンティティ,ターンの進行度}
    public int TurnFlag = 0;
    public int MovingPlayer = 0;
    public int[] Entry;
    public GameObject SubCam_Data ;
    public GameObject[] Entities;
    private int[] Order;

    void Start ()
    {
        Order = new int[Entry.Length];
        int[] DEX = new int[Entry.Length];
        int minDEX = 100;
        foreach (int i in Entry)
        {
            DEX[i] = GetComponent<Parameters_K>().EntitiesParameter[i, 1];
        }
        for (int j = 0; j < Entry.Length; j++)
        {
            foreach (int i in Entry)
            {
                if (minDEX < DEX[i])
                {
                    minDEX = DEX[i];
                }
            }
            for (int i = 0; i < Entry.Length; i++)
            {
                if (minDEX == DEX[i])
                {
                    Order[j] = i;
                    DEX[i] = 101;
                    break;
                }
            }
        }
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
