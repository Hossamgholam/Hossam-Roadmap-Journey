#include<iostream>
using namespace std;
struct stinfo{
    string fristname;
    string lastname;
    int age;
    string phone;
};
void ReadInfo(stinfo YourPerson[100],int&size){
    
    char repeat='N';
    do{
        size++;
        cout<<"pleas inter your frist name :";cin>>YourPerson[size].fristname;
        cout<<"pleas inter your last name  :";cin>>YourPerson[size].lastname;
        cout<<"pleas inter your age        :";cin>>YourPerson[size].age;
        cout<<"pleas inter your frist phone:";cin>>YourPerson[size].phone;
        cout<<"__________________________________________________________\n";
        cout<<"do you want to add more person";cin>>repeat;
        cout<<"__________________________________________________________\n\n\n";
    }while(repeat=='y'||repeat=='Y');
}
void WriteInfo(stinfo YourPerson[100],int size){
    int i=-1;
    do{
        i++;
        cout<<"___________________________________________________________\n";
        cout<<"client ["<<i<<"]\n";
        cout<<"___________________________________________________________\n";
        cout<<"your frist name is:"<<YourPerson[i].fristname<<endl;
        cout<<"your last name is :"<<YourPerson[i].lastname<<endl;
        cout<<"your age          :"<<YourPerson[i].age<<endl;
        cout<<"your frist name is:"<<YourPerson[i].phone<<endl;
        cout<<"\n\n";
    }while(i<=size);
    
}
int main(){
    stinfo person1[100];int size=-1;
    ReadInfo(person1,size);
    WriteInfo(person1,size);
    /*
    
    person1[0].fristname="hossam";
    person1[0].lastname="gholam";
    person1[0].age=22;
    person1[0].phone="01021832326";

    
    person1[1].fristname="ahmed";
    person1[1].lastname="gmail";
    person1[1].age=22;
    person1[1].phone="01583829";


cout<<person1[0].fristname;
    */
    
}