#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    cout<<message;
    cin>>your_number;
    return your_number;
}
int number_frecquency(int your_number,int your_digit){
    int frecquency =0;
    while(your_number>0){
        int remaind=0;
        remaind=your_number%10;
        your_number/=10;

        if(your_digit==remaind){
            frecquency++;
        }
        
    }
    return frecquency;
}
void print_result(int your_nubmer,int your_digit){
    
    cout<<"digit "<<your_digit<<" frequency is "<<number_frecquency(your_nubmer,your_digit)<<" times(s).";
}

int main(){
print_result(read_number("please inter your number:"),read_number("please inter your digite:"));

}