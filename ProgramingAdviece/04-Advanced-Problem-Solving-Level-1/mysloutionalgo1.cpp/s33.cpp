#include<iostream>
using namespace std;
int read_number_inrange(int from ,int to){
    int your_grad;
    do{
        cout<<"please inter your grade:";cin>>your_grad;
    }while(your_grad<from||your_grad>to);
    return your_grad;
}
char get_grad_leter(int your_grad){
    if(your_grad>=90 && your_grad<=100){
        return 'A';
    }
    else if(your_grad>=80 && your_grad<=89){
       return 'B';
    }
    else if( your_grad>=70 && your_grad<=79){
       return 'c';
    }
    else if(your_grad>=60 && your_grad<=69){
        return 'D';
    }
    else if(your_grad>=50 && your_grad<=59){
        return 'E';
    }
    else{
        return 'F';
    }
   
       
  
}
int main(){
  cout<<get_grad_leter(read_number_inrange(0,100));
}