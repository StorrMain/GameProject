using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

    public int StageNo;
    public GameObject Tile;
    public GameObject Edge;
    public GameObject Corner1;
    public GameObject Corner2;
    public Material Tile_a;
    public Material Tile_b;
    private Quaternion Angle;
    private GameObject Place;
    private Vector3 PlacePosition;

    public int[,,] Map = new int[,,]
    {
        {
            {6,2,2,2,2,2,2,2,2,2,2,7 },
            {4,0,1,0,1,0,1,0,1,0,1,5 },
            {4,1,0,1,0,1,0,1,0,1,0,5 },
            {4,0,1,0,1,0,1,0,1,0,1,5 },
            {4,1,0,1,0,1,0,1,0,1,0,5 },
            {4,0,1,0,1,0,1,0,1,0,1,5 },
            {4,1,0,1,0,1,0,1,0,1,0,5 },
            {4,0,1,0,1,0,1,0,1,0,1,5 },
            {4,1,0,1,0,1,0,1,0,1,0,5 },
            {4,0,1,0,1,0,1,0,1,0,1,5 },
            {4,1,0,1,0,1,0,1,0,1,0,5 },
            {8,3,3,3,3,3,3,3,3,3,3,9 },
        },//Map1
        {
            {2,2,2,2,2,2,2,2,2,2,2,2 },
            {2,0,1,0,1,0,1,0,1,0,1,2 },
            {2,1,0,1,0,1,0,1,0,1,0,2 },
            {2,0,1,0,1,0,1,0,1,0,1,2 },
            {2,1,0,1,0,1,0,1,0,1,0,2 },
            {2,0,1,0,1,0,1,0,1,0,1,2 },
            {2,1,0,1,0,1,0,1,0,1,0,2 },
            {2,0,1,0,1,0,1,0,1,0,1,2 },
            {2,1,0,1,0,1,0,1,0,1,0,2 },
            {2,0,1,0,1,0,1,0,1,0,1,2 },
            {2,1,0,1,0,1,0,1,0,1,0,2 },
            {2,2,2,2,2,2,2,2,2,2,2,2 },
        }//Map2
    };

    public void CanMove()
    {

    }

    void Start ()
    {
        float xa = 0,ya = 0;
        for (int y=0; y < Map.GetLength(1); y++)
        {
            for (int x=0; x < Map.GetLength(2); x++)
            {

                
                Quaternion q = new Quaternion();
                q = Quaternion.identity;
                switch (Map[StageNo, y, x])
                {
                    case 0://明るいマス
                        PlacePosition = new Vector3(xa * 10, -1.5f, ya * 10);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Tile, PlacePosition, Angle);
                        Place.GetComponent<Renderer>().material = Tile_a;
                        Place.name = "Block_" + (y - 1).ToString() + "," + (x - 1).ToString();
                        Place.transform.parent = transform;
                        Place.tag = "Tiles";
                        break;
                    case 1://暗いマス
                        PlacePosition = new Vector3(xa * 10, -1.5f, ya * 10);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Tile, PlacePosition, Angle);
                        Place.GetComponent<Renderer>().material = Tile_b;
                        Place.name = "Block_" + (y - 1).ToString() + "," + (x - 1).ToString();
                        Place.transform.parent = transform;
                        Place.tag = "Tiles";
                        break;
                    case 2://上底
                        PlacePosition = new Vector3(xa * 10, -0.75f, ya * 10 + 3.125f);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Edge, PlacePosition, Angle);
                        Place.name = "Edge1";
                        Place.transform.parent = transform;
                        break;
                    case 3://下底
                        PlacePosition = new Vector3(xa * 10, -0.75f, ya * 10 - 3.125f);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Edge, PlacePosition, Angle);
                        Place.name = "Edge2";
                        Place.transform.parent = transform;
                        break;
                    case 4://左辺
                        PlacePosition = new Vector3(xa * 10 + 3.125f, -0.75f, ya * 10);
                        Angle = Quaternion.Euler(0, 90, 0);
                        Place = Instantiate(Edge, PlacePosition, Angle);
                        Place.name = "Edge3";
                        Place.transform.parent = transform;
                        break;
                    case 5://右辺
                        PlacePosition = new Vector3(xa * 10 - 3.125f, -0.75f, ya * 10);
                        Angle = Quaternion.Euler(0, 90, 0);
                        Place = Instantiate(Edge, PlacePosition, Angle);
                        Place.name = "Edge4";
                        Place.transform.parent = transform;
                        break;
                    case 6://右上角
                        PlacePosition = new Vector3(xa * 10 + 3.125f, -0.75f, ya * 10 + 3.125f);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Corner1, PlacePosition, Angle);
                        Place.name = "Corner1";
                        Place.transform.parent = transform;
                        break;
                    case 7://左上角
                        PlacePosition = new Vector3(xa * 10 - 3.125f, -0.75f, ya * 10 + 3.125f);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Corner1, PlacePosition, Angle);
                        Place.name = "Corner2";
                        Place.transform.parent = transform;
                        break;
                    case 8://右下角
                        PlacePosition = new Vector3(xa * 10 + 3.125f, -0.75f, ya * 10 - 3.125f);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Corner1, PlacePosition, Angle);
                        Place.name = "Corner3";
                        Place.transform.parent = transform;
                        break;
                    case 9://左下角
                        PlacePosition = new Vector3(xa * 10 - 3.125f, -0.75f, ya * 10 - 3.125f);
                        Angle = Quaternion.Euler(0, 0, 0);
                        Place = Instantiate(Corner1, PlacePosition, Angle);
                        Place.name = "Corner4";
                        Place.transform.parent = transform;
                        break;
                }
                xa++;
            }
            xa = 0;
            ya++;
        }
    }
	
	void Update ()
    {
		
	}
}
