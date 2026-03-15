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


void insertAtEnd(node* &head,int newValue){
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

void deleteNOde(node* head,int delteValue){
    node* current=head;node* priv=head;
    
    if(head==NULL){
        return;
    }
    //if there is one node
    if(current->value==delteValue){
        head=current->next;
        delete current;
    }

    while(current!=NULL&&current->value!=delteValue){
        priv=current;
        current=current->next;
    }

    if(current==NULL)return;

    priv->next=current->next;
    delete current;
}

void deleteFrist(node* &head){
    node* current=head;
    if(head==NULL){
        return ;
    }

    head=current->next;
    delete current;
}

int main(){
    node* head=NULL;


    
    insertAtEnd(head,1);
    insertAtEnd(head,2);
    insertAtEnd(head,3);
    insertAtEnd(head,4);
    insertAtEnd(head,5);
    
    printLinkedList(head);

    deleteFrist(head);
    deleteFrist(head);

    
    cout<<endl;


    printLinkedList(head);


    


}