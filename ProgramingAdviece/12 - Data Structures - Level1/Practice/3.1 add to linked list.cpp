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
 
void printLinkedList(node* head){
    while(head!=NULL){
        cout<<head->value<<" ";
        head=head->next;
    }
}
int main(){
    node* head=NULL;

    insertAtBeginning(head,1);
    insertAtBeginning(head,2);
    insertAtBeginning(head,4);

    printLinkedList(head);



}