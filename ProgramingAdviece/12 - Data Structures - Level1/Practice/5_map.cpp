#include<iostream>
#include<map>
using namespace std;
void showList(map<string,int>& mstudent){
    if(mstudent.empty()){
        cout<<"ther is no student:\n";
        return;
    }
    for(const auto part:mstudent){
        cout<<"name :"<<part.first<<"\t\tdegree:"<<part.second<<endl;
    }
}
void insert(map<string,int>& mStudent){
    short number;
    cout<<"how many student you want to addd:";cin>>number;
    for(int i=0;i<number;i++){
        string name;int grade;
        cout<<"pleas inter name of student you whant to inser:";
        cin>>name;
        cout<<"pleas inter grade of stutden :";cin>>grade;
    
        mStudent[name]=grade;

    }

}
void find(map<string,int>& mstudent){
    if(mstudent.empty()){
        cout<<"ther isn not sudent\n";
        return;
    }
    string name;
    cout<<"please inter name of student to search:";cin>>name;
    if(mstudent.find(name)!=mstudent.end()){
        cout<<" we found student with name: "<<name
        <<" and his degree is :"<<mstudent[name]<<endl;
    }
    else{
        cout<<"we don not found it"<<endl;
    }
}
void showMain( map<string,int>&student){
     
    short chooice;
    cout<<"\n\n\n____________________________________________\n";
    cout<<"which opertion do you want to do:\n";
    cout<<"show list [1]\n";
    cout<<"insert    [2]\n";
    cout<<"find      [3]\n";
   
    cout<<"____________________________________________\n";
    cin>>chooice;

    switch (chooice)
    {
    
    case 1:
        showList(student);
        showMain(student);
        break;
    case 2:
        insert(student);
        showMain(student);
        break;
    
    default:
        find(student);
        showMain(student);
    }
}
int main(){
    map<string,int>student;
   showMain(student);

    
}