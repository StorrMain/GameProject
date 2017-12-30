using UnityEngine;

public class SubCamera_Movement_K : MonoBehaviour {

    private GameObject MainCam;
    private GameObject SubCam;
    private GameObject Main;
    private GameObject SendName;
    private Vector3 TmpPos;
    private int TurnProgress;
    private int TurnFlag;

    void Start () {
        Main = GameObject.Find("Main");
        MainCam = GameObject.Find("Main Camera");
        SubCam = Main.GetComponent<BattleMode_K>().SubCam_Data;
        TurnProgress = Main.GetComponent<BattleMode_K>().TurnProgress;
        TurnFlag = Main.GetComponent<BattleMode_K>().TurnFlag;
        SubCam.SetActive(false);
    }

    void SetPos ()
    {
        TmpPos = new Vector3(SendName.transform.position.x, SendName.transform.position.y, SendName.transform.position.z);
        SendName.transform.position = TmpPos;
    }
	
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MainCam.activeSelf)
            {
                MainCam.SetActive(false);
                SubCam.SetActive(true);
            }
            else
            {
                SubCam.SetActive(false);
                MainCam.SetActive(true);
            }
        }

        if (TurnProgress == 0)
        {

        }
	}
}
