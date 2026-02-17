#include<iostream>
using namespace std;
/*
read number and check

factoriall
print
*/
int read_number(){
    int your_number;
    do{

    cout<<"please inter your number:";cin>>your_number;

    }while(your_number<0);
    return your_number;
}
int factoriall(int your_number){
    int fact=1;
    if(your_number==1||your_number==0){
        return fact;
    }
    else{
        for(int i=your_number;i>=1;i--){
            fact*=i;
        }
        return fact;
    }
}

int main(){
cout<<"the factoral is :"<<factoriall(read_number());
}