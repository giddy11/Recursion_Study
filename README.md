1. Write a recursive function that given an input n, sums all nonnegative integers up to n. Ie sum(4) = 1+2+3+4 = 10
Get an input n
IF (num == 0) return 0
Return num + SumNumbers(num - 1);
PRINT SumNumbers(n)

2. Write a function that takes two inputs n and m and outputs the number of unique paths from the top left corner to the bottom right corner of a n X m grid.
Constraints: you can only move down or right 1 unit at a time.
What is the simplest possible input?
grid_paths(1,1) >>> 1
grid_paths(2,1) >>> 1
grid_paths(1,2) >>> 1
grid_paths(1,m) >>> 1
grid_paths(n,1) >>> 1
grid_paths(n,m) >>> 1 if n = 1 or m = 1
Play around with examples and visualize!
Relate hard cases to simpler cases
Generalize the pattern
Write code by combining recursive pattern with the base case.
grid_paths(n,m) = grid_paths(n,m-1) + grid_paths(m-1,n)
