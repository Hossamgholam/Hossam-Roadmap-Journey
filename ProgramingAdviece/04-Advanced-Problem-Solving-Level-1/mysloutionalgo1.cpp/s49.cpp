#include<iostream>
using namespace std;
string read_pincode(){
    string your_pincode;
    cout<<"please inter your pincode:";cin>>your_pincode;
    return your_pincode;
}
bool login(){
    string return_pincode;
    
        return_pincode=read_pincode();
        if(return_pincode=="1234"){
            return true;
        }
        else{
            return false;
        }
        
    
}
int main(){
    if(login()){
        cout<<"correct password:";
    }else{
        cout<<"not correct password:";
    }

}