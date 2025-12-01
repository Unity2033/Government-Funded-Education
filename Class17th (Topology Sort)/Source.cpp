#include <iostream>
#include <queue>
#include <vector>
#include <unordered_set>
#include <unordered_map>

using namespace std;

template <typename T>
class Graph
{
private:
	unordered_set<T> vertices;
	unordered_map<T, int> degree;
	unordered_map<T, vector<T>> adjacencyList;
public:
	void insert(const T& i, const T& j)
	{
		adjacencyList[i].push_back(j);

		degree[j]++;

		vertices.insert(i);
		vertices.insert(j);

		if (degree.count(i) == false)
		{
			degree[i] = 0;
		}
	}

	void sort()
	{
		queue<T> queue;

		int count = 0;

		for (const T& element : vertices)
		{
			if (degree[element] == 0)
			{
				queue.push(element);
			}
		}

		while (queue.empty() == false)
		{
			T x = queue.front();

			queue.pop();

			cout << x << " ";

			count++;

			for (const T& element : adjacencyList[x])
			{
				degree[element]--;

				if (degree[element] == 0)
				{
					queue.push(element);
				}
			}
		}

		cout << endl;

		if (count != vertices.size())
		{
			cout << "A cycle has occurred." << endl;
		}
	}

};

int main()
{
#pragma region 위상 정렬
	// 병합 그래프에 존재하는 각 정점들의 선행 순서를 지키며,
	// 모든 정점을 차례대로 진행하는 방식의 정렬입니다.

	// 사이클이 발생하는 경우 위상 정렬을 수행할 수 없습니다.

	// DAG(Directed Acyclic Graph) : 사이클이 존재하지 않는 그래프

	// 시간 복잡도 : O(V + E)

	// 위상 정렬하는 방법

	// 1. 진입 차수가 0인 정점을 Queue에 삽입합니다.

	// 2. Queue에서 원소를 꺼내 연결된 모든 간선을 제거합니다.

	// 3. 간선 제거 이후에 진입 차수가 0이 된 정점을 Queue에 삽입합니다.

	// 4. Queue가 비어있을 때까지 2번 ~ 3번 작업을 반복적으로 수행합니다.

	Graph<int> graph;

	graph.insert(1, 2);
	graph.insert(1, 5);

	graph.insert(2, 3);
	graph.insert(3, 4);

	graph.insert(4, 6);

	graph.insert(5, 6);
	graph.insert(6, 7);

	graph.sort();

#pragma endregion

	return 0;
}