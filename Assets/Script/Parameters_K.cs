using UnityEngine;

public class Parameters_K : MonoBehaviour {
    public static int[] RangeAction;
    public static int[] HitRate;


    // Use this for initialization
    void Start () {
        RangeAction = new int[] { 1, 1, 1, Player_Movement_K.MoveDistance }; //行動範囲 {こぶし, キック, 組付き, 拳銃}
        HitRate = new int[] { 50, 25, 25, 25 };//成功確率 {こぶし, キック, 組付き, 拳銃}
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
