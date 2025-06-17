public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // If either list is null, return the other list as the merged result
        if (list1 == null)
            return list2;
        else if (list2 == null)
            return list1;

        // Initialize pointers for both lists
        ListNode currentNode1 = list1;
        ListNode currentNode2 = list2;

        // Create the head node of the merged list
        ListNode head = new();

        // Compare the first two nodes and set the head's value
        var firstCompare = CompareTwoNode(ref currentNode1, ref currentNode2, out int firstIndex);
        head.val = firstIndex;

        // Prepare the next node in the merged list
        ListNode currentResult = new();
        if (firstCompare)
        {
            // If the first nodes had equal values, we already advanced both lists
            currentResult.val = firstIndex;
            head.next = currentResult;

            // If any nodes are left, create the next node placeholder
            if (currentNode1 != null || currentNode2 != null)
            {
                currentResult.next = new();
                currentResult = currentResult.next;
            }
        }
        else
        {
            // If first nodes were not equal, link head to the next node
            head.next = currentResult;
        }

        // Iterate while there are nodes left in either list
        while (currentNode1 != null || currentNode2 != null)
        {
            // Compare nodes and get the next value to add
            var comparison = CompareTwoNode(ref currentNode1, ref currentNode2, out int biggerVal);
            currentResult.val = biggerVal;

            if (comparison)
            {
                // If values were equal, add another node with the same value
                currentResult.next = new();
                currentResult = currentResult.next;
                currentResult.val = biggerVal;
            }

            // If any nodes left, create a new placeholder node
            if (currentNode1 != null || currentNode2 != null)
            {
                currentResult.next = new();
                currentResult = currentResult.next;
            }
        }

        // Return the merged list starting from the head
        return head;
    }

    public bool CompareTwoNode(ref ListNode? node1, ref ListNode? node2, out int result)
    {
        if (node1 == null)
        {
            // If node1 is null, take node2's value and move node2 forward
            result = node2.val;
            node2 = node2.next;
            return false;
        }
        else if (node2 == null)
        {
            // If node2 is null, take node1's value and move node1 forward
            result = node1.val;
            node1 = node1.next;
            return false;
        }

        if (node1.val == node2.val)
        {
            // If both values are equal, move both pointers forward
            result = node1.val;
            node1 = node1.next;
            node2 = node2.next;
            return true;
        }

        if (node1.val < node2.val)
        {
            // If node1 has the smaller value, move node1 forward
            result = node1.val;
            node1 = node1.next;
        }
        else
        {
            // If node2 has the smaller value, move node2 forward
            result = node2.val;
            node2 = node2.next;
        }

        return false;
    }
}
