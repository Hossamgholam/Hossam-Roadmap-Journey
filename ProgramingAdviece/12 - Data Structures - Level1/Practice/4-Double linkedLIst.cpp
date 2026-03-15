#include<iostream>
using namespace std;
class node{
    public:
    int value;
    node* next;
    node* priv;
};
int main(){
    node*head=NULL;
    node*tail=NULL;

    node* node1=new node();
    node* node2=new node();
    node* node3=new node();

    node1->value=1;
    node2->value=2;
    node3->value=3;
     

    node1->next=node2;
    node2->next=node3;
    node3->next=NULL;

    node3->priv=node2;
    node2->priv=node1;
    node1->priv=NULL;

    head=node1;
    tail=node3;

    while(head!=NULL){
        cout<<head->value<<" ";
        head=head->next;
    }
    cout<<endl<<endl;

    while(tail!=NULL){
        cout<<tail->value<<" ";
        tail=tail->priv;
    }
}