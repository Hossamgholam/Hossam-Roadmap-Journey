#include<iostream>
using namespace std;
struct stperson_info{
    string frist_name;
    string last_name;
};
stperson_info read_person_info(){
    stperson_info your_person_info;
    cout<<"please inter your frist name:";cin>>your_person_info.frist_name;
    cout<<"please inter your last name:";cin>>your_person_info.last_name;
    return your_person_info;
}
string get_full_name(stperson_info your_person_info,bool reverse){
    if(reverse)
    return your_person_info.last_name+" "+your_person_info.frist_name;
    else
    return your_person_info.frist_name+" "+your_person_info.last_name;
}
void print_full_name(string your_full_name){
    cout<<"your full name is :"<<your_full_name<<endl;
}
int main(){
   print_full_name(get_full_name(read_person_info(),true));
}