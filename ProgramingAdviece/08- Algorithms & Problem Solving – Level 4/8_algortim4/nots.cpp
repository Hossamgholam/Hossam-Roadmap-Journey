/*

13****************** short if
18******************
55******************
56****************** لا تعيد صناعة العجله
57***************** this is thing is faster;
58***************** if condition you want to check is long check condition you want not and return false;
60***************** same to 58
*/
#include<iostream>
using namespace std;
int main(){
    for(int i=0;i<20;i++){
        if(i<10){
            printf("%0*d\n",2,i);
        }
        else{
            cout<<i<<endl;
        }
    }
}