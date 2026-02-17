#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    do{
    cout<<message;cin>>your_number;
    
    }while(your_number<0);

    return your_number;
}
void inverted(int your_number){
    for(int i=your_number;i>=1;i--){
        for(int y=i;y>=1;y--){
            cout<<i;
        }
        cout<<"\n";
    }
}
int main(){
    inverted(read_number("please inter your number:"));

}