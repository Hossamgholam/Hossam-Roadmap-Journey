#include<iostream>
#include<vector>
#include<string>
using namespace std;
void read_list(vector<string>& your_test){
    string name;
    char repeat='y';
    do{
        cout<<"pleaser inter your name:";cin>>name;
        your_test.push_back(name);
        cout<<"do you want to add more names:";cin>>repeat;
    }while(repeat=='y');

}
string join_string(vector<string>your_test,string delimter){
    string your_name="";
    vector<string>::iterator item;
    for(item=your_test.begin();item<your_test.end();item++){
        your_name=your_name+*item+delimter;
    }
    return your_name.substr(0,your_name.length()-delimter.length());
}
int main(){
    vector<string>test;//={"hossam","alsid","salim","alsid","gholam"};
    read_list(test);
    cout<<join_string(test,",");

}