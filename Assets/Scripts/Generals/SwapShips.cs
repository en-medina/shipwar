using UnityEngine;
using System.Collections;

public class SwapShips : MonoBehaviour {

    private GameObject[] IDsaver;
    private int PositionCounter;
    private Vector3[] Positions;
    private bool StartMoving;
	// Use this for initialization
	void Awake () 
    {
        StartMoving = false;
        PositionCounter = 0;
        Positions = new Vector3[2];
        IDsaver = new GameObject[2];
        ReloadSaver();	
	}
	
	// Update is called once per frame
	void FixedUpdate() 
    {
	    if(StartMoving)
        {
            for (int i = 0; i < 2; i++)
                IDsaver[i].transform.position = Vector3.MoveTowards(IDsaver[i].transform.position, Positions[1-i], 1f);
            if(IDsaver[0].transform.position == Positions[1])
                ReloadSaver();	
        }
	}

    void ReloadSaver()
    {
        StartMoving = false;
        for (int i = 0; i < 2; i++)
            IDsaver[i] = null;
        PositionCounter = 0;
    }
    public void IsTimeToSwap(GameObject Ship)
    {
        if (!StartMoving)
        {
            IDsaver[PositionCounter] = Ship;
            if (PositionCounter == 1)
            {
                if (IDsaver[0] == Ship)
                {
                    ReloadSaver();
                    return;
                }
                for (int i = 0; i < 2; i++)
                    Positions[i] = IDsaver[i].transform.position;
                StartMoving = true;
                BasicMovements.SwapValue(ref IDsaver[0].GetComponent<ShipsGear>().PositionID, ref IDsaver[1].GetComponent<ShipsGear>().PositionID);
            }
            else
                PositionCounter++;
        }
    }
}
