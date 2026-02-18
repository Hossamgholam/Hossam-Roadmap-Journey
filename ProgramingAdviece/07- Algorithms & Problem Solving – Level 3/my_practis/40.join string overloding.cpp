#include<iostream>
#include<vector>
#include<string>
#include<array>
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
void read_array(string your_array[100],int &your_size){
    cout<<"how many name your want to add\n";cin>>your_size;
    for(int i=0;i<your_size;i++){
        cout<<"please inter your name:";cin>>your_array[i];
    }
}
string join_string(vector<string>your_test,string delimter){
    string your_name="";
    vector<string>::iterator item;
    for(item=your_test.begin();item<your_test.end();item++){
        your_name=your_name+*item+delimter;
    }
    return your_name.substr(0,your_name.length()-delimter.length());
}
string join_string(string your_array[100],int your_length,string delimter){
    string your_name="";
    for(int i=0;i<your_length;i++){
        your_name=your_name+your_array[i]+delimter;
    }
    return your_name.substr(0,your_name.length()-delimter.length());
}
int main(){
    vector<string>test={"hossam","alsid","salim","alsid","gholam"};
    int size;
    string array[]={"hossam","alsid","salim","alsid","gholam"};
    
    cout<<join_string(test,",");
    cout<<"\n";
    cout<<join_string(array,5," ");
    cout<<"\n\n";
    test.clear();
    array->clear();

    read_list(test);

    read_array(array,size);

    cout<<join_string(test,",");
    cout<<"\n\n";
    cout<<join_string(array,5," ");




}