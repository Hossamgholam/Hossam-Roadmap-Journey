#include<iostream>
using namespace std;
enum enpass_fail{pass=1,fail=2};

void read_numbers(int &number1,int &number2,int &number3){
    
    cout<<"please inter your frist number:";cin>>number1;
    cout<<"please inter your second number:";cin>>number2;
    cout<<"please inter your thered number:";cin>>number3;
    
}
int calculat_sum(int n1,int n2,int n3){
    return n1+n2+n3;
}
float calculat_average(int n1,int n2,int n3){
    return (float) calculat_sum(n1,n2,n3)/3;
}
void print_average(float your_average){
    cout<<"the average of treee number is "<<your_average<<endl;
}

enpass_fail average_pass_fail(float your_average){
    if(your_average>=50){
        return enpass_fail::pass;
    }
    else{
        return enpass_fail::fail;
    }
}

void print_average_pass_fail(float your_average){
    if(average_pass_fail(your_average)==enpass_fail::pass){
        cout<<"congratiulation you pass \n";
    }
    else{
        cout<<"sorry you fail\n";
    }
}
int main(){
    int number1,number2,number3;
    read_numbers(number1,number2,number3);
    
    print_average(calculat_average(number1,number2,number3));


     print_average_pass_fail(calculat_average(number1,number2,number3));
}
