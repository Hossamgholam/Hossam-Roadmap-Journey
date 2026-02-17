#include<iostream>
using namespace std;
string read_string(string message){
    string your_password;
    cout<<message;cin>>your_password;
    return your_password;
}
bool print_all(string your_password){
    string word="";int counter=0;
    for(int i=65;i<=90;i++){
        for(int y=65;y<=90;y++){
            for(int j=65;j<=90;j++){
                word=word+char(i);
                word=word+char(y);
                word=word+char(j);
                counter++;cout<<"trial["<<counter<<"]:"<<word<<endl;
                if(your_password==word){
                    cout<<"your_password is:"<<your_password<<"\n";
                    cout<<"find after:"<<counter<<" trials\n";
                    return true;
                }
                
                word="";
                
            }
        }
    }
    return false;
}


int main(){
print_all(read_string("please inter your string:"));
}