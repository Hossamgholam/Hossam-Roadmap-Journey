#include<iostream>
using namespace std;
void  f_user_information(){
cout<<"*******************************"<<endl;
cout<<"name: hossam gholam." <<endl;
cout<<"age: 20"<<endl;
cout<<"city:tant"<<endl;
cout<<"country:egypt"<<endl;
cout<<"*******************************"<<endl;
}

void f_shap_start(){
cout<<"***********"<<endl;
cout<<"***********"<<endl;
cout<<"***********"<<endl;
cout<<"***********"<<endl;
}

void f_paragraph(){
cout<<"i love programming!"<<endl<<endl;
cout<<"i promise to be the best developer ever!"<<endl<<endl;
cout<<"i know it will take som time to practice \n";
cout<<"i will achieve my goal!"<<endl<<endl;
cout<<"best regards."<<endl;
cout<<"hossam gholam"<<endl;    
}

void f_shap_h(){
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"****************"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
cout<<"*              *"<<endl;
}

void f_sum_noretrive(){
    int number1,number2;
    cout<<"please inter number1 :";cin>>number1;
    cout<<"please inter number2 :";cin>>number2;
    cout<<"*************************************\n";
    cout<<number1+number2<<endl;
}
int f_sum_retrive(){
    int number1,number2;
    cout<<"please inter number1:";cin>>number1;
    cout<<"please inter number2:";cin>>number2;
    return number1+number2;

}

int main(){
f_user_information();
cout<<"_____________________________________________________________________\n";
f_shap_start();
cout<<"________________________________________________________________________\n";
f_shap_h();
cout<<"________________________________________________________________________\n";
f_paragraph();
cout<<"________________________________________________________________________\n";
f_sum_noretrive();
cout<<"_________________________________________________________________________\n";
cout<<f_sum_retrive();
}