using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Node
{
    public string name { get; private set; }
    public Node parent;
    public bool visited;

    public int x;
    public int y;

    public double g, h, f;
    public List<Edge> neighbors = new List<Edge>();
    public Node(string name, int x, int y)
    {
        this.name = name;
        this.x = x;
        this.y = y;
    }
    public void calculate_G_Cost(Node other)
    {

    }
    public double getG()
    {
        return g;
    }

    public double getH()
    {
        return h;
    }
}

public class Edge
{
    public Node node;
    public string streetName;
    public Edge(Node v,string street)
    {
        node = v;
        streetName = street;
    }
}

