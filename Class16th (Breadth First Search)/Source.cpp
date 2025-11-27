#include <iostream>
#include <queue>
#include <vector>
#include <unordered_map>
#include <unordered_set>

using namespace std;

template <typename T>
class Graph
{
private:
	unordered_map<T, vector<T>> adjacencyList;

public:
	void insert(const T& i, const T& j)
	{
		adjacencyList[i].push_back(j);
		adjacencyList[j].push_back(i);
	}

	void search(const T& start)
	{
		queue<T> queue;

		unordered_set<T> visited;

		queue.push(start);

		visited.insert(start);

		while (queue.empty() == false)
		{
			T x = queue.front();

			queue.pop();

			cout << x << " ";

			for (const T& element : adjacencyList[x])
			{
				if (visited.count(element) == false)
				{
					queue.push(element);

					visited.insert(element);
				}
			}
		}
	}
};

int main()
{
#pragma region 너비 우선 탐색 (Breadth First Search)
	// 하나의 시작 정점을 방문한 후 시작 정점에 인접한
	// 모든 정점들을 우선적으로 방문하는 탐색입니다.

	Graph<char> graph;

	graph.insert('A', 'B');

	graph.insert('A', 'C');

	graph.insert('B', 'D');

	graph.insert('B', 'E');

	graph.insert('C', 'F');

	graph.insert('C', 'G');

	graph.search('A');

#pragma endregion

	return 0;
}