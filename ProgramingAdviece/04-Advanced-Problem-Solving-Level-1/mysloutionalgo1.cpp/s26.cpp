#include<iostream>
using namespace std;
void read_number(int &your_number){
    cout<<"please inter your number:";cin>>your_number;
}

void print_loop(int your_number){
    for(int i=1;i<=your_number;i++){
        cout<<i<<" ";
    }
}
void print_loop1(int your_number){
    int i=1;
    while(i<=your_number){
        cout<<i<<" ";
        i++;
    }
}
void print_loop2(int your_number){
    int i=1;
    do{
        cout<<i<<" ";
        i++;
    }while(i<=your_number);
    
}
int main(){
  int number;
  read_number(number);
  print_loop(number);cout<<"\n";
  print_loop1(number);cout<<"\n";
  print_loop2(number);cout<<"\n";
}