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


// Node after monobehaviour?
public class GameManager : MonoBehaviour
{

    public List<Node> nodeList = new List<Node>();

    public int? totalCost = 0;

    public int attempts = 3;

    public Node NodeA;
    public Node NodeB;
    public Node NodeC;
    public Node NodeD;
    public Node NodeE;
    public Node NodeF;

    public Text totalCostText;
    public Text aCostText;
    public Text bCostText;
    public Text cCostText;
    public Text dCostText;
    public Text eCostText;
    public Text fCostText;
    public Text helpText;

    public Image ABPath;
    public Image ACPath;
    public Image BCPath;
    public Image BDPath;
    public Image BEPath;
    public Image CFPath;
    public Image DFPath;
    public Image DEPath;
    public Image EFPath;

    
    //Color colorACPath = ACPath.color;
    //Color colorBCPath = BCPath.color;
    //Color colorBDPath = BDPath.color;
    //Color colorBEPath = BEPath.color;
    //Color colorCFPath = CFPath.color;
    //Color colorDFPath = DFPath.color;
    //Color colorEFPath = EFPath.color;

    private void Start()
    {
        print(NodeA);
        print(NodeB);
        print(NodeC);
        print(NodeD);
        print(NodeE);
        print(NodeF);
        InitalizeNodes();
        print(NodeA.GetNodeName());
        print(NodeA.GetNodeCosts('a'));
        print(NodeA.GetNodeCosts('b'));
        print(NodeA.GetNodeOccupied());
    }

    public void Update()
    {
        totalCostText.text = totalCost.ToString();
        if (NodeA.GetNodeOccupied() == true)
        {
            aCostText.text = "A: Here!";
            bCostText.text = "B: 3";
            cCostText.text = "C: 5";
            dCostText.text = "D: N/A";
            eCostText.text = "E: N/A";
            fCostText.text = "F: N/A";
        }

        else if (NodeB.GetNodeOccupied() == true)
        {
            aCostText.text = "A: 3";
            bCostText.text = "B: Here!";
            cCostText.text = "C: 2";
            dCostText.text = "D: 5";
            eCostText.text = "E: 3";
            fCostText.text = "F: N/A";
            //GetComponent<Image>().color = Color.red;
            //Commenting this out so that it can be updated later
            //just gotta do my separate node testing first :)
        }

        else if (NodeC.GetNodeOccupied() == true)
        {
            aCostText.text = "A: 5";
            bCostText.text = "B: 2";
            cCostText.text = "C: Here!";
            dCostText.text = "D: N/A";
            eCostText.text = "E: N/A";
            fCostText.text = "F: 8";
        }

        else if (NodeD.GetNodeOccupied() == true)
        {
            aCostText.text = "A: N/A";
            bCostText.text = "B: 5";
            cCostText.text = "C: N/A";
            dCostText.text = "D: Here!";
            eCostText.text = "E: 2";
            fCostText.text = "F: 1";
        }

        else if (NodeE.GetNodeOccupied() == true)
        {
            aCostText.text = "A: N/A";
            bCostText.text = "B: 3";
            cCostText.text = "C: N/A";
            dCostText.text = "D: 1";
            eCostText.text = "E: Here!";
            fCostText.text = "F: 4";
        }

        else if (NodeF.GetNodeOccupied() == true)
        {
            aCostText.text = "A: N/A";
            bCostText.text = "B: N/A";
            cCostText.text = "C: 8";
            dCostText.text = "D: 2";
            eCostText.text = "E: 4";
            fCostText.text = "F: Here!";

            CheckWinCondition();
        }
    }

    public void InitalizeNodes()
    {
        NodeA.SetNodeName('a');
        NodeB.SetNodeName('b');
        NodeC.SetNodeName('c');
        NodeD.SetNodeName('d');
        NodeE.SetNodeName('e');
        NodeF.SetNodeName('f');

        NodeA.SetNodeCosts(null, 3, 5, null, null, null);
        NodeB.SetNodeCosts(3, null, 2, 5, 3, null);
        NodeC.SetNodeCosts(5, 2, null, null, null, 8);
        NodeD.SetNodeCosts(null, 5, null, null, 1, 2);
        NodeE.SetNodeCosts(null, 3, null, 1, null, 4);
        NodeF.SetNodeCosts(null, null, 8, 2, 4, null);

        NodeA.SetNodeOccupied(true);
        NodeB.SetNodeOccupied(false);
        NodeC.SetNodeOccupied(false);
        NodeD.SetNodeOccupied(false);
        NodeE.SetNodeOccupied(false);
        NodeF.SetNodeOccupied(false);

        nodeList.Add(NodeA);
        nodeList.Add(NodeB);
        nodeList.Add(NodeC);
        nodeList.Add(NodeD);
        nodeList.Add(NodeE);
        nodeList.Add(NodeF);



}

