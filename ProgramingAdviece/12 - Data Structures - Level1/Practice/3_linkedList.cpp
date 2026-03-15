#include<iostream>
using namespace std;

class node{
    public:
    int value;
    node* next;

};
int main(){
    node* head;

    node* node1;
    node* node2;
    node* node3;

    node1=new node();
    node2=new node();
    node3=new node();

    node1->value=1;
    node2->value=2;
    node3->value=3;

    node1->next=node2;
    node2->next=node3;
    node3->next=NULL;

    head=node1;
    while(head!=NULL){
        cout<<head->value<<" ";
        head=head->next;
    }

    

}