#include<iostream>
using namespace std;
float read_number(string messages){
    float your_number;
    //it ask you about number until tell it posative number
    do{
    cout<<messages;cin>>your_number;

    }while(your_number<0);
    return your_number;
}
//calculate your salary in monthe
float calculat_monthly_installment(float your_loan_amount,int your_number_monthly){
    return your_loan_amount/your_number_monthly;
}
int main(){
    float loan_amount=read_number("please inter loan_amount:");
    int number_monthly=read_number("please inter number_monthly:");
    
    cout<<"the monthley installment is :"<<calculat_monthly_installment(loan_amount,number_monthly);
    }