    public void TraverseToB()
    {
        if (NodeA.GetNodeOccupied() == true)
        {
            print("THIS SHOULD PRINT");
            totalCost += 3;
            NodeA.SetNodeOccupied(false);
            NodeB.SetNodeOccupied(true);

            Color colorABPath = ABPath.color;
            colorABPath.a = 1;
            ABPath.color = colorABPath;
        }

        else if (NodeC.GetNodeOccupied() == true)
        {
            totalCost += 2;
            NodeC.SetNodeOccupied(false);
            NodeB.SetNodeOccupied(true);

            Color colorBCPath = BCPath.color;
            colorBCPath.a = 1;
            BCPath.color = colorBCPath;
        }

        else
        {
            helpText.text = "Cannot traverse to B from here";
        }
    }

    public void TraverseToC()
    {
        if (NodeA.GetNodeOccupied() == true)
        {
            totalCost += 5;
            NodeA.SetNodeOccupied(false);
            NodeC.SetNodeOccupied(true);

            Color colorACPath = ACPath.color;
            colorACPath.a = 1;
            ACPath.color = colorACPath;

        }

        else if (NodeB.GetNodeOccupied() == true)
        {
            totalCost += 2;
            NodeB.SetNodeOccupied(false);
            NodeC.SetNodeOccupied(true);

            Color colorBCPath = BCPath.color;
            colorBCPath.a = 1;
            BCPath.color = colorBCPath;
        }

        else
        {
            helpText.text = "Cannot traverse to C from here";
            print("Cannot traverse from here");
        }

    }

    public void TraverseToD()
    {
        if (NodeB.GetNodeOccupied() == true)
        {
            totalCost += 5;
            NodeB.SetNodeOccupied(false);
            NodeD.SetNodeOccupied(true);

            Color colorBDPath = BDPath.color;
            colorBDPath.a = 1;
            BDPath.color = colorBDPath;
        }

        else if (NodeE.GetNodeOccupied() == true)
        {
            totalCost += 1;
            NodeE.SetNodeOccupied(false);
            NodeD.SetNodeOccupied(true);

            Color colorDEPath = DEPath.color;
            colorDEPath.a = 1;
            DEPath.color = colorDEPath;
        }

        else
        {
            helpText.text = "Cannot traverse to D from here";
            print("Can't traverse from where you are");
        }
    }

    public void TraverseToE()
    {
        if (NodeB.GetNodeOccupied() == true)
        {
            totalCost += 3;
            NodeB.SetNodeOccupied(false);
            NodeE.SetNodeOccupied(true);

            Color colorBEPath = BEPath.color;
            colorBEPath.a = 1;
            BEPath.color = colorBEPath;
        }

        else if (NodeD.GetNodeOccupied() == true)
        {
            totalCost += 1;
            NodeD.SetNodeOccupied(false);
            NodeE.SetNodeOccupied(true);

            Color colorDEPath = DEPath.color;
            colorDEPath.a = 1;
            DEPath.color = colorDEPath;
        }

        else
        {
            helpText.text = "Cannot traverse to E from here";
            print("cannot traverse like this");
        }
    }

    public void TraverseToF()
    {
        if (NodeC.GetNodeOccupied() == true)
        {
            totalCost += 8;
            NodeC.SetNodeOccupied(false);
            NodeF.SetNodeOccupied(true);

            Color colorCFPath = CFPath.color;
            colorCFPath.a = 1;
            CFPath.color = colorCFPath;
        }

        else if (NodeD.GetNodeOccupied() == true)
        {
            totalCost += 2;
            NodeD.SetNodeOccupied(false);
            NodeF.SetNodeOccupied(true);

            Color colorDFPath = DFPath.color;
            colorDFPath.a = 1;
            DFPath.color = colorDFPath;

        }

        else if (NodeE.GetNodeOccupied() == true)
        {
            totalCost += 4;
            NodeE.SetNodeOccupied(false);
            NodeF.SetNodeOccupied(true);

            Color colorEFPath = EFPath.color;
            colorEFPath.a = 1;
            EFPath.color = colorEFPath;
        }

        else
        {
            helpText.text = "Cannot traverse to F from here";
            print("Cannot jump to F yet!");
        }
    }

