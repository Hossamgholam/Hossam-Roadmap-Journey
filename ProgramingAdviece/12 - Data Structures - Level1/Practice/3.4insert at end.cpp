#include<iostream>
using namespace std;
class node{
    public:
    int value;
    node* next;

};
void insertAtBeginning(node* &head ,int newValue){
    node* newNode=new node();

    newNode->value=newValue;
    newNode->next=head;

    head=newNode;

}
node* findNode(node* head,int value){
    while(head!=NULL){
        if(head->value==value){
            return head;
        }
        head=head->next;
        
    }
    return NULL;
}
void insertAfter(node* after,int newValue){
    if(after==NULL){
        cout<<"node not foun(-";
        return;
    }
    node* newNode=new node();
    newNode->value=newValue;
    newNode->next=after->next;
    after->next=newNode;
}

void printLinkedList(node* head){
    while(head!=NULL){
        cout<<head->value<<" ";
        head=head->next;
    }
}

void insertAtEnd(node*head,int newValue){
    node* newNode=new node();
    newNode->value=newValue;
    newNode->next=NULL;

    if(head==NULL){
        head=newNode;
        return;
    }
    node* lastNode=head;
    while(lastNode->next!=NULL){
        lastNode=lastNode->next;
    }
    lastNode->next=newNode;
    return;
}

int main(){
    node* head=NULL;

    //if we insert for beging or end as frist element 
    //in insert we make newNode point on head that is null 
    //thent we make head = newNode
    insertAtBeginning(head,1);
    insertAtEnd(head,3);
    insertAtEnd(head,8);
   

    printLinkedList(head);

    


}