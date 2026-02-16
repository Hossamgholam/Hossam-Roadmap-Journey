#include<iostream>
using namespace std;
struct infoperson{
    string frist_name;
    string last_name;
    int age;
    string phone;
};
void readinfo(infoperson &p_infoperson){
    cout<<"please inter your frist name:";cin>>p_infoperson.frist_name;
    cout<<"please inter your last name :";cin>>p_infoperson.last_name;
    cout<<"please inter your age       :";cin>>p_infoperson.age;
    cout<<"please inter your phone     :";cin>>p_infoperson.phone;
}
void writeinfo(infoperson p_infoperson){
    cout<<"________________________________________________________\n";
    cout<<"your frist name is          :"<<p_infoperson.frist_name<<endl;
    cout<<"your last name is           :"<<p_infoperson.last_name<<endl;
    cout<<"your age  is                :"<<p_infoperson.age<<endl;
    cout<<"your phone is               :"<<p_infoperson.phone<<endl;
    cout<<"________________________________________________________\n";
}
int main(){

    infoperson person1;
    readinfo(person1);
    writeinfo(person1);
    

}