    public void CheckWinCondition()
    {
        if (totalCost <= 9)
        {
            print("You win!");
            EndGame();
        }

        else
        {
            ResetGame();
        }
    }

    public void EndGame()
    {
        helpText.text = "You learned Dijikstra's Algorithm!";

        Color colorACPath = ACPath.color;
        colorACPath.a = 0.15f;
        ACPath.color = colorACPath;

        Color colorBCPath = BCPath.color;
        colorBCPath.a = 0.15f;
        BCPath.color = colorBCPath;

        Color colorBDPath = BDPath.color;
        colorBDPath.a = 0.15f;
        BDPath.color = colorBDPath;

        Color colorCFPath = CFPath.color;
        colorCFPath.a = 0.15f;
        CFPath.color = colorCFPath;


    }

    public void ResetGame()
    {
        NodeF.SetNodeOccupied(false);

        NodeA.SetNodeOccupied(true);

        NodeB.SetNodeOccupied(false);
        NodeC.SetNodeOccupied(false);
        NodeD.SetNodeOccupied(false);
        NodeE.SetNodeOccupied(false);
        totalCost = 0;

        attempts -= 1;

        helpText.text = "Lives remaining: " + attempts.ToString();

        if (attempts == 0)
        {
            print("YOU LOST ALL YOUR LIVES!");
            helpText.text = "You lose!";
        }

        Color colorABPath = ABPath.color;
        colorABPath.a = 0;
        ABPath.color = colorABPath;

        Color colorACPath = ACPath.color;
        colorACPath.a = 0;
        ACPath.color = colorACPath;

        Color colorBCPath = BCPath.color;
        colorBCPath.a = 0;
        BCPath.color = colorBCPath;

        Color colorBDPath = BDPath.color;
        colorBDPath.a = 0;
        BDPath.color = colorBDPath;

        Color colorBEPath = BEPath.color;
        colorBEPath.a = 0;
        BEPath.color = colorBEPath;

        Color colorCFPath = CFPath.color;
        colorCFPath.a = 0;
        CFPath.color = colorCFPath;

        Color colorDEPath = DEPath.color;
        colorDEPath.a = 0;
        DEPath.color = colorDEPath;

        Color colorDFPath = DFPath.color;
        colorDFPath.a = 0;
        DFPath.color = colorDFPath;

        Color colorEFPath = EFPath.color;
        colorEFPath.a = 0;
        EFPath.color = colorEFPath;

    }

        

































