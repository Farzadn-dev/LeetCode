public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode dummy = new(0);
        ListNode current = dummy;


        var pq = new PriorityQueue<ListNode, int>();
        foreach (var node in lists)
            if (node != null)
                pq.Enqueue(node, node.val);

        while (pq.Count > 0)
        {
            var min = pq.Dequeue();

            current.next = min;
            current = current.next;

            if (min.next != null)
                pq.Enqueue(min.next, min.next.val);
        }
        return dummy.next;
    }
}

#region Chatgpt approach that is more fast but is more complex
//public class Solution
//{
//    public ListNode MergeKLists(ListNode[] lists)
//    {
//        if (lists.Length == 0) return null;

//        int interval = 1;
//        while (interval < lists.Length)
//        {
//            for (int i = 0; i + interval < lists.Length; i += interval * 2)
//            {
//                lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
//            }
//            interval *= 2;
//        }
//        return lists[0];
//    }

//    private ListNode MergeTwoLists(ListNode l1, ListNode l2)
//    {
//        ListNode dummy = new(0);
//        var current = dummy;

//        while (l1 != null && l2 != null)
//        {
//            if (l1.val < l2.val)
//            {
//                current.next = l1;
//                l1 = l1.next;
//            }
//            else
//            {
//                current.next = l2;
//                l2 = l2.next;
//            }
//            current = current.next;
//        }
//        current.next = l1 ?? l2;
//        return dummy.next;
//    }

//}
#endregion

#region Simplest approach (faster than PriorityQueue)
//public class Solution
//{
//    public ListNode MergeKLists(ListNode[] lists)
//    {
//        var values = new List<int>();

//        // Collect all values from the linked lists
//        foreach (var node in lists)
//        {
//            var current = node;
//            while (current != null)
//            {
//                values.Add(current.val);
//                current = current.next;
//            }
//        }

//        // Sort the collected values
//        values.Sort();

//        // Build the new merged linked list
//        var dummy = new ListNode(0);
//        var currentNode = dummy;

//        foreach (var val in values)
//        {
//            currentNode.next = new ListNode(val);
//            currentNode = currentNode.next;
//        }

//        return dummy.next;
//    }
//}
#endregion