#include<iostream>
using namespace std;
int read_number(string messages){
    int your_range;
    do{

    cout<<messages;cin>>your_range;
    }while(your_range<0);
    return your_range;
}

bool sum_divise(int your_number){
    int sum=0;
    for(int i=1;i<your_number;i++){
        if(your_number%i==0){
            sum+=i;
        }
    }
    if(sum==your_number){
        return true;
    }
    else{
        return false;
    }
}



void print_result(int your_range){
    for(int i=1;i<=your_range;i++){

    if(sum_divise(i)){
        cout<<i<<"\n";
    }
    
    }
}
int main(){
 print_result(read_number("please inter your number range:"));
}