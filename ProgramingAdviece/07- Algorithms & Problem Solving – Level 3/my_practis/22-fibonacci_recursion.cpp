#include<iostream>
using namespace std;
/*

fibonacci

*/

void fibonacci(){
   
}

void fibonanc(int number,int privec1,int privec2){
    int concerrent=0;
    if(number>0){
         concerrent=privec1+privec2;
        cout<<concerrent<<"     ";
        privec2=privec1;
        privec1=concerrent;
        fibonanc(number-1,privec1,privec2);
    }
    
   
}
int main(){
 
    fibonanc(10,0,1);
}