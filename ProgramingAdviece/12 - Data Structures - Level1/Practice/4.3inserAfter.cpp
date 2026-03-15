#include<iostream>
using namespace std;
class node{
    public:
    int value;
    node* next;
    node* priv;
};
void insertAtBeginning(node* &head,int newValue){
    node* newNode=new node();
    newNode->value=newValue;
    newNode->priv=NULL;
    //in to condetion it equeal to head if it null or not
    newNode->next=head;

    //if ther is no node it donot do it
    if(head!=NULL){
        head->priv=newNode;
    }
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


void insertAfter(node* aftar,int newValue){
    node* newNod=new node();

    newNod->value=newValue;
    newNod->next=aftar->next;
    newNod->priv=aftar;

    //check if there is node at last (he did not insert at end)
    if(aftar->next!=NULL){
        aftar->next->priv=newNod;
    }
    aftar->next=newNod;
}


void printLinkedList(node* head){
    cout<<"NULL <--> ";
    while(head!=NULL){
        cout<<head->value<<" <--> ";
        head=head->next;
    }
    cout<<"NULL ";
}
void printNodeDetails(node* head){
    if(head->priv==NULL){
        cout<<"NULL";
    }
    else{
        cout<<head->priv->value;
    }
    cout<<" <--> "<<head->value<<" <--> ";

    if(head->next==NULL){
        cout<<"NULL";
    }
    else{
        cout<<head->next->value<<endl;
    }
}
void printlistDetails(node* head){
    while (head!=NULL)
    {
        printNodeDetails(head);
        
        head=head->next;
    }
    
}
int main(){
       node* head=NULL;

    insertAtBeginning(head,1);
    insertAtBeginning(head,2);
    insertAtBeginning(head,3);
    insertAtBeginning(head,4);

    node* n=findNode(head,2);

    printLinkedList(head);
    cout<<endl;

    insertAfter(n,2222);

    printLinkedList(head);
    
  

}