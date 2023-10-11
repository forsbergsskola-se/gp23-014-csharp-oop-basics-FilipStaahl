// In C#, a heap is a data structure used to efficiently manage a collection of items, where you can quickly access and remove the item with the highest or lowest value. It's like a special kind of list that keeps the most important item at the top, making it easy to find and remove.

// For example, in a max-heap, the item with the largest value is always at the top. So, if you need to find the largest element in a collection, a max-heap is a fast way to do it. Similarly, a min-heap keeps the smallest item at the top.

// Heaps are often used in tasks like priority queues or sorting algorithms to speed up certain operations.

using P4Heaps;

Player p1 = new Player();
ChangePlayer(p1);
Console.WriteLine(p1.experience);

void ChangePlayer(Player player)
{
    player = new Player();
    player.experience = 200;
}