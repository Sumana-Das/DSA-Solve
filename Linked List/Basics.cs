/* 1. Linked List Class */
public class ListNode
{
    int data;
    ListNode next;
    public ListNode(int data = 0, next = null)
    {
        this.data = data;
        this.next = next;
    }
}
/* 2. Print a Linked List */
public void printLinkedList(ListNode head)
{
    ListNode curr = head;

    while(curr != null)
    {
        Console.Write(curr.data + " ");
        curr = curr.next;
    }
}
/* Linked List to Array */
public int Length(ListNode node)
{
    int count = 0;
    ListNode curr = node;

    while(curr != null)
    {
        count++;
        curr = curr.next;
    }
    return count;
}
public int[] ListToArray(ListNode head)
{
    int len = Length(head);
    int[] arr = new int[len];
    ListNode curr = head;
    int i = 0;

    while(curr != null)
    {
        arr[i] = curr.data;
        i++;
        curr = curr.next;
    }
    return arr;
}

/* 3. Reverse Linked List */
public ListNode Reverse(ListNode node)
{
    ListNode prev = null;
    ListNode next = null;
    ListNode curr = node;
    if(head == null || head.next == null)
    {
        return head;
    }
    while(curr != null)
    {
        next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }
    printLinkedList(prev);

    return prev;
}
/*Kth Node in Linked List*/
public int NByKthNode(Node head, int k)
{
    if(head == null)
    {
        return -1;
    }
    if(head.next == null)
    {
        return head.data;
    }
    Node curr = head;
    int len = Length(head);
    
    double d = len / k;
    int n = (int)Math.Ceiling(d);
    
    int i = 1;
    int val = 0;
    while(i <= n)
    {
        val = curr.data;
        curr = curr.next;
        i++;
    }
    return val;
}
/*Find middle element of Linked List*/
public int FindMiddle(ListNode node)
{
    int len = Length(node);
    int mid = len/2 + 1;
    ListNode curr = node;
    for(int i = 1; i < mid; i++)
    {
        curr = curr.next;
    }
    return curr;
}
/*Find kth Node of end of Linked List*/
public int FindKthNode(ListNode node)
{
    int len = Length(node);
    int lenBegin = len - k + 1;
    ListNode curr = node;
    for(int i = 1; i < lenBegin; i++)
    {
        curr = curr.next;
    }
    return curr;
}

