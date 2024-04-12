/* 1. Merge 2 sorted List*/
public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode result = new ListNode(0);
    ListNode curr = result;
    while(list1 != null && list2 != null)
    {
        if(list1.val <= list2.val)
        {
            curr.next = list1;
            list1 = list1.next;
        }
        else
        {
            curr.next = list2;
            list2 = list2.next;
        }
        curr = curr.next;
    }
    if(list1 != null)
    {
        curr.next = list1;
    }
    else
    {
        curr.next = list2;
    }
    return result.next;
}
/* 2. Valid palindrome or not a linked list*/
public bool IsPalindrome(ListNode node)
{
    ListNode slow = node;
    ListNode fast = node.next;

    //finding the mid point -- if fast pointer reaches at end, then slow pointer will be at mid
    while(fast != null && fast.next != null)
    {
        slow=  slow.next;
        fast = fast.next.next;
    }
    //reverse the 2nd half from the mid point
    Listnode rev = Reverse(slow.next); //this function is present in basics.cs file

    while(rev != null)
    {
        if(node.val != rev.val)
        {
            return false;
        }
        node = node.next;
        rev = rev.next;
    }
    return true;
}
/* 3. Two pointer approach: Intersection of Two Linked Lists */
public ListNode GetIntersectNode(ListNode headA, ListNode headB)
{
    ListNode nodeA = headA;
    ListNode nodeB = headB;

    while(nodeA != nodeB)
    {
        nodeA = (nodeA == null) ? headB : nodeA.next;
        nodeB = (nodeB == null) ? headA : nodeB.next;
    }
    return nodeA;
}
/* Intersection of Two Linked Lists */
public ListNode GetIntersectNode(ListNode headA, ListNode headB)
{
    int lenA = GetLength(headA);
    int lenB = GetLength(headB);

    while(lenA > lenB)
    {
        headA = headA.next;
        lenA--;
    }
    while(lenB > lenA)
    {
        headB = headB.next;
        lenB--;
    }
    while(headA != headB)
    {
        headA = headA.next;
        headB = headB.next;
    }
    return headA;
}