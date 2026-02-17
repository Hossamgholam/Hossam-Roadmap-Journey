#include<iostream>
using namespace std;
enum en_operation_type{sumation='+',subsatuation='-',maltiplecation='*',division='/'};
void read_number(int &your_number1,int &your_number2){
    cout<<"pleas inter your number1:";cin>>your_number1;
    cout<<"pleas inter your number2:";cin>>your_number2;
}
void read_operation(en_operation_type &your_operation){ 
    char enter_operation;
    cout<<"please inter your operation:";cin>>enter_operation;
    your_operation=en_operation_type(enter_operation);
}
float calculat_operation(int your_number1,int your_number2,en_operation_type your_operation){

    if(your_operation==en_operation_type::sumation){
        return your_number1+your_number2;
    }
    else if(your_operation==en_operation_type::subsatuation){
        return your_number1-your_number2;
    }
    else if(your_operation==en_operation_type::maltiplecation){
        return your_number1*your_number2;
    }
    else{
        return your_number1/your_number2;
    }
}
int main(){
      int number1,number2;en_operation_type operation;
      read_number(number1,number2);
      read_operation(operation);
    cout<<"the result of operation is :"<<number1<<char(operation)<<number2<<"="<<calculat_operation(number1,number2,operation);
}