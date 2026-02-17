#include<iostream>
using namespace std;


/*
read number

divis_number

sum_divise_number(read number){
divis_number
}

check if perfect number


*/
int read_number(string messages){
    int your_range;
    do{

    cout<<messages;cin>>your_range;
    }while(your_range<0);
    return your_range;
}
//if sum of diveser =number is perfect
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


void print_result(int your_number){
    if(sum_divise(your_number)){
        cout<<your_number<<" is perfect\n";
    }
    else{
        cout<<your_number<<" is not perfect\n";
    }
}

int main(){
print_result(read_number("please inter your number:"));
}