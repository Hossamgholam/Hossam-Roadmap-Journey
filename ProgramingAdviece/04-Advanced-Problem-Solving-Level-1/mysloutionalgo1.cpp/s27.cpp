#include<iostream>
using namespace std;
void read_number(int &your_number){
    cout<<"please inter your number:";cin>>your_number;
}

void print_loop(int your_number){
    for(int i=your_number;i>=1;i--){
        cout<<i<<" ";
    }
}
void print_loop1(int your_number){
    int i=your_number;
    while(i>=1){
        cout<<i<<" ";
        i--;
    }
}
void print_loop2(int your_number){
    int i=your_number;
    do{
        cout<<i<<" ";
        i--;
    }while(i>=1);
    
}
int main(){
  int number;
  read_number(number);
  print_loop(number);cout<<"\n";
  print_loop1(number);cout<<"\n";
  print_loop2(number);cout<<"\n";
}