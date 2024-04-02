/* 1. Remove Kth Node from end of the list*/
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
/* 2. Remove Kth node without having head*/
public void DeleteNode(ListNode node)
{
    node.val = node.next.val;
    node.next = node.next.next;
}
/* 3. Remove occurences of a value in LinkedList*/
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
/* 4. Add Kth Node in Linked List*/
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
/* 5. Append 2 Linked List*/
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
/* 6. Remove duplicates from a sorted linked list*/
public ListNode RemoveDuplicates(ListNode head)
{
    ListNode curr = head;

    while(curr != null && curr.next != null)
    {
        if(curr.val == curr.next.val)
        {
            curr.next = curr.next.next;
        }
        else
        {
            curr = curr.next;
        }
    }
    return head;
}
/* Two Pointer Approach: Remove duplicates from a sorted linked list*/
public ListNode RemoveDuplicates(ListNode head)
{
    if(head == null)
    {
        return head;
    }
    ListNode slow = head;
    ListNode fast = head.next;

    while(fast != null)
    {
        if(slow.val == fast.val)
        {
            slow.next = fast.next;
            fast = fast.next;
        }
        else
        {
            slow = slow.next;
            fast = fast.next;
        }
    }
    return head;
}
/* 7. Remove all occurences of duplicate nodes in Linked List*/
public ListNode RemoveDuplicateAllOccurences(ListNode head)
{
    if(head == null || head.next == null)
    {
        return head;
    }
    ListNode result = new ListNode(0, head);
    ListNode slow = result;
    ListNode fast = result.next;

    while(fast != null)
    {   //this while block checks all duplicate occurences and iterate through fast pointer
        while(fast.next != null && fast.val == fast.next.val)
        {
            fast = fast.next;
        }
        //when the last duplicate occurence reached compare with slow
        if(slow.next == fast)
        {
            slow = slow.next;
        }
        else
        {
            slow.next = fast.next;
        }
        //move forward
        fast = fast.next;
    } 
    return result.next;
}

