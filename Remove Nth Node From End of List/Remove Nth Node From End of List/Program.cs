public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        //Replace from end count to from start count to simple removing
        n = Count(head) - n;

        //if we had to remove first node(Head)
        if (n == 0)
            return head.next;

        //Finding parent of the node that should be deleted
        ListNode parentOfDeletedNode = null;
        for (int i = 0; i < n; i++)
        {
            if (parentOfDeletedNode is null)
            {
                parentOfDeletedNode = head;
                continue;
            }
            parentOfDeletedNode = parentOfDeletedNode.next;
        }

        //skip deleted node
        parentOfDeletedNode.next = parentOfDeletedNode.next.next;
        return head;
    }

    //this function counts number of nodes to do revers removing
    public int Count(ListNode head)
    {
        var copy = head;
        int count = 0;
        while (copy.next is not null)
        {
            count++;
            copy = copy.next;
        }
        return ++count;
    }
}