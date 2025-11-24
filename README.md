How does each pathfinding algorithms calculate and prioritize paths?
- BFS iterates through every possible path with no priority and eventually finds the quickest path based on which path ends up at the finish in the fewest number of moves
- A* uses how many moves it took to reach the current step and uses the manhattan distance heuristic to rank the open paths by which are more likely to be reaching the goal first and searching the most likely options first
- Dijkstra uses how long it took to reach the current step, being able to account for moves having differing movement costs, to create a priority search to find the shortest path
What challenges arise when dynamically updating obstacles in real-time?
- when dynamically updating obstacles in real-time you have to be able to edit the grid to be able to add that obstacle, as well as having to search again for the shortest path now that the grid has changed.
Which algorithm should you choose and how should you adapt it for larger grids or open-world settings?
- A* is the quickest of the 3 options, so that would be my default option for a search. I think for a larger grid it would work the same, but for open-world there might need to be some changes made due to other factors, like staying out of enemy range and prioritizing staying on land even if water is faster.
What would your approach be if you were to add weighted cells (e.g., "difficult terrain" areas)?
- I would use Dijkstra, as it is the only option that allows for the use of weighted cells.
