#include<iostream>
using namespace std;
int read_number_inrange(){
    int your_total_salary;
        cout<<"please inter your grade:";cin>>your_total_salary;
    return your_total_salary;
}
float get_percentage(int your_total_salary){
    if(your_total_salary>=1000,000){
        return 0.01;
    }
    else if(your_total_salary>=500,000&&your_total_salary<1000,000){
       return 0.02;
    }
    else if( your_total_salary>=100,000 && your_total_salary<500,000){
       return 0.03;
    }
    else if( your_total_salary>=50,000 && your_total_salary<100,000){
        return 0.05 ;
    }
    
    else{
        return 0;
    }

}
float claculat_total_salary(int your_total_salary){
    
    if(get_percentage(your_total_salary)==0){
        return your_total_salary;
    }
    else{
        return your_total_salary*get_percentage(your_total_salary);
    }
}
int main(){

    int total_salary=read_number_inrange();
  cout<<"the percentage is :"<<get_percentage(total_salary)<<endl;
  cout<<"the total salary after add:"<<claculat_total_salary(total_salary);
}