/*Remove Kth Node from end of the list*/
public int RemoveKNodeFromLast(ListNode node, int k)
{
    ListNode result = new ListNode(0, head);
    ListNode fast = result;
    ListNode slow = result;

    for(int i = 0; i < k; i++)
    {
        fast = fast.next;
    }
    while(fast.next != null)
    {
        slow = slow.next;
        fast = fast.next;
    }
    slow.next = slow.next.next;
    return result.next;
}
/*Remove Kth node without having head*/
public void DeleteNode(ListNode node)
{
    node.val = node.next.val;
    node.next = node.next.next;
}
/*Remove occurences of a value in LinkedList*/
public ListNode RemoveOccurences(ListNode head, int k)
{
    ListNode result = new ListNode(0, head);
    ListNode curr = result;
    while(curr != null && curr.next != null)
    {
        if(curr.next.val == k)
        {
            curr.next = curr.next.next;
        }
        else
        {
            curr = curr.next;
        }
    }
    return result.next;
}
/*Add Kth Node in Linked List*/
public ListNode AddElementAtK(ListNode head, int k, ListNode val)
{
    ListNode curr = head;
    if(k == 1)
    {
        val.next = head;
        head = val;
        return head;
    }
    for(int i = 0; i < k - 1; i++)
    {
        curr = curr.next;
    }
    val.next = curr.next;
    curr.next = val;

    return head;
}
/*Append 2 Linked List*/
public ListNode AppendLists(ListNode list1, ListNode list2)
{
    ListNode curr = list1;

    while(curr.next != null)
    {
        curr = curr.next;
    }
    curr.next = list2;

    return list1;
}
