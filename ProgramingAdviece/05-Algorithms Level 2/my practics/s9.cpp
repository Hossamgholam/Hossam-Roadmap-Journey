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
void print_alldigit_freq(int your_number){
   for(int i=0;i<10;i++){
    int digit_frequecy=number_frecquency(your_number,i);
    if(digit_frequecy>0){
        cout<<"digit "<<i<<" frequecy is"<<digit_frequecy<<" times"<<endl;
    }
   }
}

int main(){
    print_alldigit_freq(read_number("plesea inter your number:"));
}