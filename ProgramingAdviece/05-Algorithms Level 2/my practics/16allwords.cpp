#include<iostream>
using namespace std;
void print_all(){
    for(int i=65;i<=90;i++){
        for(int y=65;y<=90;y++){
            for(int j=65;j<=90;j++){
                cout<<char(i)<<char(y)<<char(j)<<endl;
            }
        }
    }
}
int main(){
    print_all();
}