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

void insertAtEnd(node* head,int newValue){
    node* newNode=new node();
    newNode->value=newValue;
    newNode->next=NULL;

    if(head==NULL){
        newNode->priv=NULL;
        head=newNode;
        return ;
    }

    node* lastNode=head;
    while (lastNode->next!=NULL)
    {
        lastNode=lastNode->next;
    }

    lastNode->next=newNode;
    newNode->priv=lastNode;
    
}
void deleteNode(node* &head,node* &deleteNode){
    if(head==NULL||deleteNode==NULL){
        return;
    }
    //if ther is one node it make head=NULL then delete
    if(head->value==deleteNode->value){
        head=deleteNode->next;
        
    }
    //if deletnode not last node it do condetioni
    if(deleteNode->next!=NULL){
        deleteNode->next->priv=deleteNode->priv;
    
    }
    //if deletnode not frist node it do condetion
    if(deleteNode->priv!=NULL){
        deleteNode->priv->next=deleteNode->next;
    }
    //at last it delte node
    delete deleteNode;
}

void deleteFrist(node* &head){
    if(head==NULL){
        return;
    }

    
    node* temp=head;

    head=head->next;
    if(head!=NULL){
        head->priv=NULL;
    }
    delete temp;
}
void deleteLast(node* &head){
    if(head==NULL){
        return;
    }
    if(head->next==NULL){
        delete head;
        head=NULL;
        return;
    }

    node*current=head;
    //this loop go out befor last node;
    while(current->next->next!=NULL){
        current=current->next;
    }
    //it point to last node
    node* temp=current->next;
    current->next=NULL;
    delete temp;
}
/*

void deleteEnd(node* &head){
    node* current=head;
    if(current==NULL){
        return ;
    }
    if(current->next==NULL){
        head=current->next;
        delete current;
        return;
    }

    while(current!=NULL&&current->next!=NULL){
        current=current->next;
    }
    current->priv->next=NULL;
    delete current;


}
*/

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


    insertAtBeginning(head,4);
    insertAtBeginning(head,3);
    insertAtBeginning(head,2);
    insertAtBeginning(head,1);

    printLinkedList(head);
    cout<<endl;



    node* n=findNode(head,3);

    deleteNode(head,n);
    printLinkedList(head);
    cout<<endl;

    deleteFrist(head);
    printLinkedList(head);
    
  

}