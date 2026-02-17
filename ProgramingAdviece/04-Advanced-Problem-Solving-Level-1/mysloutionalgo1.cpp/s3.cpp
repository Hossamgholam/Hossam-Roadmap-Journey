#include<iostream>
using namespace std;
/*
void read_number(int &your_number){
    cout<"please inter your number:";cin>>number;
}
string odd_even(int your_number){
    if(your_number%2==0){
        return "even";
    }
    else if(your_number%2!=0){
        return "odd";
    }
    else{
        return "zero not odd or even"
    }
}
*/




enum enNumberType{odd=1,even=2};


int read_number(){
    int number;
    cout<<"please inter your number:";cin>>number;
}
enNumberType check_number_type(int your_number){
   if(your_number%2==0){
    return enNumberType::even;
   }
   else {
    return enNumberType::odd;
   }
}
void print_number_type(enNumberType your_enum){
    if(your_enum==enNumberType::even){
       cout<<"number is even\n";
    }
    else{
        cout<<"number is odd\n";
    }
}

int main(){
  /*
  int number;
   read_number(number);
   odd_even(number);
  */ 
 print_number_type(check_number_type(read_number()));
}