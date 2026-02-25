#include<iostream>
using namespace std;
class ClsPerson{
    private:
    string _FristName;
    string _LastName;
    
    public:

    ClsPerson(){
        _FristName="ali";
        _LastName="mohmed";
        cout<<"hello iam default constractor\n";
    }
    ClsPerson(string FristName,string LasName){
        _FristName=FristName;
        _LastName=LasName;
        cout<<"hello iam paramter constractor\n";
    }
    ClsPerson(ClsPerson& old_object){
        _FristName=old_object.GetFristName();
        _LastName=old_object.GetLastName();
        cout<<"hello iam copy constractor\n";
    }

    
    ~ClsPerson(){
        cout<<"hello iam distractor\n";
    }

    void SetFristName(string FristName){
        _FristName=FristName;

    }
    string GetFristName(){
        return _FristName;
    }

    void SetLastName(string LastName){
        _LastName=LastName;

    }
    string GetLastName(){
        return _LastName;
    }

    
    string FullName(){
        return _FristName+" "+_LastName;
    }
    __declspec(property(get=GetFristName,put=SetFristName))string _fristName;
    __declspec(property(get=GetLastName,put=SetLastName))string _LastName;
    
};
int main(){
    ClsPerson per;
    per.SetFristName("hossam");
    per.SetLastName("gholam");
    
    cout<<"your frist name   :"<<per.GetFristName()<<endl;
    cout<<"your frist name   :"<<per.GetLastName()<<endl;
    cout<<"your full name is :"<<per.FullName()<<endl;

    ClsPerson per1("Ali","gholam");
    cout<<"your frist name   :"<<per1.GetFristName()<<endl;
    cout<<"your frist name   :"<<per1.GetLastName()<<endl;
    cout<<"your full name is :"<<per1.FullName()<<endl;


    ClsPerson p=per;
    cout<<"your frull name is:"<<p.FullName()<<endl;

}