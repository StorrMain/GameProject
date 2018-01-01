using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

    public int StageNo;
    public GameObject TilePrefab;
    public Material Tile_a;
    public Material Tile_b;
    public int[,,] Map = new int[,,] {
        {
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
        },//Map1
        {
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,2,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
            {0,1,0,1,0,1,0,1,0,1 },
            {1,0,1,0,1,0,1,0,1,0 },
        }//Map2
    };
    

    void Start () {
        float xa = 0,ya = 0;
        for (int y=0; y < Map.GetLength(1); y++)
        {
            for (int x=0; x < Map.GetLength(2); x++)
            {
                Vector3 placePosition = new Vector3(xa*10, -0.75f, ya*10);
                Quaternion q = new Quaternion();
                q = Quaternion.identity;
                if (Map[StageNo, y, x] != 2)
                {
                    GameObject block = Instantiate(TilePrefab, placePosition, q);
                    if (Map[StageNo, y, x] == 0)
                    {
                        block.GetComponent<Renderer>().material = Tile_a;
                    }
                    else
                    {
                        block.GetComponent<Renderer>().material = Tile_b;
                    }
                    block.name = "Block_" + x.ToString() + "," + y.ToString();
                    block.transform.parent = transform;
                }
                xa++;
            }
            xa = 0;
            ya++;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