    /*
    public void Traverse(Node start, Node destination)
    {
        if (start.getNodeName() == destination.getNodeName())
        {
            print("You can't traverse to the same node you're at!");
        }

        else if (start.getNodeName() == 'a')
        {
            if (destination.getNodeName() == 'a')
            {
                totalCost += start.getNodeCosts('a');
            }
            else if (destination.getNodeName() == 'b')
            {
                totalCost += start.getNodeCosts('b');
            }
            else if (destination.getNodeName() == 'c')
            {
                totalCost += start.getNodeCosts('c');
            }
            else if (destination.getNodeName() == 'd')
            {
                totalCost += start.getNodeCosts('d');
            }
            else if (destination.getNodeName() == 'e')
            {
                totalCost += start.getNodeCosts('e');
            }
            else if (destination.getNodeName() == 'f')
            {
                totalCost += start.getNodeCosts('f');
            }
        }
        else if (start.getNodeName() == 'b')
        {
            if (destination.getNodeName() == 'a')
            {
                totalCost += start.getNodeCosts('a');
            }
            else if (destination.getNodeName() == 'b')
            {
                totalCost += start.getNodeCosts('b');
            }
            else if (destination.getNodeName() == 'c')
            {
                totalCost += start.getNodeCosts('c');
            }
            else if (destination.getNodeName() == 'd')
            {
                totalCost += start.getNodeCosts('d');
            }
            else if (destination.getNodeName() == 'e')
            {
                totalCost += start.getNodeCosts('e');
            }
            else if (destination.getNodeName() == 'f')
            {
                totalCost += start.getNodeCosts('f');
            }
        }
        else if (start.getNodeName() == 'c')
        {
            if (destination.getNodeName() == 'a')
            {
                totalCost += start.getNodeCosts('a');
            }
            else if (destination.getNodeName() == 'b')
            {
                totalCost += start.getNodeCosts('b');
            }
            else if (destination.getNodeName() == 'c')
            {
                totalCost += start.getNodeCosts('c');
            }
            else if (destination.getNodeName() == 'd')
            {
                totalCost += start.getNodeCosts('d');
            }
            else if (destination.getNodeName() == 'e')
            {
                totalCost += start.getNodeCosts('e');
            }
            else if (destination.getNodeName() == 'f')
            {
                totalCost += start.getNodeCosts('f');
            }
        }
        else if (start.getNodeName() == 'd')
        {
            if (destination.getNodeName() == 'a')
            {
                totalCost += start.getNodeCosts('a');
            }
            else if (destination.getNodeName() == 'b')
            {
                totalCost += start.getNodeCosts('b');
            }
            else if (destination.getNodeName() == 'c')
            {
                totalCost += start.getNodeCosts('c');
            }
            else if (destination.getNodeName() == 'd')
            {
                totalCost += start.getNodeCosts('d');
            }
            else if (destination.getNodeName() == 'e')
            {
                totalCost += start.getNodeCosts('e');
            }
            else if (destination.getNodeName() == 'f')
            {
                totalCost += start.getNodeCosts('f');
            }
        }
        else if (start.getNodeName() == 'e')
        {
            if (destination.getNodeName() == 'a')
            {
                totalCost += start.getNodeCosts('a');
            }
            else if (destination.getNodeName() == 'b')
            {
                totalCost += start.getNodeCosts('b');
            }
            else if (destination.getNodeName() == 'c')
            {
                totalCost += start.getNodeCosts('c');
            }
            else if (destination.getNodeName() == 'd')
            {
                totalCost += start.getNodeCosts('d');
            }
            else if (destination.getNodeName() == 'e')
            {
                totalCost += start.getNodeCosts('e');
            }
            else if (destination.getNodeName() == 'f')
            {
                totalCost += start.getNodeCosts('f');
            }
        }
        else if (start.getNodeName() == 'f')
        {
            if (destination.getNodeName() == 'a')
            {
                totalCost += start.getNodeCosts('a');
            }
            else if (destination.getNodeName() == 'b')
            {
                totalCost += start.getNodeCosts('b');
            }
            else if (destination.getNodeName() == 'c')
            {
                totalCost += start.getNodeCosts('c');
            }
            else if (destination.getNodeName() == 'd')
            {
                totalCost += start.getNodeCosts('d');
            }
            else if (destination.getNodeName() == 'e')
            {
                totalCost += start.getNodeCosts('e');
            }
            else if (destination.getNodeName() == 'f')
            {
                totalCost += start.getNodeCosts('f');
            }
        }
    }
    */


    //public Node NodeA = new Node(null, 3, 5, null, null, null, true);
    //public Node NodeB = new Node(3, null, 2, 5, 3, null, false);
    //public Node NodeC = new Node(5, 2, null, null, null, 8, false);
    //public Node NodeD = new Node(null, 5, null, null, 1, 2, false);
    //public Node NodeE = new Node(null, 3, null, 1, null, 4, false);
    //public Node NodeF = new Node(null, null, 8, 2, 4, null, false);




    //public Node NodeA = new Node(aCost = null, bCost = 3, cCost = 5, dCost = null, eCost = null, fCost = null);
    //public Node NodeB = new Node(aCost = 3, bCost = null, cCost = 2, dCost = 5, eCost = 3, fCost = null);
    //public Node NodeC = new Node(aCost = 5, bCost = 2, cCost = null, dCost = null, eCost = null, fCost = 8);
    //public Node NodeD = new Node(aCost = null, bCost = 5, cCost = null, dCost = null, eCost = 1, fCost = 2);
    //public Node NodeE = new Node(aCost = null, bCost = 3, cCost = null, dCost = 1, eCost = null, fCost = 4);
    //public Node NodeF = new Node(aCost = null, bCost = null, cCost = 8, dCost = 2, eCost = 4, fCost = null);

}
