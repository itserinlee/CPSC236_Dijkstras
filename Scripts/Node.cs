using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Names: Erin Lee & Rob Farmer
Student IDs: XXXXXXX
Chapman emails: elee2@chapman.edu & rofarmer@chapman.edu
Course Number and Section: 236-01
Assignment: Final Project ("PathFindingPanther")
*/

public class Node : MonoBehaviour
{

    private void Start()
    {

    }

    //should we use a nullable type of int?
    // like int? a in our declarations here
    public char? nodeName;
    public int? aCost = null;
    public int? bCost = null;
    public int? cCost = null;
    public int? dCost = null;
    public int? eCost = null;
    public int? fCost = null;
    public bool? isNodeOccupied = null;

    public void SetNodeName(char? x)
    {
        this.nodeName = x;
    }

    public char? GetNodeName()
    {
        return this.nodeName;
    }

    public void SetNodeCosts (int? a, int? b, int? c, int? d, int? e, int? f)
    {
        this.aCost = a;
        this.bCost = b;
        this.cCost = c;
        this.dCost = d;
        this.eCost = e;
        this.fCost = f;
    }

    public int? GetNodeCosts (char x)
    {
        if (x == 'a')
        {
            return this.aCost;
        }
        else if (x == 'b')
        {
            return this.bCost;
        }
        else if (x == 'c')
        {
            return this.cCost;
        }
        else if (x == 'd')
        {
            return this.dCost;
        }
        else if (x == 'e')
        {
            return this.eCost;
        }
        else if (x == 'f')
        {
            return this.fCost;
        }
        else
        {
            print("Error in getNodeCosts: invalid character.");
            return '1';
        }
    }

    public void SetNodeOccupied(bool? occupied)
    {
        this.isNodeOccupied = occupied;
    }

    public bool? GetNodeOccupied()
    {
        return this.isNodeOccupied;
    }
}
