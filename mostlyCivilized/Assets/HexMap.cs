using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

	void Start ()
    {
        GenerateMap();
    }

    public GameObject hexPrefab;

    int numColumns = 20;
    int numRows = 40;

    public Material[] HexMaterials;

    public void GenerateMap()
    {
        for (int column = 0; column < numColumns; column++)
        {
            for (int row = 0; row < numRows; row++)
            {
                //Instantiate a Hex
                Hex h = new Hex(column, row);

                GameObject HexGO = (GameObject)Instantiate(hexPrefab, h.Pos(), Quaternion.identity, this.transform);
                MeshRenderer mr = HexGO.GetComponentInChildren<MeshRenderer>();
                mr.material = HexMaterials[ Random.Range(0, HexMaterials.Length) ];
            }
        }
    }
}
