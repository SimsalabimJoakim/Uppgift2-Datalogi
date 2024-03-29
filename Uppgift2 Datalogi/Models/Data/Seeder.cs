﻿namespace Uppgift2_Datalogi
{
    using System.Collections.Generic;

    static public class Seeder
    {
        /// <summary>
        /// Get seed data for nodes and edges.
        /// </summary>
        /// <returns>List of nodes connected by edges.</returns>
        static public List<Node> Data()
        {
            List<Node> nodes = new List<Node>();

            // declare nodes
            var nodeA = new Node("A");
            var nodeB = new Node("B");
            var nodeC = new Node("C");
            var nodeD = new Node("D");
            var nodeE = new Node("E");
            var nodeF = new Node("F");
            var nodeG = new Node("G");
            var nodeH = new Node("H");
            var nodeI = new Node("I");
            var nodeJ = new Node("J");

            // add nodes
            nodes.Add(nodeA);
            nodes.Add(nodeB);
            nodes.Add(nodeC);
            nodes.Add(nodeD);
            nodes.Add(nodeE);
            nodes.Add(nodeF);
            nodes.Add(nodeG);
            nodes.Add(nodeH);
            nodes.Add(nodeI);
            nodes.Add(nodeJ);

            // add edges from node A
            nodeA.Edges.Add((nodeB, 4));
            nodeA.Edges.Add((nodeC, 7));
            nodeA.Edges.Add((nodeE, 7));

            // add edges from node B
            nodeB.Edges.Add((nodeA, 4));
            nodeB.Edges.Add((nodeC, 3));
            nodeB.Edges.Add((nodeH, 5));
            nodeB.Edges.Add((nodeD, 12));

            // add edges from node C
            nodeC.Edges.Add((nodeB, 3));
            nodeC.Edges.Add((nodeI, 12));
            nodeC.Edges.Add((nodeG, 4));
            nodeC.Edges.Add((nodeA, 7));

            // add edges from node D
            nodeD.Edges.Add((nodeI, 3));
            nodeD.Edges.Add((nodeH, 7));
            nodeD.Edges.Add((nodeB, 12));

            // add edges from node E
            nodeE.Edges.Add((nodeA, 7));
            nodeE.Edges.Add((nodeG, 5));
            nodeE.Edges.Add((nodeF, 3));

            // add edges from node F
            nodeF.Edges.Add((nodeE, 3));
            nodeF.Edges.Add((nodeG, 5));

            // add edges from node G
            nodeG.Edges.Add((nodeC, 4));
            nodeG.Edges.Add((nodeH, 8));
            nodeG.Edges.Add((nodeJ, 8));
            nodeG.Edges.Add((nodeF, 5));
            nodeG.Edges.Add((nodeE, 5));

            // add edges from node H
            nodeH.Edges.Add((nodeD, 7));
            nodeH.Edges.Add((nodeJ, 9));
            nodeH.Edges.Add((nodeG, 8));
            nodeH.Edges.Add((nodeB, 5));

            // add edges from node I
            nodeI.Edges.Add((nodeD, 3));
            nodeI.Edges.Add((nodeJ, 7));
            nodeI.Edges.Add((nodeG, 13));
            nodeI.Edges.Add((nodeC, 12));

            // add edges from node J
            nodeJ.Edges.Add((nodeI, 7));
            nodeJ.Edges.Add((nodeG, 8));
            nodeJ.Edges.Add((nodeH, 9));

            return nodes;
        }
    }
}