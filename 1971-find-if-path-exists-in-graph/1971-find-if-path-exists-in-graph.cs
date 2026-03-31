public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        var adj = new List<int>[n];
        var queue = new Queue<int>();
        var visited = new HashSet<int>();

        for(int i=0; i<n; i++){
            adj[i] = new List<int>();
        } 

        foreach(var edge in edges){
            var u = edge[0];
            var v = edge[1];
            adj[u].Add(v);
            adj[v].Add(u);
        }

        bool BFS(int source, int destination){
          queue.Enqueue(source);
          
          while(queue.Count !=0)
          {
            var node = queue.Dequeue();
            if(node == destination) return true;
            foreach(var neighbor in adj[node]){
                if(!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
          }
          return false;
       }

        return BFS(source,destination);
    }
}