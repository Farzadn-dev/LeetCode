public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var list = ToList(head);
        var chunks = list.Chunk(k).ToList();
        list.Clear();
        foreach (var c in chunks)
        {
            if (c.Length == k)
                list.AddRange(c.Reverse());
            else
                list.AddRange(c);
        }

        return FromList(list);
    }

    // Converts linked list to regular list
    public static List<int> ToList(ListNode head)
    {
        List<int> result = new();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return result;
    }

    // Converts regular list to linked list
    public static ListNode FromList(List<int> values)
    {
        if (values == null || values.Count == 0)
            return null;

        ListNode dummy = new();
        ListNode current = dummy;

        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;
    }
}

//Without Converting
public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null || k == 1) return head;

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;
        ListNode curr = head;

        int count = 0;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }

        curr = head;
        while (count >= k)
        {
            ListNode first = curr;
            ListNode prevTail = prev;

            // Reverse k nodes
            for (int i = 0; i < k; i++)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            // Connect with previous and next parts
            first.next = curr;
            prevTail.next = prev;

            // Update for next iteration
            prev = first;
            count -= k;
        }

        return dummy.next;
    }
}