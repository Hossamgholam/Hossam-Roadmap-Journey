#include<iostream>
using namespace std;
float read_number(string messages){
    float your_number;
    do{
    cout<<messages;cin>>your_number;

    }while(your_number<0);
    return your_number;
}
float calculat_number_monthly(float your_loan_amount,int your_monthly_installment){
    return your_loan_amount/your_monthly_installment;
}
int main(){
    float loan_amount=read_number("please inter loan_amount:");
    int monthly_installment=read_number("please inter monthly_installment:");
    
    cout<<"the number of monthley your want is:"<<calculat_number_monthly(loan_amount,monthly_installment);
    }