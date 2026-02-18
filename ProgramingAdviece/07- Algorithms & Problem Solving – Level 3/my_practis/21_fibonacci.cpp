#include<iostream>
using namespace std;
/*

fibonacci

*/

void fibonacci(){
    int array[10]={};
    array[0]=1;array[1]=1;
    for(int i=0;i<10;i++){
        if(i==1||i==0){
            cout<<array[i]<<"\t";
        }
        else{
            array[i]=array[i-2]+array[i-1];
            cout<<array[i]<<"\t";
        }
    }
}

void fibonanc(int number){
    int concerrent=0;
    int privic1=1;int privic2=0;
    cout<<1<<"    ";
    for(int i=2;i<=number;i++){
        concerrent=privic1+privic2;
        cout<<concerrent<<"     ";
        privic2=privic1;
        privic1=concerrent;
    }
}
int main(){
 
    fibonanc(10);
}