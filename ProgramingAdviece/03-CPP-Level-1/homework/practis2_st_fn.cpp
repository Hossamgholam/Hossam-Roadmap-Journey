#include<iostream>
using namespace std;
struct person{
    string name;
    short age;
    string city;
    string counter;
    float monthl_salart;
    float yearly_salary=monthl_salart*12;
    char gender;
    bool married;
   
};
void readinfo(person &person){
    cout<<"____________________________________________________________________\n";
    cout<<"please inter yoour name:";cin>>person.name;
    cout<<"please inter yoour age:";cin>>person.age;
    cout<<"please inter yoour city:";cin>>person.city;
    cout<<"please inter yoour counter:";cin>>person.counter;
    cout<<"please inter yoour monthly salary:";cin>>person.monthl_salart;
    cout<<"please inter yoour gender:";cin>>person.gender;
    cout<<"please inter yoour if you marrid or single:";cin>>person.married;
    cout<<"_____________________________________________________________________\n";
}
void writeinfo(person &person){
    cout<<"name: "<<person.name<<"\n";
    cout<<"age: "<<person.age<<" year\n";
    cout<<"city: "<<person.city<<"\n";
    cout<<"countery: "<<person.counter<<"\n";
    cout<<"monthly salary: "<<person.monthl_salart<<"\n";
    cout<<"yearly salary: "<<person.yearly_salary<<"\n";
    cout<<"gender: "<<person.gender<<"\n";
    cout<<"is marrid:"<<person.married;
}
int main(){

    person p1;
    readinfo (p1);
    writeinfo(p1);

    return (0);

}