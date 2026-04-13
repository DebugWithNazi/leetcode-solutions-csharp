public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();

        var path = new List<int>() { 0 };

        DFS(graph, 0, path, result);

        return result;        
    }

    public void DFS(int[][] graph, int node, List<int> path, List<IList<int>> result){
        if(node == graph.Length - 1){
            result.Add(new List<int>(path));
            return;
        }

        foreach(var neighbor in graph[node]){
            path.Add(neighbor);
            DFS(graph, neighbor, path, result);
            path.RemoveAt(path.Count-1);
        }
    }
}