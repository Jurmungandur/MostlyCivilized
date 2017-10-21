using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

	void Start ()
    {
        GenerateMap();
    }

    public GameObject hexPrefab;

    public void GenerateMap()
    {
        for (int column = 0; column < 10; column++)
        {
            for (int row = 0; row < 10; row++)
            {
                //Instantiate a Hex
                Hex h = new Hex(column, row);

                Instantiate(hexPrefab, h.Pos(), Quaternion.identity, this.transform);
            }
        }
    }
}
