#include<iostream>
using namespace std;
/*
arry function struct

struct(frist last age phone)
read_function(struct)
write_function(struct)
*/

struct person{
   string frist_name;
   string last_name;
   short age;
   string phone;
};

void read_info(person &yourstruct){

    cout<<"******************************************************\n";
   cout<<"please inter your frist name:";cin>>yourstruct.frist_name;
   cout<<"please inter your frist name:";cin>>yourstruct.last_name;
   cout<<"please inter your  age:";cin>>yourstruct.age;
   cout<<"please inter your phone:";cin>>yourstruct.phone;
    cout<<"******************************************************\n";
}


void writ_info(person yourstruct){
    cout<<"************************************************\n";
    cout<<"your frist name is:"<<yourstruct.frist_name<<"\n";
    cout<<"your last name is:"<<yourstruct.last_name<<"\n";
    cout<<"your age  is:"<<yourstruct.age<<"\n";
    cout<<"your phone is:"<<yourstruct.phone<<"\n";
    cout<<"************************************************\n";
}

void readperson_info(person yourcompany[2]){
    read_info(yourcompany[0]);
    read_info(yourcompany[1]);
}

void writperson_info(person yourcompany[2]){
    writ_info(yourcompany[0]);
    writ_info(yourcompany[1]);
}
int main(){

    person company1[2];

    readperson_info(company1);
    writperson_info(company1);

}