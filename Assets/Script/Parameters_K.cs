using UnityEngine;

public class Parameters_K : MonoBehaviour {

    public static int[] RangeAction;
    public int[,] EntitiesParameter;
    void Start ()
    {
        RangeAction = new int[] { 1, 1, 1, 10 }; //行動範囲 {こぶし, キック, 組付き, 拳銃}
        EntitiesParameter = new int[,]
        /*{HP, DEX, SAN, こぶし, キック, 組付き, 拳銃, 特殊状態}
         * 特殊状態 
         * 0:なし
         * 1:組付き
         * 2:組付かれ
         * 3:倒れこむ
         * 4:気絶     */
        {
            {10,10,50,50,25,25,20,0},//Player1
            {10,10,50,50,25,25,20,0},//Player2
            {10,10,50,50,25,25,20,0},//Player3
            {10,10,50,50,25,25,20,0},//Player4
            {10,10,50,50,25,25,20,0},//Player5
            {10,10,50,50,25,25,20,0},//Player6
            {10,10,50,50,25,25,20,0},//Enemy1
            {10,10,50,50,25,25,20,0},//Enemy2
            {10,10,50,50,25,25,20,0},//Enemy3
            {10,10,50,50,25,25,20,0} //Enemy4
        };
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
