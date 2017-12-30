using UnityEngine;

public class Player_Movement_K : MonoBehaviour {
    
    public static int MoveDistance = 9;
    public Material PlayerImage1;
    private float currentx = 0;
    private float currenty = 0;
    private float currentz = 0;
    private float Rcurrentx;
    private GameObject SubCam;
    private GameObject Main;
    private int TurnProgress;
    private int TurnFlag;

    void PositionGet()
    {
        currentx = transform.position.x;
        currenty = transform.position.y;
        currentz = transform.position.z;
    }

    void Start()
    {
        Main = GameObject.Find("Main");
        SubCam = Main.GetComponent<BattleMode_K>().SubCam_Data;
        TurnProgress = Main.GetComponent<BattleMode_K>().TurnProgress;
        TurnFlag = Main.GetComponent<BattleMode_K>().TurnFlag;
        MoveDistance = 800 / (MoveDistance - 1);
    }
       
    void Update () {

        PositionGet();

        

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(currentx + MoveDistance, currenty, currentz);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(currentx - MoveDistance, currenty, currentz);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(currentx, currenty, currentz - MoveDistance);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(currentx, currenty, currentz + MoveDistance);
        }

        PositionGet();

        if (currentx > 400.0f)
        {
            transform.position = new Vector3(400.0f, currenty, currentz);
        }
        
        if (currentx < -400.0f)
        {
            transform.position = new Vector3(-400.0f, currenty, currentz);
        }

        if (currentz > 1600.0f)
        {
            transform.position = new Vector3(currentx, currenty, 1600.0f);
        }

        if (currentz < 800.0f)
        {
            transform.position = new Vector3(currentx, currenty, 800.0f);
        }

        if (SubCam.activeSelf)
        {
            transform.localEulerAngles = new Vector3(90.0f, 180.0f, 36.0f);
        }
        else
        {
            transform.localEulerAngles = new Vector3(90.0f, 180.0f, 0.0f);
        }

        if (TurnFlag == 1)
        {
            TurnFlag = 0;
            TurnProgress++;
        }

        if (TurnProgress == 10)
        {
            TurnProgress = 0;
        }
    }
}
