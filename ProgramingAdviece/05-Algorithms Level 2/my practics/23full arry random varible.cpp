#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;

int randomvarible(int your_from,int your_to){
    int random=rand()%(your_to-your_from+1)+your_from;
    return random;
}
void full_arry(int your_arry[100],int &your_size){
    cout<<"please inter your size:";cin>>your_size;

    for(int i=0;i<your_size;i++){
        your_arry[i]=randomvarible(1,100);
    }
}
void print_arry(int your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<"\n";
}
int main(){
    srand(time(0));
    int size,random_arry[100];
   
    full_arry(random_arry,size);
    print_arry(random_arry,size);
    print_arry(random_arry,size);
    print_arry(random_arry,size);
}
