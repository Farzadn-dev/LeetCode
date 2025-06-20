var res = new Solution().SwapPairs(ListNode.ConvertToLinkedList([1, 2, 3, 4]));
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode current = dummy;

        while (current.next != null && current.next.next != null)
        {
            ListNode first = current.next;
            ListNode second = current.next.next;

            // Swap
            first.next = second.next;
            second.next = first;
            current.next = second;

            // Move to the next pair
            current = first;
        }

        return dummy.next;
    }
}