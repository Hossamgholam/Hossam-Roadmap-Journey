#include<iostream>
#include<string>
using namespace std;
string read_number(string message){
    string number;
    cout<<message;
    cin>>number;
    return number;
}
int revers_number(int your_number){
    int reminde=0;
    int new_number=0;
    while(your_number>0){
        reminde=your_number%10;
        your_number/=10;
        new_number=new_number*10+reminde;
    }
    return new_number;
}
bool is_palindrom(int your_number){
    return your_number==revers_number(your_number);
}


bool palindrom(string your_number){
    int length=your_number.length();
    for(int i=0, y=length-1;i<length/2,y>length/2;i++,y--){
        if(your_number[i]!=your_number[y]){
            return false;
        }
    }
    return true;
}


int main(){
    cout<<palindrom(read_number("please inter your number:"))<<endl;

    int number=stoi(read_number("please inter your number"));
    if(is_palindrom(number)){
        cout<<"yes:number is palindrom\n";
    }
    else{
        cout<<"no:number is not palindrom\n";
    }
}