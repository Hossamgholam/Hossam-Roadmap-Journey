#pragma once
#include <iostream>
using namespace std;

#pragma region descrption

/*
=====================================================
    clsDbLinkedList<T>
    -------------------
    A generic implementation of a Doubly Linked List
    using C++ templates.

    🔹 Main Features:
    - Dynamic storage using nodes.
    - Each node has (value, next, prev).
    - Supports insertion, deletion, searching, updating.
    - Can print, reverse, clear, check empty.
    - Works with any data type (int, string, float...).

    🔹 Common Methods:
    - insertAtBeginning(value)   → add node at start
    - insertAtEnd(value)         → add node at end
    - insertAfter(node, value)   → insert after a given node
    - insertAfter(index, value)  → insert after a given index
    - deleteFristNode()          → remove first node
    - deleteLastNode()           → remove last node
    - deleteNode(node*)          → remove a specific node
    - clear()                    → delete all nodes
    - getNode(index)             → return pointer to node
    - getItem(index)             → return value at index
    - updateItem(index, value)   → update value
    - find(value)                → search by value
    - printList()                → print all nodes
    - size()                     → return number of nodes
    - isEmpty()                  → check if list is empty
    - Reverse()                  → reverse the list order

=====================================================
*/
#pragma endregion

template <class T>
class clsDbLinkedList
{
protected:
    int _size = 0;

public:
    class node
    {
    public:
        T value;
        node *next;
        node *priv;
    };

    node *head = NULL;

    void insertAtBeginning(T newValue)
    {
        node *newNode = new node();
        newNode->value = newValue;
        newNode->priv = NULL;
        // in to condetion it equeal to head if it null or not
        newNode->next = head;

        // if ther is no node it donot do it
        if (head != NULL)
        {
            head->priv = newNode;
        }
        head = newNode;
        _size++;
    }
    node *find(T value)
    {
        node *current = head;
        while (current != NULL)
        {
            if (current->value == value)
            {
                return current;
            }
            current = current->next;
        }
        return NULL;
    }
    void insertAfter(node *aftar, T newValue)
    {
        node *newNod = new node();

        newNod->value = newValue;
        newNod->next = aftar->next;
        newNod->priv = aftar;

        // check if there is node at last (he did not insert at end)
        if (aftar->next != NULL)
        {
            aftar->next->priv = newNod;
        }
        aftar->next = newNod;
        _size++;
    }
    void insertAtEnd(T newValue)
    {
        node *newNode = new node();
        newNode->value = newValue;
        newNode->next = NULL;

        if (head == NULL)
        {
            newNode->priv = NULL;
            head = newNode;
        }
        else
        {

            node *lastNode = head;
            while (lastNode->next != NULL)
            {
                lastNode = lastNode->next;
            }

            lastNode->next = newNode;
            newNode->priv = lastNode;
        }
        _size++;
    }
    void deleteNode(node *&deleteNode)
    {
        if (head == NULL || deleteNode == NULL)
        {
            return;
        }
        // if ther is one node it make head=NULL then delete
        if (head == deleteNode)
        {
            head = deleteNode->next;
        }
        // if deletnode not last node it do condetioni
        if (deleteNode->next != NULL)
        {
            deleteNode->next->priv = deleteNode->priv;
        }
        // if deletnode not frist node it do condetion
        if (deleteNode->priv != NULL)
        {
            deleteNode->priv->next = deleteNode->next;
        }
        // at last it delte node
        delete deleteNode;
        _size--;
    }
    void deleteFristNode()
    {
        if (head == NULL)
        {
            return;
        }

        node *temp = head;

        head = head->next;
        if (head != NULL)
        {
            head->priv = NULL;
        }
        delete temp;
        _size--;
    }
    void deleteLastNode()
    {
        if (head == NULL)
        {
            return;
        }

        if (head->next == NULL)
        {
            delete head;
            head = NULL;
            _size--;
            return;
        }

        node *current = head;
        // this loop go out befor last node;
        while (current->next->next != NULL)
        {
            current = current->next;
        }
        // it point to last node
        node *temp = current->next;
        current->next = NULL;
        delete temp;
        _size--;
    }
    void printList()
    {
        node *current = head;
        while (current != NULL)
        {
            cout << current->value << " ";
            current = current->next;
        }
    }

    // extintion 1 project 1
    int size()
    {
        /*node* current = head;
        int lenght = 0;
        while (current != NULL) {
            lenght++;
            current = current->next;
        }
        return lenght;*/
        return _size;
    }

    bool isEmpty()
    {
        return (_size == 0 ? true : false);
    }

    void clear()
    {
        // this performance good
#pragma region Another sloution

        /*node* temp ;
        while (head != NULL) {
            temp = head;
            head = head->next;
            delete temp;

        }
        _size=0;*/
#pragma endregion
        // this Maintainability
        while (_size > 0)
        {
            deleteFristNode();
        }
    }

    // we used swap between next and prev
    void Reverse()
    {
        node *current = head;
        node *temp = nullptr;
        while (current != nullptr)
        {
            temp = current->priv;
            current->priv = current->next;
            current->next = temp;
            current = current->priv;
        }
        if (temp != nullptr)
        {
            head = temp->priv;
        }
    }
    ////////////////////////////////////

    node *getNode(short index)
    {
        /*if (index<0||index > size()) {
            cout << "this is out of range:\n";
            return nullptr;
        }
        node* current = head;
        for(int i=0;i<index;i++){

            current = current->next;
        }
        return current;*/

        if (index < 0 || index > _size - 1)
        {

            return nullptr;
        }
        int counter = 0;
        node *current = head;
        while (current != nullptr && current->next != nullptr)
        {
            if (counter == index)
            {
                break;
            }
            current = current->next;
            counter++;
        }
        return current;
    }

    // function to get valu of node
    // main idea use getnode function and return value
    //it return null if not found
    T getItem(short index)
    {
        node *nodeItem = getNode(index);
        if (nodeItem == nullptr)
        {
            return NULL;
        }
        else
        {
            return nodeItem->value;
        }
    }

    // function to update item bt take index and new value
    // it depent on getNode functioin then update value
    bool updateItem(short index, T newValue)
    {
        node *nodeUpdate = getNode(index);
        if (nodeUpdate != nullptr)
        {
            nodeUpdate->value = newValue;
            return true;
        }
        else
        {
            return false;
        }
    }

    // function to insert after by index
    // it is overloadin
    bool insertAfter(short index, T newValue)
    {
        node *afterNode = getNode(index);
        if (afterNode == nullptr)
        {
            return false;
        }
        else
        {

            insertAfter(afterNode, newValue);
            return true;
        }
    }
};
